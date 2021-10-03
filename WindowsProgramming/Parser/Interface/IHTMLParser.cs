using System;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseApplication.Model.Course;

namespace CourseApplication.Parser.Interface
{
    interface IHTMLParser
    {
        /// <summary>
        /// 將HTML
        /// </summary>
        /// <param name="htmlDocument"></param>
        /// <returns></returns>
        List<Course> Parse(HtmlNodeCollection nodeTableRow);
    }
}
