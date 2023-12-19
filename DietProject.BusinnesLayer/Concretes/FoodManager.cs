using System;
using DietProject.BusinnesLayer.Abstracts;
using DietProject.DataAccessLayer.Abstracts;
using DietProject.EntityLayer.Entities;

namespace DietProject.BusinnesLayer.Concretes
{
    public class FoodManager : IFoodService
    {
        private readonly IFoodDal _foodDal;

        public FoodManager(IFoodDal foodDal)
        {
            _foodDal = foodDal;
        }

        public void Add(Food t)
        {
            _foodDal.Add(t);
        }

        public void Delete(Food t)
        {
            _foodDal.Delete(t);
        }

        public Food GetById(int id)
        {
            return _foodDal.GetById(id);
        }

        public List<Food> getFoodWithType(string type)
        {
            return _foodDal.getFoodWithType(type);
        }

        public List<Food> GetList()
        {
            return _foodDal.GetList();
        }

        public void Update(Food t)
        {
            _foodDal.Update(t);
        }
    }
}

