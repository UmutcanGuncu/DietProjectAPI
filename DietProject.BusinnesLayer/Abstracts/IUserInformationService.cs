using System;
using DietProject.EntityLayer.Entities;

namespace DietProject.BusinnesLayer.Abstracts
{
	public interface IUserInformationService : IGenericService<UserInformation>
	{
        public void AddOrUpdate(UserInformation userInformation);
    }
}

