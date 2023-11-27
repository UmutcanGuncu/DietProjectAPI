using System;
using DietProject.DataAccessLayer.Abstracts;
using DietProject.DataAccessLayer.Context;
using DietProject.EntityLayer.Entities;

namespace DietProject.DataAccessLayer.Concretes
{
    public class EfMealDal : GenericRepository<Meal>, IMealDal
    {
        public EfMealDal(DietDbContext context) : base(context)
        {
        }
    }
}

