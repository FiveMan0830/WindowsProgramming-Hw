using System;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseApplication.Model;

namespace CourseApplication.Builder.Interface
{
    public interface ICourseBuilder
    {
        /// <summary>
        /// 設置課號
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ICourseBuilder SetId(string id);
        /// <summary>
        /// 設置課程名稱
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        ICourseBuilder SetName(string className);
        /// <summary>
        /// 設置階段
        /// </summary>
        /// <param name="stage"></param>
        /// <returns></returns>
        ICourseBuilder SetStage(string stage);
        /// <summary>
        /// 設置學分數
        /// </summary>
        /// <param name="credit"></param>
        /// <returns></returns>
        ICourseBuilder SetCredit(string credit);
        /// <summary>
        /// 設置上課時數
        /// </summary>
        /// <param name="Hour"></param>
        /// <returns></returns>
        ICourseBuilder SetHour(string hour);
        /// <summary>
        /// 設置學分及上課時數
        /// </summary>
        /// <param name="credit"></param>
        /// <param name="hour"></param>
        /// <returns></returns>
        ICourseBuilder SetCreditAndHour(string credit, string hour);
        /// <summary>
        /// 設置選必修別
        /// </summary>
        /// <param name="necessity"></param>
        /// <returns></returns>
        ICourseBuilder SetNecessity(string necessity);
        /// <summary>
        /// 設置教師
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        ICourseBuilder SetTeacher(string teacher);
        /// <summary>
        /// 設置上課時間
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        ICourseBuilder SetTime(List<string> time);
        /// <summary>
        /// 設置教室
        /// </summary>
        /// <param name="classroom"></param>
        /// <returns></returns>
        ICourseBuilder SetRoom(string classroom);
        /// <summary>
        /// 設置學生人數
        /// </summary>
        /// <param name="numberOfStudents"></param>
        /// <param name="numberOfDropStudents"></param>
        /// <returns></returns>
        ICourseBuilder SetNumberOfStudents(string numberOfStudents, string numberOfDropStudents);
        /// <summary>
        /// 設置助教
        /// </summary>
        /// <param name="ta"></param>
        /// <returns></returns>
        ICourseBuilder SetTeachingAssistant(string teachingAssistant);
        /// <summary>
        /// 設置語言
        /// </summary>
        /// <param name="Language"></param>
        /// <returns></returns>
        ICourseBuilder SetLanguage(string language);
        /// <summary>
        /// 設置大綱
        /// </summary>
        /// <param name="syllabus"></param>
        /// <returns></returns>
        ICourseBuilder SetSyllabus(string syllabus);
        /// <summary>
        /// 設置備註
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        ICourseBuilder SetNote(string note);
        /// <summary>
        /// 設置隨班附讀
        /// </summary>
        /// <param name="audit"></param>
        /// <returns></returns>
        ICourseBuilder SetAudit(string audit);
        /// <summary>
        /// 設置實驗實習
        /// </summary>
        /// <param name="experiment"></param>
        /// <returns></returns>
        ICourseBuilder SetExperiment(string experiment);
        /// <summary>
        /// 使用Node建立
        /// </summary>
        /// <param name="nodeTableDatas"></param>
        /// <returns></returns>
        Course SetByNode(HtmlNodeCollection nodeTableDatas);
        /// <summary>
        /// Get Course
        /// </summary>
        /// <returns></returns>
        Course GetCourse();
    }
}
