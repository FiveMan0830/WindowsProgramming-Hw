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
        public event CourseDtosChangedEventHandler CourseDtosChanged;
        public delegate void CourseDtosChangedEventHandler();
        public CourseApplicationModel _courseApplicationModel;
        public Dictionary<string ,List<CourseSelectingDto>> _courses;
        public bool IsNotCourseSelectionResultFormOpened
        {
            get; set;
        }

        public bool IsAnyCourseSelected
        {
            get
            {
                foreach(var pair in _courses)
                {
                    foreach(var dto in pair.Value)
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
            _courseApplicationModel.ChosenCourseChanged += InitializeCourse;
            _courses = new Dictionary<string, List<CourseSelectingDto>>();
            InitializeCourse();
        }

        /// <summary>
        /// 初始化Course
        /// </summary>
        public void InitializeCourse()
        {
            _courses.Clear();
            _courses.Add("資工三", GetCoursesByDepartment("資工三"));
            _courses.Add("電子三甲", GetCoursesByDepartment("電子三甲"));
            NotifyOnCourseDtosChanged();
        }

        /// <summary>
        /// 送出選擇
        /// </summary>
        public void NoticeOnSelectCourse()
        {
            string errorMessage = null;
            foreach (var pair in _courses)
                foreach (var dto in pair.Value)
                    if (dto.IsCourseSelected == true)
                        errorMessage = _courseApplicationModel.AddCourseChosen(dto.Course);
            //if(errorMessage != null)

        }

        /// <summary>
        /// 課程點選後觸發
        /// </summary>
        public void NoticeOnCheckBoxClicked(int index, string departmentName)
        {
            foreach(var pair in _courses)
            {
                if(pair.Key.Equals(departmentName))
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
            foreach(Course course in _courseApplicationModel.GetDepartmentByName(departmentName).Courses)
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
                for(int j = 0 ; j < result.Count ; j++)
                {
                    if(result[j].Course.Equals(i))
                    {
                        result.RemoveAt(j);
                        break;
                    }
                }
            return result;
        }


        private void NotifyOnCourseDtosChanged()
        {
            if (CourseDtosChanged != null)
                CourseDtosChanged();
        }
    }
}
