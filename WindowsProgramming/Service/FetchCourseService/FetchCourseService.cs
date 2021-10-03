using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseApplication.Model.Course;
using CourseApplication.Service.Interfaces;
using CourseApplication.Parser.Interface;
using CourseApplication.Parser.CourseParser;

namespace CourseApplication.Service.FetchCourseService
{
    class FetchCourseService : IFetchCourseService
    {
        /// <summary>
        /// 取得Course資料
        /// </summary>
        /// <param name="resourceRoute"></param>
        /// <returns></returns>
        public List<Course> FetchCourse(string resourceRoute)
        {
            const string NODE_PATH = "//body/table";
            HtmlWeb webClient = new HtmlWeb();
            webClient.OverrideEncoding = Encoding.Default;
            HtmlDocument document = webClient.Load(resourceRoute);

            HtmlNode nodeTable = document.DocumentNode.SelectSingleNode(NODE_PATH);
            HtmlNodeCollection nodeTableRow = nodeTable.ChildNodes;

            IHTMLParser parser = new HTMLParser();

            return parser.Parse(nodeTableRow);
        }
        /// <summary>
        /// 移除冗餘節點
        /// </summary>
        /// <param name="nodeTableRow"></param>
        /// <returns></returns>
        private HtmlNodeCollection RemoveRedundantNodes(HtmlNodeCollection nodeTableRow)
        {
            nodeTableRow.RemoveAt(0);
            nodeTableRow.RemoveAt(0);
            nodeTableRow.RemoveAt(0);
            nodeTableRow.RemoveAt(GetLastRow(nodeTableRow));
            return nodeTableRow;
        }

        /// <summary>
        /// 取最後一行
        /// </summary>
        /// <param name="nodeTableRow"></param>
        /// <returns></returns>
        private int GetLastRow(HtmlNodeCollection nodeTableRow)
        {
            return nodeTableRow.Count - 1;
        }
    }
}
