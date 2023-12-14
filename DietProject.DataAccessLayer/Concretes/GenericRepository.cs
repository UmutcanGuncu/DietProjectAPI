using System;
using DietProject.DataAccessLayer.Abstracts;
using DietProject.DataAccessLayer.Context;

namespace DietProject.DataAccessLayer.Concretes
{
    public class GenericRepository<T> : IGenericDal<T> where T:class
    {
        private readonly DietDbContext context;

        public GenericRepository(DietDbContext context)
        {
            this.context = context;
        }

        public void Add(T t)
        {
            context.Add(t);
            context.SaveChanges();
        }

        public void Delete(T t)
        {
            context.Remove(t);
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return context.Set<T>().ToList();
        }

        public void Update(T t)
        {
            context.Update(t);
            context.SaveChanges();

        }
    }
}

