using System;
using DietProject.BusinnesLayer.Abstracts;
using DietProject.DataAccessLayer.Abstracts;
using DietProject.EntityLayer.Entities;

namespace DietProject.BusinnesLayer.Concretes
{
    public class UserInformationManager : IUserInformationService
    {
        private readonly IUserInformationDal _userInformationDal;

        public UserInformationManager(IUserInformationDal userInformationDal)
        {
            _userInformationDal = userInformationDal;
        }

        public void Add(UserInformation t)
        {
            _userInformationDal.Add(t);
        }

        public void AddOrUpdate(UserInformation userInformation)
        {
            _userInformationDal.AddOrUpdate(userInformation);
        }

        public void Delete(UserInformation t)
        {
            _userInformationDal.Delete(t);
        }

        public UserInformation GetById(int id)
        {
            return _userInformationDal.GetById(id);
        }

        public List<UserInformation> GetList()
        {
            return _userInformationDal.GetList();
        }

        public void Update(UserInformation t)
        {
            _userInformationDal.Update(t);
        }
    }
}

