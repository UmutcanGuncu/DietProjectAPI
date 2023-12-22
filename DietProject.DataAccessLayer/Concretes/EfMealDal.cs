using System;
using DietProject.DataAccessLayer.Abstracts;
using DietProject.DataAccessLayer.Context;
using DietProject.DTO.Models;
using DietProject.EntityLayer.Entities;

namespace DietProject.DataAccessLayer.Concretes
{
    public class EfMealDal : GenericRepository<Meal>, IMealDal
    {
        private readonly DietDbContext _dietDbContext;
        public EfMealDal(DietDbContext context) : base(context)
        {
            _dietDbContext = context;
        }

        public void AddMealFood(MealFoodDto model)
        {
            Food food = _dietDbContext.foods.Find(model.FoodId);
            Meal meal = new Meal()
            {
                AppUserId = model.AppUserId,
                MealType = food.Type,
                Date = DateTime.Now
            };
            _dietDbContext.meals.Add(meal);
            meal.Foods.Add(food);
            food.Meals.Add(meal);
            _dietDbContext.SaveChanges();
        }
    }
}

