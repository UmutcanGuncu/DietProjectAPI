using System;
using DietProject.DataAccessLayer.Abstracts;
using DietProject.DataAccessLayer.Context;

namespace DietProject.DataAccessLayer.Concretes
{
    public class GenericRepository<T> : IGenericDal<T> where T:class
    {
        private readonly DietDbContext _context;

        public GenericRepository(DietDbContext context)
        {
            _context = context;
        }

        public void Add(T t)
        {
            _context.Add(t);
            _context.SaveChanges();
        }

        public void Delete(T t)
        {
            _context.Remove(t);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return _context.Set<T>().ToList();
        }

        public void Update(T t)
        {
            _context.Update(t);
            _context.SaveChanges();

        }
    }
}

