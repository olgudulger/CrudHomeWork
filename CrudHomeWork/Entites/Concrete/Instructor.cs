using System;
using CrudHomeWork.Entites.Abstract;

namespace CrudHomeWork.Entites
{
	public class Instructor:BaseEntity
	{
        public string LastName { get; set; }
        public byte[] Image { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}

