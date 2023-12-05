using System;
using DietProject.DTO.Models;

namespace DietProject.DataAccessLayer.Abstracts
{
	public interface IAuthDal
	{
        public Task<bool> RegisterUser(RegisterUser user);
        public Task<bool> LoginUser(LoginUser user);
    }
}

