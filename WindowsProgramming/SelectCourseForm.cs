using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseApplication.Model.Course;
using CourseApplication.Service.Interfaces;
using CourseApplication.Service.FetchCourseService;

namespace CourseApplication
{
    public partial class SelectCourseForm : Form
    {
        public SelectCourseForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Load Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadSelectCourseForm(object sender, EventArgs e)
        {
            string courseResource = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2433";
            IFetchCourseService fetchCourseService = new FetchCourseService();
            List<Course> courses = fetchCourseService.FetchCourse(courseResource);
            
        }
    }
}
