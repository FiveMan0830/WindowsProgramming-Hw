using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseApplication.Model;
using CourseApplication.Dto;
using CourseApplication.PresentationModels.CourseSelecting;
using CourseApplication.PresentationModels.CourseSelectionResult;
using CourseApplication.Views.CourseSelectionResult;

namespace CourseApplication.Views.CourseSelecting
{
    public partial class CourseSelectingForm : Form
    {

        string ENABLED_ATTRIBUTE = "Enabled";
        CourseSelectingPresentationModel _courseSelectingPresentationModel;
        CourseSelectionResultPresentationModel _courseSelectionResultPresentationModel;
        CourseSelectionResultForm _courseSelectionResultForm;
        public CourseSelectingForm(CourseSelectingPresentationModel courseSelectingPresentationModel)
        {
            _courseSelectingPresentationModel = courseSelectingPresentationModel;
            _courseSelectingPresentationModel.CourseDtosChanged += RenderGridData;
            _courseSelectionResultPresentationModel = new CourseSelectionResultPresentationModel(_courseSelectingPresentationModel._courseApplicationModel);
            _courseSelectingDataGridComponent1 = new CourseSelectingDataGridComponent(courseSelectingPresentationModel, "資工三");
            _courseSelectingDataGridComponent2 = new CourseSelectingDataGridComponent(courseSelectingPresentationModel, "電子三甲");
            InitializeComponent();
            InitializeSelectingSubmitButton();
            InitializeSelectionResultButton();
            RenderGridData();
        }

        /// <summary>
        /// 初始化按鈕
        /// </summary>
        private void InitializeSelectingSubmitButton()
        {
            _courseSelectingSubmitButton.DataBindings.Add(ENABLED_ATTRIBUTE, _courseSelectingPresentationModel, "IsAnyCourseSelected");
        }

        /// <summary>
        /// 初始化按鈕
        /// </summary>
        private void InitializeSelectionResultButton()
        {
            _courseSelectionResultButton.DataBindings.Add(ENABLED_ATTRIBUTE, _courseSelectingPresentationModel, "IsNotCourseSelectionResultFormOpened");
        }

        /// <summary>
        /// 刷新頁面
        /// </summary>
        private void RenderGridData()
        {
            List<CourseSelectingDto> coursesCSIE = _courseSelectingPresentationModel.GetCoursesByDepartment("資工三");
            List<CourseSelectingDto> coursesCC = _courseSelectingPresentationModel.GetCoursesByDepartment("電子三甲");
            _courseSelectingDataGridComponent1.GetCourseSelectingDataGridView().DataSource = coursesCSIE;
            _courseSelectingDataGridComponent2.GetCourseSelectingDataGridView().DataSource = coursesCC;
        }

        /// <summary>
        /// 刷新頁面
        /// </summary>
        private void RenderAllComponents()
        {
            _courseSelectingSubmitButton.DataBindings[0].ReadValue();
            _courseSelectionResultButton.DataBindings[0].ReadValue();
        }

        /// <summary>
        /// 提交選課事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _courseSelectingSubmitButton_Click(object sender, EventArgs e)
        {
            // identify choosed course
            // move course
            _courseSelectingPresentationModel.NoticeOnSelectCourse();
            _courseSelectingPresentationModel._courses.Clear();
            _courseSelectingPresentationModel.InitializeCourse();
            RenderGridData();
        }

        /// <summary>
        /// 關閉選課結果視窗事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _courseSelectionResultForm_Closing(object sender, EventArgs e)
        {
            _courseSelectingPresentationModel.IsNotCourseSelectionResultFormOpened = true;
            RenderAllComponents();
        }

        /// <summary>
        /// 查看選課事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _courseSelectionResultButton_Click(object sender, EventArgs e)
        {
            _courseSelectionResultForm = new CourseSelectionResultForm(_courseSelectionResultPresentationModel);
            _courseSelectionResultForm.FormClosing += new FormClosingEventHandler(_courseSelectionResultForm_Closing);
            _courseSelectingPresentationModel.IsNotCourseSelectionResultFormOpened = false;
            _courseSelectionResultForm.Show();
            RenderAllComponents();
        }
    }
}
