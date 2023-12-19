using System;
using DietProject.EntityLayer.Entities;

namespace DietProject.BusinnesLayer.Abstracts
{
	public interface IFoodService : IGenericService<Food>
	{
        public List<Food> getFoodWithType(string type);

    }
}

