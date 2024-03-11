using System;
using CrudHomeWork.Business.Abstract;
using CrudHomeWork.DataAccess.Abstract;
using CrudHomeWork.Entites;

namespace CrudHomeWork.Business.Concrete
{
	public class CourseManager : IGenericService<Course>
    {
        private readonly IGenericDal<Course> _genericDal;

        public CourseManager(IGenericDal<Course> genericDal)
        {
            _genericDal = genericDal;
        }

        public void Add(Course entity)
        {
            _genericDal.Add(entity);
        }

        public void Delete(Course entity)
        {
            _genericDal.Delete(entity);
        }
        public List<Course> GetAll()
        {
            return _genericDal.GetAll();
        }

        public void Update(Course entity)
        {
            _genericDal.Update(entity);
        }
    }
}

