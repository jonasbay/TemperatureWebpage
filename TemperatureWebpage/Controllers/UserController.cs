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
using Microsoft.IdentityModel.Tokens;
using Org.BouncyCastle.Crypto.Generators;
using TemperatureWebpage.Data;
using TemperatureWebpage.Models;

namespace TemperatureWebpage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //private readonly UserManager<IdentityUser> _userManager;
        //private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext context/*UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager*/) 
        {
            //_userManager = userManager;
            //_signInManager = signInManager;
            _context = context;
        }

        [HttpGet("Register/{id}"), AllowAnonymous]
        public ActionResult<DTOUser> Get(string userId)
        {
            var user = new DTOUser() { Id = userId };
            return user;
        }

        //Nedenstående kode er taget fra slides "12 Secure Web API"
        //[HttpPost("Register"), AllowAnonymous]
        //public async Task<IActionResult> Register([FromBody] DTOUser dtoUser)
        //{
        //    var newUser = new ApplicationUser
        //    {
        //        UserName = dtoUser.Email,
        //        Email = dtoUser.Email.ToLower(),
        //        Name = dtoUser.Name
        //    };

        //    var userCreationResult = await _userManager.CreateAsync(newUser, password);

        //    if (userCreationResult.Succeeded)
        //    {
        //        return Ok(newUser);
        //    }
        //    foreach (var error in userCreationResult.Errors)
        //    {
        //        ModelState.AddModelError(string.Empty, error.Description);

        //    }
        //    return BadRequest(ModelState);
        //}

        int BCryptWorkFactor = 11;

        [HttpPost("Register"), AllowAnonymous]
        public async Task<ActionResult<DTOToken>> Register(DTOUser dtoUser)
        {
            var user = new ApplicationUser()
            {
                Email = dtoUser.Email.ToLower(),
                UserName = dtoUser.Email,
                Name = dtoUser.Name,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(dtoUser.Password, BCryptWorkFactor)
            };
            _context.ApplicationUsers.Add(user);
            await _context.SaveChangesAsync();

            var jwtToken = new DTOToken();
            jwtToken.JWT = GenerateToken(user.Email);
            return CreatedAtAction("Get", new { id = user.Id }, jwtToken);
        }

        //Generate Token hjælpefunktion
        private string GenerateToken(string username)
        {
            var claims = new Claim[]
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(JwtRegisteredClaimNames.Nbf, new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds().ToString()),
                new Claim(JwtRegisteredClaimNames.Exp, new DateTimeOffset(DateTime.Now.AddDays(1)).ToUnixTimeSeconds().ToString()),
            };
            var token = new JwtSecurityToken(
                new JwtHeader(new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes("the secret that needs to be at least 16 characeters long for HmacSha256")),
                    SecurityAlgorithms.HmacSha256)),
                    new JwtPayload(claims));
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        //[HttpPost("Login")]
        //public async Task<IActionResult> Login([FromBody] DTOUser dtoUser)
        //{
        //    var passwordSignInResult = await _signInManager.PasswordSignInAsync(email, password, isPersistent: false, lockoutOnFailure: false);
        //    if (passwordSignInResult.Succeeded)
        //    {
        //        return Ok();
        //    }
        //    ModelState.AddModelError(string.Empty, "Invalid login");
        //    return BadRequest(ModelState);
        //}

        //[HttpPost("Logout")]
        //public async Task<IActionResult> Logout()
        //{
        //    await _signInManager.SignOutAsync();
        //    return Ok();
        //}
    }
}