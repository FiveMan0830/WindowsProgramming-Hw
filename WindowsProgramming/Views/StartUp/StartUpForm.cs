using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseApplication.PresentationModels.StartUp;
using CourseApplication.PresentationModels.CourseManagement;
using CourseApplication.PresentationModels.CourseSelecting;
using CourseApplication.PresentationModels.CourseSelectionResult;
using CourseApplication.Views.CourseSelecting;
using CourseApplication.Views.CourseManagement;

namespace CourseApplication.Views.StartUp
{
    public partial class StartUpForm : Form
    {
        string ENABLED_ATTRIBUTE = "Enabled";
        CourseSelectingPresentationModel _courseSelectingPresentationModel;
        CourseSelectingForm _courseSelectingForm;
        CourseManagementPresentationModel _courseManagementPresentationModel;
        CourseManagementForm _courseManagementForm;
        StartUpPresentationModel _startUpPresentationModel;


        public StartUpForm(StartUpPresentationModel model)
        {
            _startUpPresentationModel = model;
            InitializeComponent();
            InitializeCourseSelectButton();
            InitializeCourseManageButton();
            InitializeExitButton();
        }

        /// <summary>
        /// 設定
        /// </summary>
        /// <param name="courseSelectingPresentationModel"></param>
        public void SetCourseSelectingPresentationModel(CourseSelectingPresentationModel courseSelectingPresentationModel)
        {
            _courseSelectingPresentationModel = courseSelectingPresentationModel;
        }

        /// <summary>
        /// 設定
        /// </summary>
        /// <param name="courseManagementPresentationModel"></param>
        public void SetCourseManagementPresentationModel(CourseManagementPresentationModel courseManagementPresentationModel)
        {
            _courseManagementPresentationModel = courseManagementPresentationModel;
        }

        /// <summary>
        /// 初始化CourseSelectingButton
        /// </summary>
        private void InitializeCourseSelectButton()
        {
            _courseSelectButton.DataBindings.Add(ENABLED_ATTRIBUTE, _startUpPresentationModel, "IsNotCourseSelectingFormOpened");
            _courseSelectButton.Click += new EventHandler(CourseSelectButtonClickEvent);
        }

        /// <summary>
        /// 初始化CourseManagementButton
        /// </summary>
        private void InitializeCourseManageButton()
        {
            _courseManageButton.DataBindings.Add(ENABLED_ATTRIBUTE, _startUpPresentationModel, "IsNotCourseManagementFormOpened");
            _courseManageButton.Click += new EventHandler(CourseManageButtonClickEvent);
        }

        /// <summary>
        /// 初始化ExitButton
        /// </summary>
        private void InitializeExitButton()
        {
            _exitButton.Text = "Exit";
            _exitButton.Dock = DockStyle.Fill;
            _exitButton.Click += new EventHandler(ExitButtonClickEvent);
        }


        /// <summary>
        /// ExitButton按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButtonClickEvent(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 關閉選課視窗事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _courseSelectingForm_Closing(object sender, EventArgs e)
        {
            _startUpPresentationModel.IsNotCourseSelectingFormOpened = true;
            RenderAllComponents();
        }

        /// <summary>
        /// 關閉管理課程視窗事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _courseManagementForm_Closing(object sender, EventArgs e)
        {
            _startUpPresentationModel.IsNotCourseManagementFormOpened = true;
            RenderAllComponents();
        }

        /// <summary>
        /// CourseSelect按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CourseSelectButtonClickEvent(object sender, EventArgs e)
        {
            _courseSelectingForm = new CourseSelectingForm(_courseSelectingPresentationModel);
            _courseSelectingForm.FormClosing += new FormClosingEventHandler(_courseSelectingForm_Closing);
            _startUpPresentationModel.IsNotCourseSelectingFormOpened = false;
            RenderAllComponents();
            _courseSelectingForm.Show();
        }

        /// <summary>
        /// CourseManage按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CourseManageButtonClickEvent(object sender, EventArgs e)
        {
            _courseManagementForm = new CourseManagementForm(_courseManagementPresentationModel);
            _courseManagementForm.FormClosing += new FormClosingEventHandler(_courseManagementForm_Closing);
            _startUpPresentationModel.IsNotCourseManagementFormOpened = false;
            RenderAllComponents();
            _courseManagementForm.Show();
        }

        /// <summary>
        /// 物件刷新
        /// </summary>
        private void RenderAllComponents()
        {
            _courseManageButton.DataBindings[0].ReadValue();
            _courseSelectButton.DataBindings[0].ReadValue();
        }
    }
}
