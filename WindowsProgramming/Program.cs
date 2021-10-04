using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using HtmlAgilityPack;
using CourseApplication.Services;

namespace CourseApplication
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var resource = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2433";
            var webClient = new HtmlWeb();
            var fetchCourseService = new FetchCourseService(webClient, resource);
            var selectCoursePresentationModel = new SelectCoursePresentationModel(fetchCourseService);
            var form = new SelectCourseForm(selectCoursePresentationModel);

            Application.Run(form);
        }
    }
}
