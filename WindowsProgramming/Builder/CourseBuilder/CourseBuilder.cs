using System;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseApplication.Model.Course;
using CourseApplication.Builder.Interface;

namespace CourseApplication.Builder.CourseBuilder
{
    class CourseBuilder : ICourseBuilder
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
        public ICourseBuilder SetId(int id)
        {
            _course.courseId = id;
            return this;
        }

        /// <summary>
        /// 設置課程名稱
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        public ICourseBuilder SetName(string className)
        {
            _course.className = className;
            return this;
        }

        /// <summary>
        /// 設置階段
        /// </summary>
        /// <param name="stage"></param>
        /// <returns></returns>
        public ICourseBuilder SetStage(int stage)
        {
            _course.stage = stage;
            return this;
        }

        /// <summary>
        /// 設置學分數
        /// </summary>
        /// <param name="credit"></param>
        /// <returns></returns>
        public ICourseBuilder SetCredit(float credit)
        {
            _course.credit = credit;
            return this;
        }

        /// <summary>
        /// 設置上課時數
        /// </summary>
        /// <param name="Hour"></param>
        /// <returns></returns>
        public ICourseBuilder SetHour(int hour)
        {
            _course.hour = hour;
            return this;
        }

        /// <summary>
        /// 設置學分數及上課時數
        /// </summary>
        /// <param name="credit"></param>
        /// <param name="hour"></param>
        /// <returns></returns>
        public ICourseBuilder SetCreditAndHour(float credit, int hour)
        {
            _course.credit = credit;
            _course.hour = hour;
            return this;
        }

        /// <summary>
        /// 設置選必修別
        /// </summary>
        /// <param name="necessity"></param>
        /// <returns></returns>
        public ICourseBuilder SetNecessity(string necessity)
        {
            _course.necessity = necessity;
            return this;
        }

        /// <summary>
        /// 設置教師
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        public ICourseBuilder SetTeacher(string teacher)
        {
            _course.teacher = teacher;
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
            CourseTime courseTime = new CourseTime();
            courseTime.sunday = time.ToArray()[SUNDAY_LOCATION];
            courseTime.monday = time.ToArray()[MONDAY_LOCATION];
            courseTime.tuesday = time.ToArray()[TUESDAY_LOCATION];
            courseTime.wednesday = time.ToArray()[WEDNESDAY_LOCATION];
            courseTime.thursday = time.ToArray()[THURSDAY_LOCATION];
            courseTime.friday = time.ToArray()[FRIDAY_LOCATION];
            courseTime.saturday = time.ToArray()[SATURDAY_LOCATION];
            return this;
        }

        /// <summary>
        /// 設置教室
        /// </summary>
        /// <param name="classroom"></param>
        /// <returns></returns>
        public ICourseBuilder SetRoom(string classroom)
        {
            _course.classroom = classroom;
            return this;
        }

        /// <summary>
        /// 設置學生人數
        /// </summary>
        /// <param name="numberOfStudents"></param>
        /// <param name="numberOfDropStudents"></param>
        /// <returns></returns>
        public ICourseBuilder SetNumberOfStudents(int numberOfStudents, int numberOfDropStudents)
        {
            _course.numberOfStudents = numberOfStudents;
            _course.numberOfDropStudents = numberOfDropStudents;
            return this;
        }

        /// <summary>
        /// 設置助教
        /// </summary>
        /// <param name="teachingAssistant"></param>
        /// <returns></returns>
        public ICourseBuilder SetTeachingAssistant(string teachingAssistant)
        {
            _course.teachingAssistant = teachingAssistant;
            return this;
        }

        /// <summary>
        /// 設置語言
        /// </summary>
        /// <param name="Language"></param>
        /// <returns></returns>
        public ICourseBuilder SetLanguage(string language)
        {
            _course.language = language;
            return this;
        }

        /// <summary>
        /// 設置大綱
        /// </summary>
        /// <param name="syllabus"></param>
        /// <returns></returns>
        public ICourseBuilder SetSyllabus(string syllabus)
        {
            _course.syllabus = syllabus;
            return this;
        }

