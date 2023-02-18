using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoursesApp.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? ParentId { get; set; }
        public string ParentName { get; set; }

    }
}