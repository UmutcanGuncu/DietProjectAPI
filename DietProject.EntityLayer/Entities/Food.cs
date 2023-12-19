using System;
using DietProject.EntityLayer.Common;

namespace DietProject.EntityLayer.Entities
{
	public class Food : BaseEntity
	{
		public string Name { get; set; }
		public double Calorie { get; set; }
		public double Fat { get; set; }
		public double Carbonhydrate { get; set; }
		public double Protein { get; set; }
		public string Type { get; set; }
        public ICollection<Meal> Meals { get; set; } = new List<Meal>();
    }
}

