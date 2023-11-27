using System;
using Microsoft.AspNetCore.Identity;

namespace DietProject.EntityLayer.Entities
{
	public class AppUser:IdentityUser<int>
	{
		public UserInformation UserInformation { get; set; }
		public ICollection<Meal> Meals { get; set; }
	}
}

