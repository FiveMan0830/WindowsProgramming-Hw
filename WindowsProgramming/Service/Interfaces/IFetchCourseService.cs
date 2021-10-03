using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseApplication.Model.Course;

namespace CourseApplication.Service.Interfaces
{
    interface IFetchCourseService
    {
        /// <summary>
        /// 取得Course資料
        /// </summary>
        /// <param name="resourceRoute"></param>
        /// <returns></returns>
        List<Course> FetchCourse(string resourceRoute);
    }
}
