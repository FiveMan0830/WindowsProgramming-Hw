using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CourseApplication.Services.Interfaces;
using CourseApplication.Model.Dto;

namespace CourseApplication
{
    public class SelectCoursePresentationModel
    {
        private readonly IFetchCourseService _fetchCourseService;
        private IList<CourseInfoDto> _courses;
        public SelectCoursePresentationModel(IFetchCourseService fetchCourseService)
        {
            _fetchCourseService = fetchCourseService;
        }

        public IList<CourseInfoDto> Courses
        {
            get
            {
                return _courses;
            }
        }
        /// <summary>
        /// 讀取課程
        /// </summary>
        public void LoadCourses()
        {
            var courses = _fetchCourseService.FetchCourse();
            _courses = courses.Select(course => new CourseInfoDto(course)).ToList();
        }
    }
}
