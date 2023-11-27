using System;
using Microsoft.EntityFrameworkCore;

namespace DietProject.EntityLayer.Entities
{
    [Keyless]
    public class MealFood
	{
        
        public int MealId { get; set; }
        public Meal Meal { get; set; }

        public int FoodId { get; set; }
        public Food Food { get; set; }
    }
}

