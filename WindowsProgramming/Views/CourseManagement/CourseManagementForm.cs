using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseApplication.Dto;
using CourseApplication.Views.TextConstants;
using CourseApplication.PresentationModels.CourseManagement;

namespace CourseApplication.Views.CourseManagement
{
    public partial class CourseManagementForm : Form
    {
        CourseManagementPresentationModel _courseManagementPresentationModel;
        public CourseManagementForm(CourseManagementPresentationModel courseManagementPresentationModel)
        {
            _courseManagementPresentationModel = courseManagementPresentationModel;
            _courseManagementPresentationModel._timeGridChanged += InitializeTimeGridBinding;
            InitializeComponent();
            InitializeListBox();
            _courseTimeDataGridView.CellValueChanged += DispatchOnTimeGridCellValueChanged;
            _courseTimeDataGridView.CellMouseUp += DispatchOnTimeGridCellMouseUp;
        }

        /// <summary>
        /// 初始化課程列表
        /// </summary>
        private void InitializeListBox()
        {
            _allCourseListBox.Items.Clear();
            foreach (string courseName in _courseManagementPresentationModel._courseNameList)
            {
                _allCourseListBox.Items.Add(courseName);
            }
        }

        /// <summary>
        /// MouseUp後停止更改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DispatchOnTimeGridCellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (IsCourseCheckBoxColumn(e.ColumnIndex) && e.RowIndex != -1)
                _courseTimeDataGridView.EndEdit();
        }