        /// <summary>
        /// 設置備註
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        public ICourseBuilder SetNote(string note)
        {
            _course.note = note;
            return this;
        }

        /// <summary>
        /// 設置隨班附讀
        /// </summary>
        /// <param name="audit"></param>
        /// <returns></returns>
        public ICourseBuilder SetAudit(string audit)
        {
            _course.audit = audit;
            return this;
        }

        /// <summary>
        /// 設置實驗實習
        /// </summary>
        /// <param name="experiment"></param>
        /// <returns></returns>
        public ICourseBuilder SetExperiment(string experiment)
        {
            _course.experiment = experiment;
            return this;
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
        /// 取得上課時間
        /// </summary>
        /// <param name="nodeTableDatas"></param>
        /// <returns></returns>
        private List<string> GetTime(HtmlNodeCollection nodeTableDatas)
        {
            const int START_LOCATION = 7;
            const int END_LOCATION = 14;
            List<string> time = new List<string>();

            for (int i = START_LOCATION; i < END_LOCATION; i++)
            {
                time.Add(nodeTableDatas[i].InnerText.Trim());
            }

            return time;
        }

        /// <summary>
        /// 建立Course
        /// </summary>
        /// <param name="nodeTableDatas"></param>
        /// <returns></returns>
        public Course BuildCourseByNode(HtmlNodeCollection nodeTableDatas)
        {
            return this.SetId(Int32.Parse(GetDataFromTable(nodeTableDatas, (int)CourseProperties.CourseIdLocation)))
                        .SetName(GetDataFromTable(nodeTableDatas, (int)CourseProperties.CourseNameLocation))
                        .SetStage(Int32.Parse(GetDataFromTable(nodeTableDatas, ((int)CourseProperties.StageLocation))))
                        .SetCreditAndHour(float.Parse(GetDataFromTable(nodeTableDatas, ((int)CourseProperties.CreditLocation))), Int32.Parse(GetDataFromTable(nodeTableDatas, ((int)CourseProperties.HourLocation))))
                        .SetNecessity(GetDataFromTable(nodeTableDatas, ((int)CourseProperties.NecessityLocation)))
                        .SetTeacher(GetDataFromTable(nodeTableDatas, ((int)CourseProperties.TeacherLocation)))
                        .SetTime(GetTime(nodeTableDatas))
                        .SetRoom(GetDataFromTable(nodeTableDatas, ((int)CourseProperties.ClassroomLocation)))
                        .SetNumberOfStudents(Int32.Parse(GetDataFromTable(nodeTableDatas, ((int)CourseProperties.NumberOfStudentsLocation))), Int32.Parse(GetDataFromTable(nodeTableDatas, ((int)CourseProperties.NumberOfDropStudentsLocation))))
                        .SetTeachingAssistant(GetDataFromTable(nodeTableDatas, ((int)CourseProperties.TeachingAssistantLocation)))
                        .SetLanguage(GetDataFromTable(nodeTableDatas, ((int)CourseProperties.LanguageLocation)))
                        .SetSyllabus(GetDataFromTable(nodeTableDatas, ((int)CourseProperties.SyllabusLocation)))
                        .SetNote(GetDataFromTable(nodeTableDatas, ((int)CourseProperties.NoteLocation)))
                        .SetAudit(GetDataFromTable(nodeTableDatas, ((int)CourseProperties.AuditLocation)))
                        .SetExperiment(GetDataFromTable(nodeTableDatas, ((int)CourseProperties.ExperimentLocation)))
                        .GetCourse();
        }
        /// <summary>
        /// 從 Table 拿取 Course Data
        /// </summary>
        /// <param name="nodeTableDatas"></param>
        /// <returns></returns>
        private string GetDataFromTable(HtmlNodeCollection nodeTableDatas, int location)
        {
            return nodeTableDatas[location].InnerText.Trim();
        }
    }
}
