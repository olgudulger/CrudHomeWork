using System;
using CrudHomeWork.DataAccess.Abstract;
using CrudHomeWork.Entites;

namespace CrudHomeWork.DataAccess.Concrete
{
	public class CourseDal : IGenericDal<Course>
    {
        public CourseDal() 
		{
		}

        public void Add(Course entity)
        {
            Console.WriteLine("Course Eklendi");
        }

        public void Delete(Course entity)
        {
            Console.WriteLine("Course Silindi");
        }

        public List<Course> GetAll()
        {
            List<Course> Courses = new List<Course>();
            Courses.Add(new Course());
            return Courses;
        }

        public void Update(Course entity)
        {
            Console.WriteLine("Course Güncellendi");
        }
    }
}

