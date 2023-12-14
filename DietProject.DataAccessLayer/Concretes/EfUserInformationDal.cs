using System;
using DietProject.DataAccessLayer.Abstracts;
using DietProject.DataAccessLayer.Context;
using DietProject.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DietProject.DataAccessLayer.Concretes
{
    public class EfUserInformationDal : IUserInformationDal
    {
        private readonly DietDbContext context;

        public EfUserInformationDal(DietDbContext context)
        {
            this.context = context;
        }

        public void Add(UserInformation t)
        {
            context.Add(t);
            context.SaveChanges();
        }

        public void AddOrUpdate(UserInformation userInformation)
        {
            var value = context.userInformation.AsNoTracking().Where(x => x.AppUserId == userInformation.AppUserId).FirstOrDefault();
            //As no tracking ekledim. Çünkü aynı idli satırı iki kere takip ediyordu bu durumda da çakışma meydana geliyor ve ekşemiyor
            
            if(value == null)
            {
                context.Add(userInformation);
                context.SaveChanges();
            }
            else
            {
                UserInformation user = new UserInformation()
                {
                    Id = value.Id,
                    Age = userInformation.Age,
                    Length = userInformation.Length,
                    Weight = userInformation.Weight,
                    TargetWeight = userInformation.TargetWeight,
                    DailyCalorieRequirement = userInformation.DailyCalorieRequirement,
                    DailyCarbonhydrateRequirement = userInformation.DailyCarbonhydrateRequirement,
                    DailyFatRequirement = userInformation.DailyFatRequirement,
                    DailyProteinRequirement = userInformation.DailyProteinRequirement,
                    AppUserId = userInformation.AppUserId,
                    Gender = userInformation.Gender

                };
                context.Update(user);
                context.SaveChanges();
            }
           
        }

        public void Delete(UserInformation t)
        {
            context.Remove(t);
            context.SaveChanges();
        }

        public UserInformation GetById(int id)
        {
            return context.Set<UserInformation>().Find(id);
        }

        public List<UserInformation> GetList()
        {
            return context.Set<UserInformation>().ToList();
        }

        public void Update(UserInformation t)
        {
            context.Update(t);
            context.SaveChanges();
        }
    }
}

