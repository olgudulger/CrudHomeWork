using System;
using CrudHomeWork.Business.Abstract;
using CrudHomeWork.DataAccess.Abstract;
using CrudHomeWork.Entites;

namespace CrudHomeWork.Business.Concrete
{
    public class InstructorManager : IGenericService<Instructor>
    {
        private readonly IGenericDal<Instructor> _genericDal;

        public InstructorManager(IGenericDal<Instructor> genericDal)
        {
            _genericDal = genericDal;
        }
        public void Add(Instructor entity)
        {
            _genericDal.Add(entity);
        }

        public void Delete(Instructor entity)
        {
            _genericDal?.Delete(entity);
        }

        public List<Instructor> GetAll()
        {
            return _genericDal.GetAll();
        }

        public void Update(Instructor entity)
        {
            _genericDal.Update(entity);
        }
    }
}

