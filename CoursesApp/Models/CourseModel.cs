using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoursesApp.Models
{
    public class CourseModel
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; }


    }
}