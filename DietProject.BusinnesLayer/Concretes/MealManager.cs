using System;
using DietProject.BusinnesLayer.Abstracts;
using DietProject.DataAccessLayer.Abstracts;
using DietProject.EntityLayer.Entities;

namespace DietProject.BusinnesLayer.Concretes
{
    public class MealManager : IMealService
    {
        private readonly IMealDal _mealDal;

        public MealManager(IMealDal mealDal)
        {
            _mealDal = mealDal;
        }

        public void Add(Meal t)
        {
            _mealDal.Add(t);
        }

        public void Delete(Meal t)
        {
            _mealDal.Delete(t);
        }

        public Meal GetById(int id)
        {
            return _mealDal.GetById(id);
        }

        public List<Meal> GetList()
        {
            return _mealDal.GetList();
        }

        public void Update(Meal t)
        {
            _mealDal.Update(t);
        }
    }
}

