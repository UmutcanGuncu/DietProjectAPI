using System;
namespace DietProject.DataAccessLayer.Abstracts
{
	public interface IGenericDal<T> where T:class
	{
		List<T> GetList();
		void Add(T t);
		void Delete(T t);
		void Update(T t);
		T GetById(int id);

	}
}

