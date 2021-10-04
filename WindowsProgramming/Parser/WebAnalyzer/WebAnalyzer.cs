using System;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseApplication.Model;
using CourseApplication.Builder.Interface;
using CourseApplication.Builder.CourseBuilder;
using CourseApplication.Analyzer.Interface;

namespace CourseApplication.Analyzer.WebAnalyzer
{
    public class WebAnalyzer : IWebAnalyzer
    {
        /// <summary>
        /// Analyze Html To Course
        /// </summary>
        /// <param name="nodeTableRow"></param>
        /// <returns></returns>
        public List<Course> Analyze(HtmlNodeCollection nodeTableRow)
        {
            List<Course> courses = new List<Course>();

            foreach (var node in nodeTableRow)
            {
                HtmlNodeCollection nodeTableDatas = node.ChildNodes;
                // 移除 #text
                nodeTableDatas.RemoveAt(0);
                // build course
                courses.Add(BuildCourseByNode(nodeTableDatas));
            }
            return courses;
        }

        /// <summary>
        /// 建立Course
        /// </summary>
        /// <param name="nodeTableDatas"></param>
        /// <returns></returns>
        private Course BuildCourseByNode(HtmlNodeCollection nodeTableDatas)
        {
            ICourseBuilder builder = new CourseBuilder();
            return builder.SetByNode(nodeTableDatas);
        }
    }
}
