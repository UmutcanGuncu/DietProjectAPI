﻿using System;
namespace DietProject.DTO.Models
{
	public class RegisterUser
	{
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string UserRole { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

