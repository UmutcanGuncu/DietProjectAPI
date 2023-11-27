using System;
using DietProject.EntityLayer.Common;

namespace DietProject.EntityLayer.Entities
{
    public class Meal : BaseEntity
    {
        public List<Food> Foods { get; set; }
        public DateOnly Date { get; set; }
        public string MealType { get; set; }

    }
}

