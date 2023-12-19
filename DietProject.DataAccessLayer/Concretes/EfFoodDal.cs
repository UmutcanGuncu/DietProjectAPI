using System;
using DietProject.DataAccessLayer.Abstracts;
using DietProject.DataAccessLayer.Context;
using DietProject.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DietProject.DataAccessLayer.Concretes
{
    public class EfFoodDal : GenericRepository<Food>, IFoodDal
    {
        private readonly DietDbContext dietDbContext;
        public EfFoodDal(DietDbContext context) : base(context)
        {
            dietDbContext = context;
        }

        public List<Food> getFoodWithType(string type)
        {
            return dietDbContext.foods.AsNoTracking().Where(x => x.Type == type).ToList();
        }
    }
}

