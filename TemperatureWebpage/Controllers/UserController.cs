using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Org.BouncyCastle.Crypto.Generators;
using TemperatureWebpage.Data;
using TemperatureWebpage.Models;
using TemperatureWebpage.Utilities;

namespace TemperatureWebpage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly ApplicationDbContext _context;
        int BCryptWorkFactor = 11;
        private readonly AppSettings _appSettings;

        public UserController(ApplicationDbContext context, IOptions<AppSettings> appSettings) 
        {
            _context = context;
            _appSettings = appSettings.Value;
        }

        [HttpGet("GetUser")]
        public async Task<ActionResult<DTOUser>> GetUser(int id)
        {
            var user = _context.DTOUsers.Find(id);
            return Content($"{user.Email} {user.Id}");
        }

        [HttpPost("Register"), AllowAnonymous]
        public async Task<ActionResult<DTOToken>> Register(ApplicationUser appUser)
        {
            var user = new DTOUser()
            {
                Email = appUser.Email.ToLower(),
                Name = appUser.Name,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(appUser.Password, _appSettings.BcryptWorkfactor)
            };
            _context.DTOUsers.Add(user);
            await _context.SaveChangesAsync();

            var jwtToken = new DTOToken();
            jwtToken.JWT = GenerateToken(user.Email);
            return CreatedAtAction("GetUser", new { id = user.Id }, jwtToken);
        }

       [HttpPost("Login"), AllowAnonymous]
       public async Task<ActionResult<DTOToken>> Login(Login login)
       {
            login.Email = login.Email.ToLower();
            var user = await _context.DTOUsers.Where(user => user.Email == login.Email).FirstOrDefaultAsync();
            if (user != null)
            {
                var validPwd = BCrypt.Net.BCrypt.Verify(login.Password, user.PasswordHash);
                if (validPwd)
                {
                    return new DTOToken { JWT = GenerateToken(user.Email) };
                }
            }
            ModelState.AddModelError(string.Empty, "Forkert brugernavn eller password!");
            return BadRequest(ModelState);
        }


        //[HttpGet("Register/{id}"), AllowAnonymous]
        //public ActionResult<DTOUser> Get(string userId)
        //{
        //    var user = new DTOUser() { UserId = userId };
        //    return user;
        //}

        //Generate Token hjælpefunktion
        private string GenerateToken(string username)
        {
            var claims = new Claim[]
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Role, "Client"),
                new Claim(JwtRegisteredClaimNames.Nbf, new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds().ToString()),
                new Claim(JwtRegisteredClaimNames.Exp, new DateTimeOffset(DateTime.Now.AddDays(1)).ToUnixTimeSeconds().ToString()),
            };

            var key = Encoding.ASCII.GetBytes(_appSettings.SecretKey);
            var token = new JwtSecurityToken(
                new JwtHeader(new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256)),
                    new JwtPayload(claims));

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        //[HttpPost("Logout")]
        //public async Task<IActionResult> Logout()
        //{
        //    await _signInManager.SignOutAsync();
        //    return Ok();
        //}
    }
}