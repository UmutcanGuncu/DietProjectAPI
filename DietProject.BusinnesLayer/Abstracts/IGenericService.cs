using System;
namespace DietProject.BusinnesLayer.Abstracts
{
	public interface IGenericService<T> where T : class
	{
		void Add(T t);
		void Update(T t);
		void Delete(T t);
		List<T> GetList();
		T GetById(int id);
	}
}

