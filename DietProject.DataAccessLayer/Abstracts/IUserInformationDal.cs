using System;
using DietProject.EntityLayer.Entities;

namespace DietProject.DataAccessLayer.Abstracts
{
	public interface IUserInformationDal
	{
        List<UserInformation> GetList();
        void Add(UserInformation t);
        void Delete(UserInformation t);
        void Update(UserInformation t);
        UserInformation GetById(int id);
        public void AddOrUpdate(UserInformation userInformation);
    }
}

