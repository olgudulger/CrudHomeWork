using System;
using CrudHomeWork.DataAccess.Abstract;
using CrudHomeWork.Entites;

namespace CrudHomeWork.DataAccess.Concrete
{
	public class CategoryDal:IGenericDal<Category>
	{
		public CategoryDal()
		{
            
        }

        public void Add(Category entity)
        {
            Console.WriteLine("Category Eklendi");
        }

        public void Delete(Category entity)
        {
            Console.WriteLine("Category Silindi");
        }

        public List<Category> GetAll()
        {
            List<Category> Categories = new List<Category>();
            Categories.Add(new Category());
            return Categories;
        }

        public void Update(Category entity)
        {
            Console.WriteLine("Category Güncellendi");
        }
    }
}

