using CoursesApp.Models;
using CoursesApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoursesApp.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryService categoryService;

        public CategoryController()
        {
            categoryService = new CategoryService();
        }
        // GET: Admin/Category
        public ActionResult Index()
        {
            var category =  categoryService.ReadAll();

            var categoriesList = new List<CategoryModel>();
            foreach (var item in categoriesList)
            {
                categoriesList.Add(new CategoryModel
                {
                    Id= item.Id,
                    Name= item.Name,    
                    ParentId= item.ParentId,    
                    ParentName= item.Category2?.Name,
                });
            }
            return View(categoriesList);
        }
    }
}