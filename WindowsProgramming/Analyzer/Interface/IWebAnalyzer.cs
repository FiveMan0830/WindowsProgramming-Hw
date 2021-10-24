using System;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseApplication.Model;

namespace CourseApplication.Analyzer.Interface
{
    public interface IWebAnalyzer
    {
        /// <summary>
        /// 將HTML
        /// </summary>
        /// <param name="htmlDocument"></param>
        /// <returns></returns>
        List<Course> Analyze(HtmlNodeCollection nodeTableRow);
    }
}