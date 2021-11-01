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
        public event ChosenCourseChangedEventHandler _chosenCourseChanged;
        public delegate void ChosenCourseChangedEventHandler();
        public event ClassCourseChangedEventHandler _classCourseChanged;
        public delegate void ClassCourseChangedEventHandler();
        public const string SPACE = " ";
        public const string COMMA = "、";
        public const string BREAK_LINE = "\n";
        public const string COMPUTER_SCIENCE_THIRD_GRADE_RESOURCE = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2433";
        public const string ELECTRON_ENGINEERING_THIRD_GRADE_RESOURCE = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2423";
        public const string COMPUTER_SCIENCE_THIRD_GRADE_TEXT = "資工三";
        public const string ELECTRON_ENGINEERING_THIRD_GRADE_TEXT = "電子三甲";
        public const string SAME_COURSE_NAME_TEXT = "課程名稱相同 : ";
        public const string SAME_COURSE_ID_TEXT = "課程課號相同 : ";
        public const string SAME_COURSE_TIME_TEXT = "課程衝堂 : ";

        public Curriculum _curriculum
        {
            get; set;
        }

        public BindingList<Course> _chosenCourses
        {
            get;
        }
        List<Class> _class;
        FetchCourseService _fetchCourseService;
        HtmlWeb _webClient;

        public CourseApplicationModel()
        {
            _curriculum = new Curriculum();
            _chosenCourses = new BindingList<Course>();
            _class = new List<Class>();
            _webClient = new HtmlWeb();
            _fetchCourseService = new FetchCourseService(_webClient);
            FetchCourseDatas(COMPUTER_SCIENCE_THIRD_GRADE_RESOURCE, COMPUTER_SCIENCE_THIRD_GRADE_TEXT);
            FetchCourseDatas(ELECTRON_ENGINEERING_THIRD_GRADE_RESOURCE, ELECTRON_ENGINEERING_THIRD_GRADE_TEXT);
        }

        /// <summary>
        /// 取得Course資料
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="departmentName"></param>
        private void FetchCourseDatas(string resource, string departmentName)
        {
            List<Course> courses = _fetchCourseService.FetchCourse(resource);
            Class department = new Class();
            department.ClassName = departmentName;
            department.Courses = courses;
            _class.Add(department);
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
        public Class GetDepartmentByName(string departmentName)
        {
            foreach (Class department in _class)
            {
                if (department.ClassName.Equals(departmentName))
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
        public string AddCourseChosen(List<Course> courses)
        {
            string errorString = "";
            for (int i = 0 ; i < courses.Count() ; i++)
            {
                for (int j = i ; j < courses.Count() ; j++)
                {
                    if (!courses[i].Equals(courses[j]))
                        errorString += CheckIfComplicated(courses[i], courses[j]);
                }
                foreach (Course comparisonCourse in _chosenCourses)
                {
                    errorString += CheckIfComplicated(courses[i], comparisonCourse);
                }
            }
            if (errorString == "")
                foreach (Course course in courses)
                    _chosenCourses.Add(course);
            return errorString;
        }

        /// <summary>
        /// 判斷重複與否
        /// </summary>
        /// <param name="course"></param>
        /// <param name="comparisonCourse"></param>
        /// <returns></returns>
        private string CheckIfComplicated(Course course, Course comparisonCourse)
        {
            string errorString = "";
            errorString += CheckIfCourseNameComplicated(course, comparisonCourse);
            errorString += CheckIfCourseIdComplicated(course, comparisonCourse);
            errorString += CheckIfCourseTimeComplicated(course, comparisonCourse);
            return errorString;
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
            if (_chosenCourseChanged != null)
                _chosenCourseChanged();
        }

        /// <summary>
        /// Update/Render Properties when ChosenCourseChanged
        /// </summary>
        /// <param name="propertyName"></param>
        private void NotifyClassCourseChanged()
        {
            if (_classCourseChanged != null)
                _classCourseChanged();
        }

        /// <summary>
        /// 判別課程名稱
        /// </summary>
        /// <param name="targetCourse"></param>
        /// <param name="comparisonCourse"></param>
        /// <returns></returns>
        private string CheckIfCourseNameComplicated(Course targetCourse, Course comparisonCourse)
        {
            string errorMessage = "";
            if (GetCourseName(comparisonCourse).Equals(GetCourseName(targetCourse)))
                errorMessage += SAME_COURSE_NAME_TEXT + GetCourseId(targetCourse) + SPACE + GetCourseName(targetCourse) + COMMA + GetCourseId(comparisonCourse) + SPACE + GetCourseName(comparisonCourse) + BREAK_LINE;
            return errorMessage;
        }

        /// <summary>
        /// 取得課程ID
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        private string GetCourseId(Course course)
        {
            return course.CourseId;
        }

        /// <summary>
        /// 取得課程名稱
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        private string GetCourseName(Course course)
        {
            return course.CourseName;
        }

        /// <summary>
        /// 判別課程Id
        /// </summary>
        /// <param name="targetCourse"></param>
        /// <param name="comparisonCourse"></param>
        /// <returns></returns>
        private string CheckIfCourseIdComplicated(Course targetCourse, Course comparisonCourse)
        {
            string errorMessage = "";
            if (GetCourseId(comparisonCourse).Equals(GetCourseId(targetCourse)))
                errorMessage += SAME_COURSE_ID_TEXT + GetCourseId(targetCourse) + SPACE + GetCourseName(targetCourse) + COMMA + GetCourseId(comparisonCourse) + SPACE + GetCourseName(comparisonCourse) + BREAK_LINE;
            return errorMessage;
        }

        /// <summary>
        /// 判別衝堂
        /// </summary>
        /// <param name="targetCourse"></param>
        /// <param name="comparisonCourse"></param>
        /// <returns></returns>
        private string CheckIfCourseTimeComplicated(Course targetCourse, Course comparisonCourse)
        {
            string errorMessage = "";
            if (CheckTimeDuplicate(targetCourse.Sunday, comparisonCourse.Sunday)
                || CheckTimeDuplicate(targetCourse.Monday, comparisonCourse.Monday) 
                || CheckTimeDuplicate(targetCourse.Tuesday, comparisonCourse.Tuesday)
                || CheckTimeDuplicate(targetCourse.Wednesday, comparisonCourse.Wednesday)
                || CheckTimeDuplicate(targetCourse.Thursday, comparisonCourse.Thursday)
                || CheckTimeDuplicate(targetCourse.Friday, comparisonCourse.Friday)
                || CheckTimeDuplicate(targetCourse.Saturday, comparisonCourse.Saturday))
                errorMessage += SAME_COURSE_TIME_TEXT + GetCourseId(targetCourse) + SPACE + GetCourseName(targetCourse) + COMMA + GetCourseId(comparisonCourse) + SPACE + GetCourseName(comparisonCourse) + BREAK_LINE;
            return errorMessage;
        }

        /// <summary>
        /// 衝堂
        /// </summary>
        /// <param name="courseTime"></param>
        /// <param name="comparisonCourseTime"></param>
        /// <returns></returns>
        private bool CheckTimeDuplicate(string courseTime, string comparisonCourseTime)
        {
            string[] courseTimeArray = courseTime.Split();
            foreach (string time in courseTimeArray)
            {
                if (comparisonCourseTime.IndexOf(time) >= 0 && time != "")
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 將Course移動到Class
        /// </summary>
        /// <param name="className"></param>
        /// <param name="course"></param>
        public void MoveCourseToClass(string className, Course beforeCourse, Course afterCourse)
        {
            foreach (Class @class in _class)
            {
                if (beforeCourse != null)
                    @class.RemoveCourse(beforeCourse);
                if (@class.ClassName.Equals(className))
                    @class.AddCourse(afterCourse);
            }
            NotifyClassCourseChanged();
        }

        /// <summary>
        /// 取得當前Course的ClassName
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public string GetClassByCourse(Course course)
        {
            foreach (Class @class in _class)
                foreach (Course findCourse in @class.Courses)
                    if (findCourse.Equals(course))
                        return @class.ClassName;
            return null;
        }
    }
}
