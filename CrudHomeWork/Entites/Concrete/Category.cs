using System;
using CrudHomeWork.Entites.Abstract;

namespace CrudHomeWork.Entites
{
	public class Category:BaseEntity
	{
		public string Description { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}

