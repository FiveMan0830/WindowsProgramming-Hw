using System;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseApplication.Model;
using CourseApplication.Builder.Interface;

namespace CourseApplication.Builder.CourseBuilder
{
    public class CourseBuilder : ICourseBuilder
    {
        private Course _course;

        public CourseBuilder()
        {
            _course = new Course();
        }

        /// <summary>
        /// 設置課號
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ICourseBuilder SetId(string id)
        {
            _course.CourseId = id;
            return this;
        }

        /// <summary>
        /// 設置課程名稱
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        public ICourseBuilder SetName(string className)
        {
            _course.CourseName = className;
            return this;
        }

        /// <summary>
        /// 設置階段
        /// </summary>
        /// <param name="stage"></param>
        /// <returns></returns>
        public ICourseBuilder SetStage(string stage)
        {
            _course.Stage = stage;
            return this;
        }

        /// <summary>
        /// 設置學分數
        /// </summary>
        /// <param name="credit"></param>
        /// <returns></returns>
        public ICourseBuilder SetCredit(string credit)
        {
            _course.Credit = credit;
            return this;
        }

        /// <summary>
        /// 設置上課時數
        /// </summary>
        /// <param name="Hour"></param>
        /// <returns></returns>
        public ICourseBuilder SetHour(string hour)
        {
            _course.Hour = hour;
            return this;
        }

        /// <summary>
        /// 設置學分數及上課時數
        /// </summary>
        /// <param name="credit"></param>
        /// <param name="hour"></param>
        /// <returns></returns>
        public ICourseBuilder SetCreditAndHour(string credit, string hour)
        {
            _course.Credit = credit;
            _course.Hour = hour;
            return this;
        }

        /// <summary>
        /// 設置選必修別
        /// </summary>
        /// <param name="necessity"></param>
        /// <returns></returns>
        public ICourseBuilder SetNecessity(string necessity)
        {
            _course.Necessity = necessity;
            return this;
        }

        /// <summary>
        /// 設置教師
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        public ICourseBuilder SetTeacher(string teacher)
        {
            _course.Teacher = teacher;
            return this;
        }

        /// <summary>
        /// 設置上課時間
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public ICourseBuilder SetTime(List<string> time)
        {
            const int SUNDAY_LOCATION = 0;
            const int MONDAY_LOCATION = 1;
            const int TUESDAY_LOCATION = 2;
            const int WEDNESDAY_LOCATION = 3;
            const int THURSDAY_LOCATION = 4;
            const int FRIDAY_LOCATION = 5;
            const int SATURDAY_LOCATION = 6;
            CourseTime CourseTime = new CourseTime();
            CourseTime.Sunday = time.ToArray()[SUNDAY_LOCATION];
            CourseTime.Monday = time.ToArray()[MONDAY_LOCATION];
            CourseTime.Tuesday = time.ToArray()[TUESDAY_LOCATION];
            CourseTime.Wednesday = time.ToArray()[WEDNESDAY_LOCATION];
            CourseTime.Thursday = time.ToArray()[THURSDAY_LOCATION];
            CourseTime.Friday = time.ToArray()[FRIDAY_LOCATION];
            CourseTime.Saturday = time.ToArray()[SATURDAY_LOCATION];
            return this;
        }

        /// <summary>
        /// 設置教室
        /// </summary>
        /// <param name="classroom"></param>
        /// <returns></returns>
        public ICourseBuilder SetRoom(string classroom)
        {
            _course.Classroom = classroom;
            return this;
        }

        /// <summary>
        /// 設置學生人數
        /// </summary>
        /// <param name="numberOfStudents"></param>
        /// <param name="numberOfDropStudents"></param>
        /// <returns></returns>
        public ICourseBuilder SetNumberOfStudents(string numberOfStudents, string numberOfDropStudents)
        {
            _course.NumberOfStudents = numberOfStudents;
            _course.NumberOfDropStudents = numberOfDropStudents;
            return this;
        }

        /// <summary>
        /// 設置助教
        /// </summary>
        /// <param name="teachingAssistant"></param>
        /// <returns></returns>
        public ICourseBuilder SetTeachingAssistant(string teachingAssistant)
        {
            _course.TeachingAssistant = teachingAssistant;
            return this;
        }

        /// <summary>
        /// 設置語言
        /// </summary>
        /// <param name="Language"></param>
        /// <returns></returns>
        public ICourseBuilder SetLanguage(string language)
        {
            _course.Language = language;
            return this;
        }

