using System;
using DietProject.DataAccessLayer.Abstracts;
using DietProject.DataAccessLayer.Context;
using DietProject.EntityLayer.Entities;

namespace DietProject.DataAccessLayer.Concretes
{
    public class EfUserInformationDal : GenericRepository<UserInformation>, IUserInformationDal
    {
        public EfUserInformationDal(DietDbContext context) : base(context)
        {
        }
    }
}

