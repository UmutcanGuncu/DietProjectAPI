using System;
using DietProject.EntityLayer.Common;

namespace DietProject.EntityLayer.Entities
{
	public class Food : BaseEntity
	{
		public string Name { get; set; }
		public string ImageUrl { get; set; }
		public int Calorie { get; }
		public int Fat { get; set; }
		public int Carbonhydrate { get; set; }
		public int Protein { get; set; }
        public int MealId { get; set; }
		public Meal Meal { get; set; }
    }
}

