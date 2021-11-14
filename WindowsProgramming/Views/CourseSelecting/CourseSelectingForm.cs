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
using CourseApplication.Views.TextConstants;

namespace CourseApplication.Views.CourseSelecting
{
    public partial class CourseSelectingForm : Form
    {
        CourseSelectingPresentationModel _courseSelectingPresentationModel;
        CourseSelectionResultPresentationModel _courseSelectionResultPresentationModel;
        CourseSelectionResultForm _courseSelectionResultForm;
        ErrorForm _errorForm;
        public CourseSelectingForm(CourseSelectingPresentationModel courseSelectingPresentationModel)
        {
            _courseSelectingPresentationModel = courseSelectingPresentationModel;
            _courseSelectingPresentationModel._courseDtosChanged += RenderGridData;
            _courseSelectionResultPresentationModel = new CourseSelectionResultPresentationModel(_courseSelectingPresentationModel._courseApplicationModel);
            InitializeComponent();
            CreateTabPage(1, CourseApplicationConstants.COMPUTER_SCIENCE_THIRD_GRADE_TEXT);
            CreateTabPage(1, CourseApplicationConstants.ELECTRON_ENGINEERING_THIRD_GRADE_TEXT);
            InitializeSelectingSubmitButton();
            InitializeSelectionResultButton();
            RenderGridData();
        }

        /// <summary>
        /// 初始化按鈕
        /// </summary>
        private void InitializeSelectingSubmitButton()
        {
            _courseSelectingSubmitButton.DataBindings.Add(ViewTextConstants.ENABLED_ATTRIBUTE, _courseSelectingPresentationModel, "IsAnyCourseSelected");
        }

        /// <summary>
        /// 初始化按鈕
        /// </summary>
        private void InitializeSelectionResultButton()
        {
            _courseSelectionResultButton.DataBindings.Add(ViewTextConstants.ENABLED_ATTRIBUTE, _courseSelectingPresentationModel, "IsNotCourseSelectionResultFormOpened");
        }

        /// <summary>
        /// 刷新頁面
        /// </summary>
        private void RenderGridData()
        {
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
        private void CourseSelectingSubmitButtonClick(object sender, EventArgs e)
        {
            string errorString = null;
            // move course
            errorString = GetSelectCourseError();
            if (errorString != "")
                _errorForm = new ErrorForm(errorString);
            else
                _errorForm = new ErrorForm();
            _errorForm.ShowDialog();
            _courseSelectingPresentationModel._courses.Clear();
            _courseSelectingPresentationModel.InitializeCourse();
            RenderGridData();
        }

        /// <summary>
        /// 選課
        /// </summary>
        /// <returns></returns>
        private string GetSelectCourseError()
        {
            return _courseSelectingPresentationModel.NoticeOnSelectCourse();
        }

        /// <summary>
        /// 關閉選課結果視窗事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CourseSelectionResultFormClosing(object sender, EventArgs e)
        {
            _courseSelectingPresentationModel.IsNotCourseSelectionResultFormOpened = true;
            RenderAllComponents();
        }

        /// <summary>
        /// 查看選課事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CourseSelectionResultButtonClick(object sender, EventArgs e)
        {
            _courseSelectionResultForm = new CourseSelectionResultForm(_courseSelectionResultPresentationModel);
            _courseSelectionResultForm.FormClosing += new FormClosingEventHandler(CourseSelectionResultFormClosing);
            _courseSelectingPresentationModel.IsNotCourseSelectionResultFormOpened = false;
            _courseSelectionResultForm.Show();
            RenderAllComponents();
        }

        /// <summary>
        /// 生成tab
        /// </summary>
        /// <param name="index"></param>
        /// <param name="departmentName"></param>
        private void CreateTabPage(int index, string departmentName)
        {
            string tabPageName = "_tabpage";
            TabPage tabPage = new TabPage();
            tabPage.Name = tabPageName + index;
            tabPage.Text = departmentName;
            _courseSelectingTabControl.TabPages.Add(tabPage);

            CourseSelectingDataGridComponent courseSelectingDataGridComponent = new CourseSelectingDataGridComponent(_courseSelectingPresentationModel, departmentName);
            courseSelectingDataGridComponent.Parent = tabPage;
            courseSelectingDataGridComponent.Name = CourseApplicationConstants.COURSE_SELECTING_DATA_GRID_COMPONENT + index;
        }
    }
}
