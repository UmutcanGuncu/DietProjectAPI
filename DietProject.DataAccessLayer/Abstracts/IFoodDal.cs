using System;
using DietProject.EntityLayer.Entities;

namespace DietProject.DataAccessLayer.Abstracts
{
	public interface IFoodDal:IGenericDal<Food>
	{
		public List<Food> getFoodWithType(String type);

    }
}

