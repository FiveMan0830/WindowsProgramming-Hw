using System;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseApplication.Model.CourseParts;
using CourseApplication.Model;
using CourseApplication.Builder.Interface;

namespace CourseApplication.Builder
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
        private Course SetTime(HtmlNodeCollection nodeTableDatas, Course course)
        {
            CourseTime courseTime = new CourseTime();
            const int SUNDAY_Index = 7;
            const int MONDAY_Index = 8;
            const int TUESDAY_Index = 9;
            const int WEDNESDAY_Index = 10;
            const int THURSDAY_Index = 11;
            const int FRIDAY_Index = 12;
            const int SATURDAY_Index = 13;

            course.Sunday = nodeTableDatas[SUNDAY_Index].InnerText.Trim();
            course.Monday = nodeTableDatas[MONDAY_Index].InnerText.Trim();
            course.Tuesday = nodeTableDatas[TUESDAY_Index].InnerText.Trim();
            course.Wednesday = nodeTableDatas[WEDNESDAY_Index].InnerText.Trim();
            course.Thursday = nodeTableDatas[THURSDAY_Index].InnerText.Trim();
            course.Friday = nodeTableDatas[FRIDAY_Index].InnerText.Trim();
            course.Saturday = nodeTableDatas[SATURDAY_Index].InnerText.Trim();
            return course;
        }

        /// <summary>
        /// 使用Node建立
        /// </summary>
        /// <param name="nodeTableDatas"></param>
        /// <returns></returns>
        public Course SetByNode(HtmlNodeCollection nodeTableDatas)
        {
            SetRequirements(nodeTableDatas);
            _course.Teacher = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.TeacherIndex));
            _course = SetTime(nodeTableDatas, _course);
            _course.Classroom = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.ClassroomIndex));
            _course.NumberOfStudents = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.NumberOfStudentsIndex));
            _course.NumberOfDropStudents = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.NumberOfDropStudentsIndex));
            _course.TeachingAssistant = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.TeachingAssistantIndex));
            _course.Language = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.LanguageIndex));
            _course.Syllabus = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.SyllabusIndex));
            _course.Note = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.NoteIndex));
            _course.Audit = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.AuditIndex));
            _course.Experiment = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.ExperimentIndex));
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
        private string GetDataFromTable(HtmlNodeCollection nodeTableDatas, int Index)
        {
            return nodeTableDatas[Index].InnerText.Trim();
        }

        /// <summary>
        /// 設置部分修課資訊
        /// </summary>
        /// <param name="nodeTableDatas"></param>
        private void SetRequirements(HtmlNodeCollection nodeTableDatas)
        {
            _course.CourseId = GetDataFromTable(nodeTableDatas, (int)CourseProperties.CourseIdIndex);
            _course.CourseName = GetDataFromTable(nodeTableDatas, (int)CourseProperties.CourseNameIndex);
            _course.Stage = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.StageIndex));
            _course.Credit = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.CreditIndex));
            _course.Hour = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.HourIndex));
            _course.Necessity = GetDataFromTable(nodeTableDatas, ((int)CourseProperties.NecessityIndex));
        }
    }
}