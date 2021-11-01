using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel;
using CourseApplication.Dto;
using CourseApplication.Model;

namespace CourseApplication.PresentationModels.CourseManagement
{
    public class CourseManagementPresentationModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event TimeGridChangedEventHandler _timeGridChanged;
        public delegate void TimeGridChangedEventHandler();
        const string ADD_COURSE_TEXT = "新增課程";
        const string EDIT_COURSE_TEXT = "編輯課程";
        const string COMPUTER_SCIENCE_TEXT = "資工三";
        const string SUNDAY_TEXT = "Sunday";
        const string MONDAY_TEXT = "Monday";
        const string TUESDAY_TEXT = "Tuesday";
        const string WEDNESDAY_TEXT = "Wednesday";
        const string THURSDAY_TEXT = "Thursday";
        const string FRIDAY_TEXT = "Friday";
        const string SATURDAY_TEXT = "Saturday";
        const string SPACE_TEXT = " ";
        const string EMPTY_TEXT = "";
        const char SPACE_CHAR = ' ';
        const int CLASS_PERIODS = 9;
        bool _isAddCourseState;
        int _currentIndex;
        string _class;
        public Course _toBeChangedCourse
        {
            get;
            protected set;
        }
        public Course _currentCourse
        {
            get;
            protected set;
        }
        public CourseApplicationModel _courseApplicationModel
        {
            get;
            protected set;
        }
        public List<string> _courseNameList
        {
            get;
            protected set;
        }
        public List<CourseTimeDTO> _courseTimeGrid
        {
            get;
            protected set;
        }

        public string GetCourseState
        {
            get
            {
                if (_isAddCourseState)
                    return ADD_COURSE_TEXT;
                else
                    return EDIT_COURSE_TEXT;
            }
        }

        public string GetClassName
        {
            get
            {
                return _class;
            }
        }

        public bool IsDataChanged
        {
            get
            {
                if (_toBeChangedCourse.CourseId != _currentCourse.CourseId
                    || _toBeChangedCourse.CourseName != _currentCourse.CourseName
                    || _toBeChangedCourse.Credit != _currentCourse.Credit
                    || _toBeChangedCourse.Stage != _currentCourse.Stage
                    || _toBeChangedCourse.Teacher != _currentCourse.Teacher
                    || _toBeChangedCourse.TeachingAssistant != _currentCourse.TeachingAssistant
                    || _toBeChangedCourse.Language != _currentCourse.Language
                    || _toBeChangedCourse.Hour != _currentCourse.Hour
                    || _toBeChangedCourse.Necessity != _currentCourse.Necessity
                    || _toBeChangedCourse.Note != _currentCourse.Note)
                    return true;
                return false;
            }
        }

        public bool IsRequiredNotEmpty
        {
            get
            {
                if (_currentCourse.CourseId != EMPTY_TEXT
                    && _currentCourse.CourseName != EMPTY_TEXT
                    && _currentCourse.Credit != EMPTY_TEXT
                    && _currentCourse.Stage != EMPTY_TEXT
                    && _currentCourse.Teacher != EMPTY_TEXT
                    && _currentCourse.Hour != EMPTY_TEXT
                    && _currentCourse.Necessity != EMPTY_TEXT)
                    return true;
                return false;
            }
        }

        public bool IsHourMatchTime
        {
            get
            {
                int i = 0;
                if (_currentCourse.Hour == "")
                    return false;
                foreach (var dto in _courseTimeGrid)
                {
                    i += dto.GetHour();
                }
                if (Convert.ToInt32(_currentCourse.Hour) == i)
                    return true;
                return false;
            }
        }

        public bool IsSaveEnabled
        {
            get
            {
                bool enable = IsHourMatchTime && IsRequiredNotEmpty && IsDataChanged;
                return enable;
            }
        }

        public CourseManagementPresentationModel(CourseApplicationModel courseApplicationModel)
        {
            _courseApplicationModel = courseApplicationModel;
            _isAddCourseState = false;
            _class = COMPUTER_SCIENCE_TEXT;
            InitializeNameList();
            InitializeTimeGrid();
        }

        /// <summary>
        /// 設置轉移課程
        /// </summary>
        /// <param name="className"></param>
        public void SetClass(string className)
        {
            _class = className;
        }

