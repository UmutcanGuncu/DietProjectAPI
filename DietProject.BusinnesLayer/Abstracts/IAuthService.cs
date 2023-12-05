using System;
using DietProject.DTO.Models;

namespace DietProject.BusinnesLayer.Abstracts
{
	public interface IAuthService
	{
		public Task<bool> RegisterUser(RegisterUser user);
		public Task<bool> LoginUser(LoginUser user);
	}
}

