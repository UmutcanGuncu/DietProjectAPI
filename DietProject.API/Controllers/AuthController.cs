using System;
using DietProject.BusinnesLayer.Abstracts;
using DietProject.DTO.Models;
using DietProject.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DietProject.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class AuthController : ControllerBase
	{
		private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
		public async Task<IActionResult> RegisterUser(RegisterUser user)
		{
			var result = await _authService.RegisterUser(user);
			if(result == true)
			{
				return Ok(true);
			}
			else
			{
				return Ok(false);
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
			return Ok();

			return BadRequest();
		}
	}
}