        /// <summary>
        /// InitializeNameListForUI
        /// </summary>
        public void InitializeNameList()
        {
            _courseNameList = new List<string>();
            foreach (var course in _courseApplicationModel._curriculum._courses)
                _courseNameList.Add(course.CourseName);
        }

        /// <summary>
        /// 設定新增課程
        /// </summary>
        public void HandleAddNewCourse()
        {
            _isAddCourseState = true;
            _toBeChangedCourse = new Course();
            _currentCourse = new Course();
        }

        /// <summary>
        /// 設定選取課程
        /// </summary>
        /// <param name="index"></param>
        public void HandleChangeSelectedIndex(int index)
        {
            _toBeChangedCourse = _courseApplicationModel._curriculum._courses[index];
            _isAddCourseState = false;
            _currentIndex = index;
            _currentCourse = _toBeChangedCourse.GetClone();
            _class = _courseApplicationModel.GetClassByCourse(_toBeChangedCourse);
            GetCourseTimes();
        }

        /// <summary>
        /// 選取時間
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="colIndex"></param>
        public void NoticeOnCheckBoxClicked()
        {
            NotifyOnTimeGridChanged();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public void InitializeTimeGrid()
        {
            if (_courseTimeGrid != null)
                _courseTimeGrid.Clear();
            _courseTimeGrid = new List<CourseTimeDTO>();
            for (int i = 1; i < CLASS_PERIODS; i++)
                _courseTimeGrid.Add(new CourseTimeDTO(i));
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public void GetCourseTimes()
        {
            GetCourseTime(SUNDAY_TEXT);
            GetCourseTime(MONDAY_TEXT);
            GetCourseTime(TUESDAY_TEXT);
            GetCourseTime(WEDNESDAY_TEXT);
            GetCourseTime(THURSDAY_TEXT);
            GetCourseTime(FRIDAY_TEXT);
            GetCourseTime(SATURDAY_TEXT);
        }

        /// <summary>
        /// 更改字串
        /// </summary>
        /// <param name="proptertyName"></param>
        /// <param name="text"></param>
        public void HandleTextChanged(string attributeName, string text)
        {
            PropertyInfo property = _currentCourse.GetType().GetProperty(attributeName);
            property.SetValue(_currentCourse, text);
            Notify(nameof(IsSaveEnabled));
        }

        /// <summary>
        /// 按下儲存按鈕
        /// </summary>
        public void HandleSaveButtonClick()
        {
            if (_isAddCourseState)
                SaveNewCourse();
            else
                UpdateCourse(_currentIndex);
            _courseNameList.Clear();
            InitializeNameList();
        }

        /// <summary>
        /// Update/Render Properties
        /// </summary>
        /// <param name="propertyName"></param>
        public void Notify(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// 新增課程
        /// </summary>
        private void SaveNewCourse()
        {
            _courseApplicationModel._curriculum._courses.Add(_currentCourse);
            _courseApplicationModel.MoveCourseToClass(_class, _toBeChangedCourse, _currentCourse);
        }

        /// <summary>
        /// 更新課程
        /// </summary>
        /// <param name="index"></param>
        private void UpdateCourse(int index)
        {
            _courseApplicationModel._curriculum._courses[index] = _currentCourse;
            _courseApplicationModel.MoveCourseToClass(_class, _toBeChangedCourse, _currentCourse);
        }

        /// <summary>
        /// 初始化時間
        /// </summary>
        private void GetCourseTime(string dayOfTheWeek)
        {
            PropertyInfo property = _toBeChangedCourse.GetType().GetProperty(dayOfTheWeek);
            string[] classTime = ((string)property.GetValue(_toBeChangedCourse)).Split(SPACE_CHAR);
            for (int i = 0; i < classTime.Length; i++)
                for (int j = 0; j < CLASS_PERIODS - 1; j++)
                {
                    PropertyInfo propertyInfo = _courseTimeGrid[j].GetType().GetProperty(dayOfTheWeek);
                    if (classTime[i].Equals(Convert.ToString(j + 1)))
                        propertyInfo.SetValue(_courseTimeGrid[j], true);
                    else
                        propertyInfo.SetValue(_courseTimeGrid[j], false);
                }
            NotifyOnTimeGridChanged();
        }

        /// <summary>
        /// 課程變更通知
        /// </summary>
        private void NotifyOnTimeGridChanged()
        {
            if (_timeGridChanged != null)
                _timeGridChanged();
            Notify(nameof(IsSaveEnabled));
        }
    }
}
