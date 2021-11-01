using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseApplication.PresentationModels.CourseManagement;

namespace CourseApplication.Views.CourseManagement
{
    public partial class CourseManagementForm : Form
    {
        const string TEXT_ATTRIBUTE_NAME = "Text";
        const string COURSE_ID_TEXT = "CourseId";
        const string COURSE_NAME_TEXT = "CourseName";
        const string STAGE_TEXT = "Stage";
        const string CREDIT_TEXT = "Credit";
        const string TEACHER_TEXT = "Teacher";
        const string NECESSITY_TEXT = "Necessity";
        const string TEACHING_ASSISTANT_TEXT = "TeachingAssistant";
        const string LANGUAGE_TEXT = "Language";
        const string NOTE_TEXT = "Note";
        const string HOUR_TEXT = "Hour";
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
            _courseManageGroupBox.Text = "新增課程";
            _courseManageSaveButton.Text = "新增";
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
            _courseManageGroupBox.Text = "編輯課程";
            _courseManageSaveButton.Text = "儲存";
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
            _courseIdTextBox.DataBindings.Add(TEXT_ATTRIBUTE_NAME, _courseManagementPresentationModel._currentCourse, COURSE_ID_TEXT);
            _courseNameTextBox.DataBindings.Add(TEXT_ATTRIBUTE_NAME, _courseManagementPresentationModel._currentCourse, COURSE_NAME_TEXT);
            _stageTextBox.DataBindings.Add(TEXT_ATTRIBUTE_NAME, _courseManagementPresentationModel._currentCourse, STAGE_TEXT);
            _creditTextBox.DataBindings.Add(TEXT_ATTRIBUTE_NAME, _courseManagementPresentationModel._currentCourse, CREDIT_TEXT);
            _teacherTextBox.DataBindings.Add(TEXT_ATTRIBUTE_NAME, _courseManagementPresentationModel._currentCourse, TEACHER_TEXT);
            _necessityComboBox.DataBindings.Add(TEXT_ATTRIBUTE_NAME, _courseManagementPresentationModel._currentCourse, NECESSITY_TEXT);
            _teachingAssistantTextBox.DataBindings.Add(TEXT_ATTRIBUTE_NAME, _courseManagementPresentationModel._currentCourse, TEACHING_ASSISTANT_TEXT);
            _languageTextBox.DataBindings.Add(TEXT_ATTRIBUTE_NAME, _courseManagementPresentationModel._currentCourse, LANGUAGE_TEXT);
            _noteTextBox.DataBindings.Add(TEXT_ATTRIBUTE_NAME, _courseManagementPresentationModel._currentCourse, NOTE_TEXT);
            _hourComboBox.DataBindings.Add(TEXT_ATTRIBUTE_NAME, _courseManagementPresentationModel._currentCourse, HOUR_TEXT);
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
            _courseManagementPresentationModel.HandleTextChanged(COURSE_ID_TEXT, _courseIdTextBox.Text);
        }

        /// <summary>
        /// 項目更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangedCourseNameTextBoxText(object sender, EventArgs e)
        {
            _courseManagementPresentationModel.HandleTextChanged(COURSE_NAME_TEXT, _courseNameTextBox.Text);
        }

        /// <summary>
        /// 項目更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangedStageTextBoxText(object sender, EventArgs e)
        {
            _courseManagementPresentationModel.HandleTextChanged(STAGE_TEXT, _stageTextBox.Text);
        }

        /// <summary>
        /// 項目更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangedCreditTextBoxText(object sender, EventArgs e)
        {
            _courseManagementPresentationModel.HandleTextChanged(CREDIT_TEXT, _creditTextBox.Text);
        }

        /// <summary>
        /// 項目更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangedTeacherTextBoxText(object sender, EventArgs e)
        {
            _courseManagementPresentationModel.HandleTextChanged(TEACHER_TEXT, _teacherTextBox.Text);
        }

        /// <summary>
        /// 項目更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangedTeachingAssistantTextBoxText(object sender, EventArgs e)
        {
            _courseManagementPresentationModel.HandleTextChanged(TEACHING_ASSISTANT_TEXT, _teachingAssistantTextBox.Text);
        }

        /// <summary>
        /// 項目更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangedLanguageTextBoxText(object sender, EventArgs e)
        {
            _courseManagementPresentationModel.HandleTextChanged(LANGUAGE_TEXT, _languageTextBox.Text);
        }

        /// <summary>
        /// 項目更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangedNoteTextBoxText(object sender, EventArgs e)
        {
            _courseManagementPresentationModel.HandleTextChanged(NOTE_TEXT, _noteTextBox.Text);
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
            _courseManagementPresentationModel.HandleTextChanged(NECESSITY_TEXT, _noteTextBox.Text);
        }

        /// <summary>
        /// 項目更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangedHourComboBoxText(object sender, EventArgs e)
        {
            _courseManagementPresentationModel.HandleTextChanged(HOUR_TEXT, _hourComboBox.Text);
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
