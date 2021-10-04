using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CourseApplication.Services.Interfaces;
using CourseApplication.Model.Dto;
using System.ComponentModel;

namespace CourseApplication
{
    public class SelectCoursePresentationModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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

        public bool IsAnyCourseSelected
        {
            get
            {
                return _courses != null && _courses.Any(data => data.IsCourseSelected);
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

        /// <summary>
        /// 課程點選後觸發
        /// </summary>
        public void NoticeOnCheckBoxClicked()
        {
            Notify(nameof(IsAnyCourseSelected));
        }

        /// <summary>
        /// Update/Render Properties
        /// </summary>
        /// <param name="propertyName"></param>
        private void Notify(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