        /// <summary>
        /// 設置大綱
        /// </summary>
        /// <param name="syllabus"></param>
        /// <returns></returns>
        public ICourseBuilder SetSyllabus(string syllabus)
        {
            _course.Syllabus = syllabus;
            return this;
        }

        /// <summary>
        /// 設置備註
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        public ICourseBuilder SetNote(string note)
        {
            _course.Note = note;
            return this;
        }

        /// <summary>
        /// 設置隨班附讀
        /// </summary>
        /// <param name="audit"></param>
        /// <returns></returns>
        public ICourseBuilder SetAudit(string audit)
        {
            _course.Audit = audit;
            return this;
        }

        /// <summary>
        /// 設置實驗實習
        /// </summary>
        /// <param name="experiment"></param>
        /// <returns></returns>
        public ICourseBuilder SetExperiment(string experiment)
        {
            _course.Experiment = experiment;
            return this;
        }

        /// <summary>
        /// 取得上課時間
        /// </summary>
        /// <param name="nodeTableDatas"></param>
        /// <returns></returns>
        private void SetTime(HtmlNodeCollection nodeTableDatas)
        {
            CourseTime CourseTime = new CourseTime();
            const int SUNDAY_LOCATION = 7;
            const int MONDAY_LOCATION = 8;
            const int TUESDAY_LOCATION = 9;
            const int WEDNESDAY_LOCATION = 10;
            const int THURSDAY_LOCATION = 11;
            const int FRIDAY_LOCATION = 12;
            const int SATURDAY_LOCATION = 13;

            CourseTime.Sunday = nodeTableDatas[SUNDAY_LOCATION].InnerText.Trim();
            CourseTime.Monday = nodeTableDatas[MONDAY_LOCATION].InnerText.Trim();
            CourseTime.Tuesday = nodeTableDatas[TUESDAY_LOCATION].InnerText.Trim();
            CourseTime.Wednesday = nodeTableDatas[WEDNESDAY_LOCATION].InnerText.Trim();
            CourseTime.Thursday = nodeTableDatas[THURSDAY_LOCATION].InnerText.Trim();
            CourseTime.Friday = nodeTableDatas[FRIDAY_LOCATION].InnerText.Trim();
            CourseTime.Saturday = nodeTableDatas[SATURDAY_LOCATION].InnerText.Trim();
        }

        /// <summary>
        /// 使用Node建立
        /// </summary>
        /// <param name="nodeTableDatas"></param>
        /// <returns></returns>
        public Course SetByNode(HtmlNodeCollection nodeTableDatas)
        {
            SetRequirements(nodeTableDatas);
            _course.Teacher = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.TeacherLocation));
            SetTime(nodeTableDatas);
            _course.Classroom = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.ClassroomLocation));
            _course.NumberOfStudents = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.NumberOfStudentsLocation));
            _course.NumberOfDropStudents = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.NumberOfDropStudentsLocation));
            _course.TeachingAssistant = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.TeachingAssistantLocation));
            _course.Language = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.LanguageLocation));
            _course.Syllabus = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.SyllabusLocation));
            _course.Note = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.NoteLocation));
            _course.Audit = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.AuditLocation));
            _course.Experiment = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.ExperimentLocation));
            return _course;
        }

        /// <summary>
        /// Get Course
        /// </summary>
        /// <returns></returns>
        public Course GetCourse()
        {
            return _course;
        }

        /// <summary>
        /// 從 Table 拿取 Course Data
        /// </summary>
        /// <param name="nodeTableDatas"></param>
        /// <returns></returns>
        private string GetDataFromTable(HtmlNodeCollection nodeTableDatas, int location)
        {
            return nodeTableDatas[location-1].InnerText.Trim();
        }

        /// <summary>
        /// 設置部分修課資訊
        /// </summary>
        /// <param name="nodeTableDatas"></param>
        private void SetRequirements(HtmlNodeCollection nodeTableDatas)
        {
            _course.CourseId = GetDataFromTable(nodeTableDatas, (int)CourseProperties.CourseIdLocation);
            _course.CourseName = GetDataFromTable(nodeTableDatas, (int)CourseProperties.CourseNameLocation);
            _course.Stage = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.StageLocation));
            _course.Credit = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.CreditLocation));
            _course.Hour = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.HourLocation));
            _course.Necessity = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.NecessityLocation));
        }
    }
}
