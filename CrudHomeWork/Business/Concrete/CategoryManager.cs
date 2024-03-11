using System;
using CrudHomeWork.Business.Abstract;
using CrudHomeWork.DataAccess.Abstract;
using CrudHomeWork.Entites;

namespace CrudHomeWork.Business.Concrete
{
	public class CategoryManager : IgenericService<Category>
	{
        private readonly IGenericDal<Category> _genericDal;


        public CategoryManager(IGenericDal<Category> genericDal)
        {
            _genericDal = genericDal;
        }

        public void Add(Category entity)
        {
            _genericDal.Add(entity);
        }

        public void Delete(Category entity)
        {
            _genericDal.Delete(entity);
        }

        public List<Category> GetAll()
        {
            return _genericDal.GetAll();
        }

        public void Update(Category entity)
        {
            _genericDal.Update(entity);
        }
    }
}

