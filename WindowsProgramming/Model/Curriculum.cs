using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseApplication.Services;

namespace CourseApplication.Model
{
    public class Curriculum
    {
        public List<Course> _courses
        {
            get; set;
        }

        public Curriculum()
        {
            _courses = new List<Course>();
        }
    }
}
