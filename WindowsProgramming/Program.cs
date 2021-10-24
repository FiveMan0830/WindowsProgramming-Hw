using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseApplication.Model;
using CourseApplication.PresentationModels.StartUp;
using CourseApplication.PresentationModels.CourseSelecting;
using CourseApplication.PresentationModels.CourseSelectionResult;
using CourseApplication.PresentationModels.CourseManagement;
using CourseApplication.Views.StartUp;
using CourseApplication.Views.CourseManagement;
using CourseApplication.Views.CourseSelectionResult;

using HtmlAgilityPack;

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

            CourseApplicationModel model = new CourseApplicationModel();

            StartUpPresentationModel startUpPresentationModel = new StartUpPresentationModel();
            CourseSelectingPresentationModel courseSelectingPresentationModel = new CourseSelectingPresentationModel(model);
            CourseManagementPresentationModel courseManagementPresentationModel = new CourseManagementPresentationModel();
            StartUpForm startUpForm = new StartUpForm(startUpPresentationModel);
            startUpForm.SetCourseManagementPresentationModel(courseManagementPresentationModel);
            startUpForm.SetCourseSelectingPresentationModel(courseSelectingPresentationModel);
            Application.Run(startUpForm);
        }
    }
}
