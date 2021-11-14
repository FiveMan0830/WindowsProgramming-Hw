using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.Dto
{
    static class CourseApplicationConstants
    {
        // Commons
        public const string SPACE = " ";
        public const string COMMA = "、";
        public const string BREAK_LINE = "\n";
        public const string EMPTY = "";
        public const char SPACE_CHAR = ' ';

        // Integers
        public const int SUNDAY_INDEX = 7;
        public const int MONDAY_INDEX = 8;
        public const int TUESDAY_INDEX = 9;
        public const int WEDNESDAY_INDEX = 10;
        public const int THURSDAY_INDEX = 11;
        public const int FRIDAY_INDEX = 12;
        public const int SATURDAY_INDEX = 13;

        public const int CLASS_PERIODS = 9;

        // Resources
        public const string COMPUTER_SCIENCE_THIRD_GRADE_RESOURCE = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2433";
        public const string ELECTRON_ENGINEERING_THIRD_GRADE_RESOURCE = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2423";

        // Text
        public const string COMPUTER_SCIENCE_THIRD_GRADE_TEXT = "資工三";
        public const string ELECTRON_ENGINEERING_THIRD_GRADE_TEXT = "電子三甲";
        public const string SAME_COURSE_NAME_TEXT = "課程名稱相同 : ";
        public const string SAME_COURSE_ID_TEXT = "課程課號相同 : ";
        public const string SAME_COURSE_TIME_TEXT = "課程衝堂 : ";
        public const string ADD_COURSE_TEXT = "新增課程";
        public const string EDIT_COURSE_TEXT = "編輯課程";
        public const string COMPUTER_SCIENCE_TEXT = "資工三";

        // Attribute Name Text
        public const string TEXT_ATTRIBUTE_NAME = "Text";
        public const string COURSE_ID_TEXT = "CourseId";
        public const string COURSE_NAME_TEXT = "CourseName";
        public const string STAGE_TEXT = "Stage";
        public const string CREDIT_TEXT = "Credit";
        public const string TEACHER_TEXT = "Teacher";
        public const string NECESSITY_TEXT = "Necessity";
        public const string TEACHING_ASSISTANT_TEXT = "TeachingAssistant";
        public const string LANGUAGE_TEXT = "Language";
        public const string NOTE_TEXT = "Note";
        public const string HOUR_TEXT = "Hour";
        public const string SUNDAY_TEXT = "Sunday";
        public const string MONDAY_TEXT = "Monday";
        public const string TUESDAY_TEXT = "Tuesday";
        public const string WEDNESDAY_TEXT = "Wednesday";
        public const string THURSDAY_TEXT = "Thursday";
        public const string FRIDAY_TEXT = "Friday";
        public const string SATURDAY_TEXT = "Saturday";

        // Necessity
        public const string GOVERNMENT_SET_REQUIRED_COMMON_TEXT = "○";
        public const string SCHOOL_SET_REQUIRED_COMMON_TEXT = "△";
        public const string ELECTIVE_COMMON_TEXT = "☆";
        public const string GOVERNMENT_SET_REQUIRED_PROFESSIONAL_TEXT = "●";
        public const string SCHOOL_SET_REQUIRED_PROFESSIONAL_TEXT = "▲";
        public const string ELECTIVE_PROFESSIONAL_TEXT = "★";
    }
}
