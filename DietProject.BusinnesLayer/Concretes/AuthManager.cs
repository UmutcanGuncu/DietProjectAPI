using System;
using DietProject.BusinnesLayer.Abstracts;
using DietProject.DataAccessLayer.Abstracts;
using DietProject.DTO.Models;

namespace DietProject.BusinnesLayer.Concretes
{
    public class AuthManager : IAuthService
    {
        private readonly IAuthDal _authDal;

        public AuthManager(IAuthDal authDal)
        {
            _authDal = authDal;
        }

        public async Task<bool> LoginUser(LoginUser user)
        {
            return await _authDal.LoginUser(user);
        }

        public async Task<bool> RegisterUser(RegisterUser user)
        {
            return await _authDal.RegisterUser(user);
        }
    }
}

