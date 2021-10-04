using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseApplication.Model;

namespace CourseApplication.Services.Interfaces
{
    public interface IFetchCourseService
    {
        /// <summary>
        /// 取得Course資料
        /// </summary>
        /// <returns></returns>
        IList<Course> FetchCourse();
    }
}
