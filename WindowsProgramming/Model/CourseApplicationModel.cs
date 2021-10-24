using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CourseApplication.Services;


namespace CourseApplication.Model
{
    public class CourseApplicationModel
    {
        public event ChosenCourseChangedEventHandler ChosenCourseChanged;
        public delegate void ChosenCourseChangedEventHandler();

        public Curriculum _curriculum
        {
            get; set;
        }

        public BindingList<Course> _chosenCourses
        {
            get;
        }
        public List<Department> _departments;
        FetchCourseService _fetchCourseService;
        HtmlWeb _webClient;

        public CourseApplicationModel()
        {
            _curriculum = new Curriculum();
            _chosenCourses = new BindingList<Course>();
            _departments = new List<Department>();
            string csie3WebResource = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2433";
            string ee3AWebResource = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2423";
            _webClient = new HtmlWeb();
            _fetchCourseService = new FetchCourseService(_webClient);
            FetchCourseDatas(csie3WebResource, "資工三");
            FetchCourseDatas(ee3AWebResource, "電子三甲");
        }

        /// <summary>
        /// 取得Course資料
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="departmentName"></param>
        private void FetchCourseDatas(string resource, string departmentName)
        {
            List<Course> courses = _fetchCourseService.FetchCourse(resource);
            Department department = new Department();
            department.DepartmentName = departmentName;
            department.Courses = courses;
            _departments.Add(department);
            foreach (var course in courses)
            {
                _curriculum._courses.Add(course);
            }
        }

        /// <summary>
        /// 取得Department
        /// </summary>
        /// <param name="departmentName"></param>
        /// <returns></returns>
        public Department GetDepartmentByName(string departmentName)
        {
            foreach (Department department in _departments)
            {
                if (department.DepartmentName.Equals(departmentName))
                {
                    return department;
                }
            }
            return null;
        }

        /// <summary>
        /// 加入至以選列表/加選課程
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public string AddCourseChosen(Course course)
        {
            string errorString = null;
            foreach(Course comparisonCourse in _chosenCourses)
            {
                errorString = CheckIfCourseNameComplicated(course, comparisonCourse);
                if (errorString != null)
                    return errorString;
            }
            _chosenCourses.Add(course);
            return null;
        }

        /// <summary>
        /// 退選課程
        /// </summary>
        /// <param name="index"></param>
        public void DropCourseChosen(int index)
        {
            if (_chosenCourses.Count > index)
                _chosenCourses.RemoveAt(index);
            NotifyChosenCourseChanged();
        }

        /// <summary>
        /// Update/Render Properties when ChosenCourseChanged
        /// </summary>
        /// <param name="propertyName"></param>
        private void NotifyChosenCourseChanged()
        {
            if (ChosenCourseChanged != null)
                ChosenCourseChanged();
        }

        /// <summary>
        /// 判別課程名稱
        /// </summary>
        /// <param name="targetCourse"></param>
        /// <param name="comparisonCourse"></param>
        /// <returns></returns>
        private string CheckIfCourseNameComplicated(Course targetCourse, Course comparisonCourse)
        {
            string errorMessage = "課程名稱相同 : ";
            if (comparisonCourse.CourseName.Equals(targetCourse.CourseName))
            {
                errorMessage = errorMessage + targetCourse.CourseId + " " + targetCourse.CourseName + "、" + targetCourse.CourseId + " " + targetCourse.CourseName;
                return errorMessage;
            }
            return null;
        }

        /// <summary>
        /// 課程衝堂
        /// </summary>
        /// <param name="targetCourse"></param>
        /// <param name="comparisonCourse"></param>
        /// <returns></returns>
        private string CheckIfCourseTimeComplicated(Course targetCourse, Course comparisonCourse)
        {
            string errorMessage = "課程衝堂 : ";

            
            return null;
        }
    }
}
