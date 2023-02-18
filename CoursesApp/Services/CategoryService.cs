using CoursesApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoursesApp.Services
{
    public interface ICategoryService
    {
        List<Category> ReadAll();
    }
    public class CategoryService : ICategoryService
    {
        private readonly Course_DBEntities db;
        public CategoryService()
        {
            db= new Course_DBEntities();

        }
        public List<Category> ReadAll()
        {
            return db.Categories.ToList();
        }

       
    }
}