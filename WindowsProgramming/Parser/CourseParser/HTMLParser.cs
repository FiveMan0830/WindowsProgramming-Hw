using System;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseApplication.Model.Course;
using CourseApplication.Builder.Interface;
using CourseApplication.Builder.CourseBuilder;
using CourseApplication.Parser.Interface;

namespace CourseApplication.Parser.CourseParser
{
    class HTMLParser : IHTMLParser
    {
        /// <summary>
        /// Parse Html To Course
        /// </summary>
        /// <param name="htmlDocument"></param>
        /// <returns></returns>
        public List<Course> Parse(HtmlNodeCollection nodeTableRow)
        {
            List<Course> courses = new List<Course>();

            foreach (var node in nodeTableRow)
            {
                HtmlNodeCollection nodeTableDatas = node.ChildNodes;
                // 移除 #text
                nodeTableDatas.RemoveAt(0);
                ICourseBuilder courseBuilder = new CourseBuilder();
                // build course
                courses.Add(courseBuilder.BuildCourseByNode(nodeTableDatas));
            }
            return courses;
        }
    }
}
