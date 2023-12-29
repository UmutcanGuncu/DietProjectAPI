using System;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using DietProject.BusinnesLayer.Abstracts;
using DietProject.DTO.Models;
using DietProject.EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DietProject.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class AuthController : ControllerBase
	{
		private readonly IAuthService _authService;
        private readonly UserManager<AppUser> _userManager;

        public AuthController(IAuthService authService, UserManager<AppUser> userManager)
        {
			_userManager = userManager;
            _authService = authService;
        }

        [HttpPost("register")]
		public async Task<IActionResult> RegisterUser(RegisterUser user)
		{
			var result = await _authService.RegisterUser(user);
			if(result == true)
			{
				return Ok();
			}
			else
			{
				return BadRequest();
			}

		}
		[HttpPost("login")]
		public async Task<IActionResult> LoginUser(LoginUser user)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest();
			}
			var result = await _authService.LoginUser(user);
			if(result == true)
			{
				var value = await _userManager.FindByEmailAsync(user.Email);
				var userId = new UserIdDTO { UserId = value.Id, Role = value.Role };
				var data = JsonConvert.SerializeObject(userId);
				return Ok(data);
			}
			

			return BadRequest();
		}
	}
}

