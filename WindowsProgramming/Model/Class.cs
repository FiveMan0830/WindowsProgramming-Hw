using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.Model
{
    public class Class
    {
        public string ClassName
        {
            get; set;
        }

        public List<Course> Courses
        {
            get; set;
        }

        /// <summary>
        /// 新增課程
        /// </summary>
        /// <param name="course"></param>
        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        /// <summary>
        /// 移除課程
        /// </summary>
        /// <param name="course"></param>
        public void RemoveCourse(Course course)
        {
            Courses.Remove(course);
        }
    }
}
