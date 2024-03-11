using System;
namespace CrudHomeWork.Business.Abstract
{
	public interface IGenericService<T> where T: class
	{
		void Add(T entity);
		void Delete(T entity);
		void Update(T entity);
		List<T> GetAll();
	}
}

