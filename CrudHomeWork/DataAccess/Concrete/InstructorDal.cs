using System;
using CrudHomeWork.DataAccess.Abstract;
using CrudHomeWork.Entites;

namespace CrudHomeWork.DataAccess.Concrete
{
	public class InstructorDal:IGenericDal<Instructor>
	{
		public InstructorDal()
		{
		}

        public void Add(Instructor entity)
        {
            Console.WriteLine("Instructor Eklendi");
        }

        public void Delete(Instructor entity)
        {
            Console.WriteLine("Instructor Silindi");
        }

        public List<Instructor> GetAll()
        {
            List<Instructor> Instructors = new List<Instructor>();
            Instructors.Add(new Instructor());
            return Instructors;
        }

        public void Update(Instructor entity)
        {
            Console.WriteLine("Instructor Güncellendi");
        }
    }
}

