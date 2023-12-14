using System;
using DietProject.BusinnesLayer.Abstracts;
using DietProject.DataAccessLayer.Context;
using DietProject.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DietProject.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class UserInformationController : ControllerBase
	{
		private readonly IUserInformationService _userInformationService;
        private readonly DietDbContext _context;

        public UserInformationController(IUserInformationService userInformationService, DietDbContext context)
        {
            _userInformationService = userInformationService;
            _context = context;
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

            _userInformationService.AddOrUpdate(userInformation);
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

