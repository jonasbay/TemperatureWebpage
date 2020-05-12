using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TemperatureWebpage.Models;

namespace TemperatureWebpage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public UserController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager) 
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet("Register/{id}"), AllowAnonymous]
        public ActionResult<DTOUser> Get(string userId)
        {
            var user = new DTOUser() { Id = userId };
            return user;
        }

        //Nedenstående kode er taget fra slides "12 Secure Web API"

        [HttpPost("Register"), AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] DTOUser dtoUser)
        {
            var newUser = new ApplicationUser
            {
                UserName = dtoUser.Email,
                Email = dtoUser.Email,
                Name = dtoUser.Name
            };

            var userCreationResult = await _userManager.CreateAsync(newUser, password);

            if (userCreationResult.Succeeded)
            {
                return Ok(newUser);
            }
            foreach (var error in userCreationResult.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);

            }
            return BadRequest(ModelState);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] DTOUser dtoUser)
        {
            var passwordSignInResult = await _signInManager.PasswordSignInAsync(email, password, isPersistent: false, lockoutOnFailure: false);
            if (passwordSignInResult.Succeeded)
            {
                return Ok();
            }
            ModelState.AddModelError(string.Empty, "Invalid login");
            return BadRequest(ModelState);
        }

        [HttpPost("Logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok();
        }

    }
}