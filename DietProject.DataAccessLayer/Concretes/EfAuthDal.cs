using System;
using DietProject.DataAccessLayer.Abstracts;
using DietProject.DTO.Models;
using DietProject.EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;

namespace DietProject.DataAccessLayer.Concretes
{
    public class EfAuthDal : IAuthDal
    {
        private readonly UserManager<AppUser> _userManager;

        public EfAuthDal(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<bool> LoginUser(LoginUser user)
        {
            var appUser = await _userManager.FindByEmailAsync(user.Email);
            if(appUser is null)
            {
                return false;
            }
            return await _userManager.CheckPasswordAsync(appUser, user.Password);
        }

        public async Task<bool> RegisterUser(RegisterUser user)
        {
            var appUser = new AppUser
            {
                Name = user.Name,
                Surname = user.Surname,
                UserName = user.UserName,
                Email = user.Email
            };
            var result =  await _userManager.CreateAsync(appUser, user.Password);
            return result.Succeeded;
        }
    }
}