        /// <summary>
        /// 數值改動render
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DispatchOnTimeGridCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (IsCourseCheckBoxColumn(e.ColumnIndex) && e.RowIndex != -1)
                _courseManagementPresentationModel.NoticeOnCheckBoxClicked();
        }

        /// <summary>
        /// 確認典籍欄位是否為「選擇」欄
        /// </summary>
        /// <param name="columnIndex"></param>
        /// <returns></returns>
        public bool IsCourseCheckBoxColumn(int columnIndex)
        {
            return columnIndex != _coursePeriodTextBoxColumn.Index;
        }

        /// <summary>
        /// 按下新增課程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickAddNewCourseButtonEvent(object sender, EventArgs e)
        {
            _courseManagementPresentationModel.HandleAddNewCourse();
            _courseManageGroupBox.Text = ViewTextConstants.ADD_COURSE_TEXT;
            _courseManageSaveButton.Text = ViewTextConstants.ADD_BUTTON_TEXT;
            ClearDataBinding();
            InitializeDataBinding();
            EnableInputs();
        }

        /// <summary>
        /// 按下儲存按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickCourseManageSaveButtonEvent(object sender, EventArgs e)
        {
            _courseManagementPresentationModel.SetClass(_classComboBox.Text);
            _courseManagementPresentationModel.HandleSaveButtonClick();
            InitializeListBox();
        }

        /// <summary>
        /// 選擇課程事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangedAllCourseListBoxSelectedIndex(object sender, EventArgs e)
        {
            int index = _allCourseListBox.SelectedIndex;
            _courseManagementPresentationModel.HandleChangeSelectedIndex(index);
            _courseManageGroupBox.Text = ViewTextConstants.UPDATE_COURSE_TEXT;
            _courseManageSaveButton.Text = ViewTextConstants.UPDATE_BUTTON_TEXT;
            ClearDataBinding();
            InitializeDataBinding();
            EnableInputs();
        }

        /// <summary>
        /// 清除綁定
        /// </summary>
        private void ClearDataBinding()
        {
            _courseIdTextBox.DataBindings.Clear();
            _courseNameTextBox.DataBindings.Clear();
            _stageTextBox.DataBindings.Clear();
            _creditTextBox.DataBindings.Clear();
            _teacherTextBox.DataBindings.Clear();
            _necessityComboBox.DataBindings.Clear();
            _teachingAssistantTextBox.DataBindings.Clear();
            _languageTextBox.DataBindings.Clear();
            _noteTextBox.DataBindings.Clear();
            _hourComboBox.DataBindings.Clear();
            _courseManageSaveButton.DataBindings.Clear();
        }

        /// <summary>
        /// 綁定資料
        /// </summary>
        private void InitializeDataBinding()
        {
            _courseIdTextBox.DataBindings.Add(CourseApplicationConstants.TEXT_ATTRIBUTE_NAME, _courseManagementPresentationModel._currentCourse, CourseApplicationConstants.COURSE_ID_TEXT);
            _courseNameTextBox.DataBindings.Add(CourseApplicationConstants.TEXT_ATTRIBUTE_NAME, _courseManagementPresentationModel._currentCourse, CourseApplicationConstants.COURSE_NAME_TEXT);
            _stageTextBox.DataBindings.Add(CourseApplicationConstants.TEXT_ATTRIBUTE_NAME, _courseManagementPresentationModel._currentCourse, CourseApplicationConstants.STAGE_TEXT);
            _creditTextBox.DataBindings.Add(CourseApplicationConstants.TEXT_ATTRIBUTE_NAME, _courseManagementPresentationModel._currentCourse, CourseApplicationConstants.CREDIT_TEXT);
            _teacherTextBox.DataBindings.Add(CourseApplicationConstants.TEXT_ATTRIBUTE_NAME, _courseManagementPresentationModel._currentCourse, CourseApplicationConstants.TEACHER_TEXT);
            _necessityComboBox.DataBindings.Add(CourseApplicationConstants.TEXT_ATTRIBUTE_NAME, _courseManagementPresentationModel._currentCourse, CourseApplicationConstants.NECESSITY_TEXT);
            _teachingAssistantTextBox.DataBindings.Add(CourseApplicationConstants.TEXT_ATTRIBUTE_NAME, _courseManagementPresentationModel._currentCourse, CourseApplicationConstants.TEACHING_ASSISTANT_TEXT);
            _languageTextBox.DataBindings.Add(CourseApplicationConstants.TEXT_ATTRIBUTE_NAME, _courseManagementPresentationModel._currentCourse, CourseApplicationConstants.LANGUAGE_TEXT);
            _noteTextBox.DataBindings.Add(CourseApplicationConstants.TEXT_ATTRIBUTE_NAME, _courseManagementPresentationModel._currentCourse, CourseApplicationConstants.NOTE_TEXT);
            _hourComboBox.DataBindings.Add(CourseApplicationConstants.TEXT_ATTRIBUTE_NAME, _courseManagementPresentationModel._currentCourse, CourseApplicationConstants.HOUR_TEXT);
            _courseManageSaveButton.DataBindings.Add("Enabled", _courseManagementPresentationModel, "IsSaveEnabled");
            _classComboBox.Text = _courseManagementPresentationModel.GetClassName;
        }

        /// <summary>
        /// 設為可用
        /// </summary>
        private void EnableInputs()
        {
            _courseStatusComboBox.Enabled = true;
            _courseIdTextBox.Enabled = true;
            _courseNameTextBox.Enabled = true;
            _stageTextBox.Enabled = true;
            _creditTextBox.Enabled = true;
            _teacherTextBox.Enabled = true;
            _necessityComboBox.Enabled = true;
            _teachingAssistantTextBox.Enabled = true;
            _languageTextBox.Enabled = true;
            _noteTextBox.Enabled = true;
            _hourComboBox.Enabled = true;
            _classComboBox.Enabled = true;
        }

        /// <summary>
        /// 項目更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangedCourseIdTextBoxText(object sender, EventArgs e)
        {
            _courseManagementPresentationModel.HandleTextChanged(CourseApplicationConstants.COURSE_ID_TEXT, _courseIdTextBox.Text);
        }

        /// <summary>
        /// 項目更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangedCourseNameTextBoxText(object sender, EventArgs e)
        {
            _courseManagementPresentationModel.HandleTextChanged(CourseApplicationConstants.COURSE_NAME_TEXT, _courseNameTextBox.Text);
        }

        /// <summary>
        /// 項目更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangedStageTextBoxText(object sender, EventArgs e)
        {
            _courseManagementPresentationModel.HandleTextChanged(CourseApplicationConstants.STAGE_TEXT, _stageTextBox.Text);
        }

        /// <summary>
        /// 項目更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangedCreditTextBoxText(object sender, EventArgs e)
        {
            _courseManagementPresentationModel.HandleTextChanged(CourseApplicationConstants.CREDIT_TEXT, _creditTextBox.Text);
        }

        /// <summary>
        /// 項目更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangedTeacherTextBoxText(object sender, EventArgs e)
        {
            _courseManagementPresentationModel.HandleTextChanged(CourseApplicationConstants.TEACHER_TEXT, _teacherTextBox.Text);
        }

        /// <summary>
        /// 項目更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangedTeachingAssistantTextBoxText(object sender, EventArgs e)
        {
            _courseManagementPresentationModel.HandleTextChanged(CourseApplicationConstants.TEACHING_ASSISTANT_TEXT, _teachingAssistantTextBox.Text);
        }

        /// <summary>
        /// 項目更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangedLanguageTextBoxText(object sender, EventArgs e)
        {
            _courseManagementPresentationModel.HandleTextChanged(CourseApplicationConstants.LANGUAGE_TEXT, _languageTextBox.Text);
        }

        /// <summary>
        /// 項目更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangedNoteTextBoxText(object sender, EventArgs e)
        {
            _courseManagementPresentationModel.HandleTextChanged(CourseApplicationConstants.NOTE_TEXT, _noteTextBox.Text);
        }

        /// <summary>
        /// 項目更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangedCourseStatusComboBoxText(object sender, EventArgs e)
        {
            //_courseManagementPresentationModel.HandleTextChanged("State", _noteTextBox.Text);
        }

        /// <summary>
        /// 項目更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangedClassComboBoxText(object sender, EventArgs e)
        {
            //_courseManagementPresentationModel.HandleTextChanged("Class", _noteTextBox.Text);
        }

        /// <summary>
        /// 項目更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangedNecessityComboBoxText(object sender, EventArgs e)
        {
            _courseManagementPresentationModel.HandleTextChanged(CourseApplicationConstants.NECESSITY_TEXT, _necessityComboBox.Text);
        }

        /// <summary>
        /// 項目更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangedHourComboBoxText(object sender, EventArgs e)
        {
            _courseManagementPresentationModel.HandleTextChanged(CourseApplicationConstants.HOUR_TEXT, _hourComboBox.Text);
        }

        /// <summary>
        /// 綁定時間資料
        /// </summary>
        private void InitializeTimeGridBinding()
        {
            _courseTimeDataGridView.DataSource = _courseManagementPresentationModel._courseTimeGrid;
            return;
        }
    }
}
