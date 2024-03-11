using System;
using CrudHomeWork.Entites.Abstract;

namespace CrudHomeWork.Entites
{
	public class Course:BaseEntity
	{
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public double Price { get; set; }
    }
}

