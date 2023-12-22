using DietProject.DTO.Models;
using DietProject.EntityLayer.Entities;

using System;
namespace DietProject.DataAccessLayer.Abstracts
{
	public interface IMealDal : IGenericDal<Meal>
	{
        public void AddMealFood(MealFoodDto model);
        
    }
}

