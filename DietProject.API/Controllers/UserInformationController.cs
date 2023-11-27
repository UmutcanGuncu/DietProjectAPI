using System;
using DietProject.BusinnesLayer.Abstracts;
using DietProject.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DietProject.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class UserInformationController : ControllerBase
	{
		private readonly IUserInformationService _userInformationService;

        public UserInformationController(IUserInformationService userInformationService)
        {
            _userInformationService = userInformationService;
        }
        [HttpGet]
        public IActionResult GetUserInformationList()
        {
            var values = _userInformationService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddUserInformation(UserInformation userInformation)
        {
            _userInformationService.Add(userInformation);
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteUserInformation(int id)
        {
            var value = _userInformationService.GetById(id);
            _userInformationService.Delete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateUserInformation(UserInformation userInformation)
        {
            _userInformationService.Update(userInformation);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _userInformationService.GetById(id);
            return Ok(value);
        }
    }
}

