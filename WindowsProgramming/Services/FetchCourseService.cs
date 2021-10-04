using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseApplication.Model;
using CourseApplication.Services.Interfaces;
using CourseApplication.Analyzer.Interface;
using CourseApplication.Analyzer.WebAnalyzer;

namespace CourseApplication.Services
{
    public class FetchCourseService : IFetchCourseService
    {
        private const string NODE_XPATH = "//body/table";
        private readonly HtmlWeb _webClient;
        private readonly Uri _resource;
        public FetchCourseService(HtmlWeb webClient, string resource)
        {
            _webClient = webClient;
            _resource = new Uri(resource);
        }
        /// <summary>
        /// 取得Course資料
        /// </summary>
        /// <returns></returns> 
        public IList<Course> FetchCourse()
        {
            _webClient.OverrideEncoding = Encoding.Default;
            HtmlDocument document = _webClient.Load(_resource);

            HtmlNode nodeTable = document.DocumentNode.SelectSingleNode(NODE_XPATH);
            HtmlNodeCollection nodeTableRow = nodeTable.ChildNodes;

            IWebAnalyzer analyzer = new WebAnalyzer();
            return analyzer.Analyze(RemoveRedundantNodes(nodeTableRow));
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
            nodeTableRow.RemoveAt(nodeTableRow.Count - 1);
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
