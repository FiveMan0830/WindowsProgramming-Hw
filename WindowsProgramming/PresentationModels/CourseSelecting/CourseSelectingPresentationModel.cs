using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using CourseApplication.Dto;
using CourseApplication.Model;

namespace CourseApplication.PresentationModels.CourseSelecting
{
    public class CourseSelectingPresentationModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event CourseDtosChangedEventHandler _courseDtosChanged;
        public delegate void CourseDtosChangedEventHandler();
        public const string COMPUTER_SCIENCE_THIRD_GRADE_TEXT = "資工三";
        public const string ELECTRON_ENGINEERING_THIRD_GRADE_TEXT = "電子三甲";
        public CourseApplicationModel _courseApplicationModel
        {
            get;
        }
        public Dictionary<string ,List<CourseSelectingDto>> _courses
        {
            get;
        }
        public bool IsNotCourseSelectionResultFormOpened
        {
            get; set;
        }
        public bool IsAnyCourseSelected
        {
            get
            {
                foreach (var pair in _courses)
                {
                    foreach (var dto in pair.Value)
                    {
                        if (dto.IsCourseSelected == true)
                            return true;
                    }
                }
                return false;
            }
        }

        public CourseSelectingPresentationModel(CourseApplicationModel model)
        {
            IsNotCourseSelectionResultFormOpened = true;
            _courseApplicationModel = model;
            _courseApplicationModel._chosenCourseChanged += InitializeCourse;
            _courseApplicationModel._classCourseChanged += InitializeCourse;
            _courses = new Dictionary<string, List<CourseSelectingDto>>();
            InitializeCourse();
        }

        /// <summary>
        /// 初始化Course
        /// </summary>
        public void InitializeCourse()
        {
            _courses.Clear();
            _courses.Add(COMPUTER_SCIENCE_THIRD_GRADE_TEXT, GetCoursesByDepartment(COMPUTER_SCIENCE_THIRD_GRADE_TEXT));
            _courses.Add(ELECTRON_ENGINEERING_THIRD_GRADE_TEXT, GetCoursesByDepartment(ELECTRON_ENGINEERING_THIRD_GRADE_TEXT));
            NotifyOnCourseDtosChanged();
        }

        /// <summary>
        /// 送出選擇
        /// </summary>
        public string NoticeOnSelectCourse()
        {
            List<Course> selectedCourses = new List<Course>();
            foreach (var pair in _courses)
                foreach (var dto in pair.Value)
                    if (GetIsCourseSelected(dto) == true)
                        selectedCourses.Add(GetCourseByDto(dto));
            return _courseApplicationModel.AddCourseChosen(selectedCourses);
        }

        /// <summary>
        /// 取得打勾與否
        /// </summary>
        /// <param name="courseSelectingDto"></param>
        /// <returns></returns>
        private bool GetIsCourseSelected(CourseSelectingDto courseSelectingDto)
        {
            return courseSelectingDto.IsCourseSelected;
        }

        /// <summary>
        /// 取得Dto的課程
        /// </summary>
        /// <param name="courseSelectingDto"></param>
        /// <returns></returns>
        private Course GetCourseByDto(CourseSelectingDto courseSelectingDto)
        {
            return courseSelectingDto.Course;
        }

        /// <summary>
        /// 課程點選後觸發
        /// </summary>
        public void NoticeOnCheckBoxClicked(int index, string departmentName)
        {
            foreach (var pair in _courses)
            {
                if (pair.Key.Equals(departmentName))
                {
                    (pair.Value)[index].IsCourseSelected = !(pair.Value)[index].IsCourseSelected;
                }
            }
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

        /// <summary>
        /// 取得某個Department的Course
        /// </summary>
        /// <param name="departmentName"></param>
        /// <returns></returns>
        public List<CourseSelectingDto> GetCoursesByDepartment(string departmentName)
        {
            List<CourseSelectingDto> courses = new List<CourseSelectingDto>();
            foreach (Course course in _courseApplicationModel.GetDepartmentByName(departmentName).Courses)
            {
                courses.Add(new CourseSelectingDto(course));
            }
            return RemoveChosenClass(courses);
        }

        /// <summary>
        /// 移除以選的課
        /// </summary>
        /// <param name="courses"></param>
        /// <returns></returns>
        private List<CourseSelectingDto> RemoveChosenClass(List<CourseSelectingDto> courses)
        {
            IList<Course> chosenCourses = _courseApplicationModel._chosenCourses;
            List<CourseSelectingDto> result = courses;
            foreach (var i in chosenCourses)
                for (int j = 0 ; j < result.Count ; j++)
                {
                    if (result[j].Course.Equals(i))
                    {
                        result.RemoveAt(j);
                        break;
                    }
                }
            return result;
        }

        /// <summary>
        /// 課程變更通知
        /// </summary>
        private void NotifyOnCourseDtosChanged()
        {
            if (_courseDtosChanged != null)
                _courseDtosChanged();
        }
    }
}
