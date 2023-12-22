using System;
using DietProject.EntityLayer.Common;

namespace DietProject.EntityLayer.Entities
{
    public class Meal : BaseEntity
    {
        
        public DateTime Date { get; set; }
        public string MealType { get; set; }
        public ICollection<Food> Foods { get; set; } = new List<Food>();
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}

