using System;
using DietProject.DTO.Models;
using DietProject.EntityLayer.Entities;

namespace DietProject.BusinnesLayer.Abstracts
{
	public interface IMealService : IGenericService<Meal>
	{
        public void AddMealFood(MealFoodDto model);
    }
}

