
namespace CourseApplication.Views.CourseSelecting
{
    partial class CourseSelectingDataGridComponent
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._courseSelectingDataGridView = new System.Windows.Forms.DataGridView();
            this.courseApplicationModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._courseSelectCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._courseIdTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._classNameTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._stageTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._creditTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._hourTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._necessityTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._teacherTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._sundayTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._mondayTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tuesdayTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._wednesdayTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._thursdayTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._fridayTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._saturdayTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._classroomTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._numberOfStudentsTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._numberOfDropStudentsTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._teachingAssistantTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._languageTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._syllabusTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._noteTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._auditTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._experimentTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._courseSelectingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseApplicationModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _courseSelectingDataGridView
            // 
            this._courseSelectingDataGridView.AllowUserToAddRows = false;
            this._courseSelectingDataGridView.AllowUserToDeleteRows = false;
            this._courseSelectingDataGridView.AutoGenerateColumns = false;
            this._courseSelectingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this._courseSelectingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._courseSelectCheckBox,
            this._courseIdTextBox,
            this._classNameTextBox,
            this._stageTextBox,
            this._creditTextBox,
            this._hourTextBox,
            this._necessityTextBox,
            this._teacherTextBox,
            this._sundayTextBox,
            this._mondayTextBox,
            this._tuesdayTextBox,
            this._wednesdayTextBox,
            this._thursdayTextBox,
            this._fridayTextBox,
            this._saturdayTextBox,
            this._classroomTextBox,
            this._numberOfStudentsTextBox,
            this._numberOfDropStudentsTextBox,
            this._teachingAssistantTextBox,
            this._languageTextBox,
            this._syllabusTextBox,
            this._noteTextBox,
            this._auditTextBox,
            this._experimentTextBox});
            this._courseSelectingDataGridView.DataSource = this.courseApplicationModelBindingSource;
            this._courseSelectingDataGridView.Location = new System.Drawing.Point(4, 4);
            this._courseSelectingDataGridView.Name = "_courseSelectingDataGridView";
            this._courseSelectingDataGridView.RowTemplate.Height = 24;
            this._courseSelectingDataGridView.Size = new System.Drawing.Size(972, 373);
            this._courseSelectingDataGridView.TabIndex = 0;
            // 
            // courseApplicationModelBindingSource
            // 
            this.courseApplicationModelBindingSource.DataSource = typeof(CourseApplication.Model.CourseApplicationModel);
            // 
            // _courseSelectCheckBox
            // 
            this._courseIdTextBox.DataPropertyName = "IsSelected";
            this._courseSelectCheckBox.FalseValue = "false";
            this._courseSelectCheckBox.HeaderText = "選擇";
            this._courseSelectCheckBox.Name = "_courseSelectCheckBox";
            this._courseSelectCheckBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._courseSelectCheckBox.TrueValue = "true";
            this._courseSelectCheckBox.Width = 35;
            // 
            // _courseIdTextBox
            // 
            this._courseIdTextBox.DataPropertyName = "Course.CourseId";
            this._courseIdTextBox.HeaderText = "課號";
            this._courseIdTextBox.Name = "_courseIdTextBox";
            this._courseIdTextBox.Width = 54;
            // 
            // _classNameTextBox
            // 
            this._classNameTextBox.DataPropertyName = "Course.CourseName";
            this._classNameTextBox.HeaderText = "課程名稱";
            this._classNameTextBox.Name = "_classNameTextBox";
            this._classNameTextBox.Width = 78;
            // 
            // _stageTextBox
            // 
            this._stageTextBox.DataPropertyName = "Course.Stage";
            this._stageTextBox.HeaderText = "階段";
            this._stageTextBox.Name = "_stageTextBox";
            this._stageTextBox.Width = 54;
            // 
            // _creditTextBox
            // 
            this._creditTextBox.DataPropertyName = "Course.Credit";
            this._creditTextBox.HeaderText = "學分數";
            this._creditTextBox.Name = "_creditTextBox";
            this._creditTextBox.Width = 66;
            // 
            // _hourTextBox
            // 
            this._hourTextBox.DataPropertyName = "Hour";
            this._hourTextBox.HeaderText = "時數";
            this._hourTextBox.Name = "_hourTextBox";
            this._hourTextBox.Width = 54;
            // 
            // _necessityTextBox
            // 
            this._necessityTextBox.DataPropertyName = "Course.Necessity";
            this._necessityTextBox.HeaderText = "選必修";
            this._necessityTextBox.Name = "_necessityTextBox";
            this._necessityTextBox.Width = 66;
            // 
            // _teacherTextBox
            // 
            this._teacherTextBox.DataPropertyName = "Course.Teacher";
            this._teacherTextBox.HeaderText = "教師";
            this._teacherTextBox.Name = "_teacherTextBox";
            this._teacherTextBox.Width = 54;
            // 
            // _sundayTextBox
            // 
            this._sundayTextBox.DataPropertyName = "Course.Sunday";
            this._sundayTextBox.HeaderText = "日";
            this._sundayTextBox.Name = "_sundayTextBox";
            this._sundayTextBox.Width = 42;
            // 
            // _mondayTextBox
            // 
            this._mondayTextBox.DataPropertyName = "Course.Monday";
            this._mondayTextBox.HeaderText = "一";
            this._mondayTextBox.Name = "_mondayTextBox";
            this._mondayTextBox.Width = 42;
            // 
            // _tuesdayTextBox
            // 
            this._tuesdayTextBox.DataPropertyName = "Course.Tuesday";
            this._tuesdayTextBox.HeaderText = "二";
            this._tuesdayTextBox.Name = "_tuesdayTextBox";
            this._tuesdayTextBox.Width = 42;
            // 
            // _wednesdayTextBox
            // 
            this._wednesdayTextBox.DataPropertyName = "Course.Wednesday";
            this._wednesdayTextBox.HeaderText = "三";
            this._wednesdayTextBox.Name = "_wednesdayTextBox";
            this._wednesdayTextBox.Width = 42;
            // 
            // _thursdayTextBox
            // 
            this._thursdayTextBox.DataPropertyName = "Course.Thursday";
            this._thursdayTextBox.HeaderText = "四";
            this._thursdayTextBox.Name = "_thursdayTextBox";
            this._thursdayTextBox.Width = 42;
            // 
            // _fridayTextBox
            // 
            this._fridayTextBox.DataPropertyName = "Course.Friday";
            this._fridayTextBox.HeaderText = "五";
            this._fridayTextBox.Name = "_fridayTextBox";
            this._fridayTextBox.Width = 42;
            // 
            // _saturdayTextBox
            // 
            this._saturdayTextBox.DataPropertyName = "Course.Saturday";
            this._saturdayTextBox.HeaderText = "六";
            this._saturdayTextBox.Name = "_saturdayTextBox";
            this._saturdayTextBox.Width = 42;
            // 
            // _classroomTextBox
            // 
            this._classroomTextBox.DataPropertyName = "Course.Classroom";
            this._classroomTextBox.HeaderText = "教室";
            this._classroomTextBox.Name = "_classroomTextBox";
            this._classroomTextBox.Width = 54;
            // 
            // _numberOfStudentsTextBox
            // 
            this._numberOfStudentsTextBox.DataPropertyName = "Course.NumberOfStudents";
            this._numberOfStudentsTextBox.HeaderText = "修課人數";
            this._numberOfStudentsTextBox.Name = "_numberOfStudentsTextBox";
            this._numberOfStudentsTextBox.Width = 78;
            // 
            // _numberOfDropStudentsTextBox
            // 
            this._numberOfDropStudentsTextBox.DataPropertyName = "Course.NumberOfDropStudents";
            this._numberOfDropStudentsTextBox.HeaderText = "撤選人數";
            this._numberOfDropStudentsTextBox.Name = "_numberOfDropStudentsTextBox";
            this._numberOfDropStudentsTextBox.Width = 78;
            // 
            // _teachingAssistantTextBox
            // 
            this._teachingAssistantTextBox.DataPropertyName = "Course.TeachingAssistant";
            this._teachingAssistantTextBox.HeaderText = "TA";
            this._teachingAssistantTextBox.Name = "_teachingAssistantTextBox";
            this._teachingAssistantTextBox.Width = 45;
            // 
            // _languageTextBox
            // 
            this._languageTextBox.DataPropertyName = "Course.Language";
            this._languageTextBox.HeaderText = "授課語言";
            this._languageTextBox.Name = "_languageTextBox";
            this._languageTextBox.Width = 78;
            // 
            // _syllabusTextBox
            // 
            this._syllabusTextBox.DataPropertyName = "Course.Syllabus";
            this._syllabusTextBox.HeaderText = "課程大綱與進度表";
            this._syllabusTextBox.Name = "_syllabusTextBox";
            this._syllabusTextBox.Width = 126;
            // 
            // _noteTextBox
            // 
            this._noteTextBox.DataPropertyName = "Course.Note";
            this._noteTextBox.HeaderText = "備註";
            this._noteTextBox.Name = "_noteTextBox";
            this._noteTextBox.Width = 54;
            // 
            // _auditTextBox
            // 
            this._auditTextBox.DataPropertyName = "Course.Audit";
            this._auditTextBox.HeaderText = "隨班附讀";
            this._auditTextBox.Name = "_auditTextBox";
            this._auditTextBox.Width = 78;
            // 
            // _experimentTextBox
            // 
            this._experimentTextBox.DataPropertyName = "Experiment";
            this._experimentTextBox.HeaderText = "實驗實習";
            this._experimentTextBox.Name = "_experimentTextBox";
            this._experimentTextBox.Width = 78;
            // 
            // CourseSelectingDataGridComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._courseSelectingDataGridView);
            this.Name = "CourseSelectingDataGridComponent";
            this.Size = new System.Drawing.Size(979, 382);
            ((System.ComponentModel.ISupportInitialize)(this._courseSelectingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseApplicationModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _courseSelectingDataGridView;
        private System.Windows.Forms.BindingSource courseApplicationModelBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _courseSelectCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _courseIdTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _classNameTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _stageTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _creditTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _hourTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _necessityTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _teacherTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _sundayTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _mondayTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _tuesdayTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _wednesdayTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _thursdayTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _fridayTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _saturdayTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _classroomTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _numberOfStudentsTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _numberOfDropStudentsTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _teachingAssistantTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _languageTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _syllabusTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _noteTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _auditTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _experimentTextBox;
    }
}
