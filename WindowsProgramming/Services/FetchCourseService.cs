using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseApplication.Analyzer.Interface;
using CourseApplication.Analyzer;
using CourseApplication.Model;
using CourseApplication.Dto;

namespace CourseApplication.Services
{
    class FetchCourseService
    {
        private const string NODE_XPATH = "//body/table";
        private readonly HtmlWeb _webClient;
        public FetchCourseService(HtmlWeb webClient)
        {
            _webClient = webClient;
        }

        /// <summary>
        /// 取得Course資料
        /// </summary>
        /// <returns></returns> 
        public List<Course> FetchCourse(string resource)
        {

            _webClient.OverrideEncoding = Encoding.Default;
            HtmlDocument document = _webClient.Load(resource);

            HtmlNode nodeTable = document.DocumentNode.SelectSingleNode(NODE_XPATH);
            HtmlNodeCollection nodeTableRow = GetChildNodes(nodeTable);

            IWebAnalyzer analyzer = new WebAnalyzer();
            RemoveRedundantNode(nodeTableRow, 0);
            string departmentName = GetDepartmentName(nodeTableRow);
            departmentName = departmentName.Replace(CourseApplicationConstants.BREAK_LINE, "");
            RemoveRedundantNode(nodeTableRow, 0);
            RemoveRedundantNode(nodeTableRow, 0);
            RemoveRedundantNode(nodeTableRow, GetLastRow(nodeTableRow));
            List<Course> courses = analyzer.Analyze(nodeTableRow);
            return courses;
        }

        /// <summary>
        /// 取得子節點
        /// </summary>
        /// <param name="nodeTable"></param>
        /// <returns></returns>
        private HtmlNodeCollection GetChildNodes(HtmlNode nodeTable)
        {
            return nodeTable.ChildNodes;
        }

        /// <summary>
        /// 取得科系名稱
        /// </summary>
        /// <param name="nodeTableRow"></param>
        /// <returns></returns>
        private string GetDepartmentName(HtmlNodeCollection nodeTableRow)
        {
            return nodeTableRow.First().InnerText;
        }

        /// <summary>
        /// 移除冗餘節點
        /// </summary>
        /// <param name="nodeTableRow"></param>
        /// <returns></returns>
        private HtmlNodeCollection RemoveRedundantNode(HtmlNodeCollection nodeTableRow, int index)
        {
            nodeTableRow.RemoveAt(index);
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
