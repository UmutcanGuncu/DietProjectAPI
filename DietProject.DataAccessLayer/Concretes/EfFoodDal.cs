using System;
using DietProject.DataAccessLayer.Abstracts;
using DietProject.DataAccessLayer.Context;
using DietProject.EntityLayer.Entities;

namespace DietProject.DataAccessLayer.Concretes
{
    public class EfFoodDal : GenericRepository<Food>, IFoodDal
    {
        public EfFoodDal(DietDbContext context) : base(context)
        {
        }
    }
}

