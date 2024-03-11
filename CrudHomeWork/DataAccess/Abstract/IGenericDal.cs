using System;
namespace CrudHomeWork.DataAccess.Abstract
{
	public interface IGenericDal<T> where T : class
    {
        List<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}

