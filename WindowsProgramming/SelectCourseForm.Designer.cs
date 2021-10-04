
namespace CourseApplication
{
    partial class SelectCourseForm
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this._tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._courseSelectGridView = new System.Windows.Forms.DataGridView();
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
            this._WednesdayTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._thursdayTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._fridayTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._saturdayTextbox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._classroomTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._numberOfStudentsTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._numberOfDropStudentsTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._teachingAssistantTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._languageTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._syllabusTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._noteTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._auditTextbox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._experimentTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseSubmitButton = new System.Windows.Forms.Button();
            this._courseCheckResultButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._courseSelectGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _tableLayoutPanel1
            // 
            this._tableLayoutPanel1.AutoSize = true;
            this._tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._tableLayoutPanel1.ColumnCount = 3;
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._tableLayoutPanel1.Controls.Add(this._courseSelectGridView, 0, 0);
            this._tableLayoutPanel1.Controls.Add(this._courseSubmitButton, 1, 1);
            this._tableLayoutPanel1.Controls.Add(this._courseCheckResultButton, 2, 1);
            this._tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel1.Name = "_tableLayoutPanel1";
            this._tableLayoutPanel1.RowCount = 2;
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._tableLayoutPanel1.Size = new System.Drawing.Size(1158, 619);
            this._tableLayoutPanel1.TabIndex = 0;
            // 
            // _courseSelectGridView
            // 
            this._courseSelectGridView.AllowUserToAddRows = false;
            this._courseSelectGridView.AllowUserToDeleteRows = false;
            this._courseSelectGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this._courseSelectGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._courseSelectGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this._WednesdayTextBox,
            this._thursdayTextBox,
            this._fridayTextBox,
            this._saturdayTextbox,
            this._classroomTextBox,
            this._numberOfStudentsTextBox,
            this._numberOfDropStudentsTextBox,
            this._teachingAssistantTextBox,
            this._languageTextBox,
            this._syllabusTextBox,
            this._noteTextBox,
            this._auditTextbox,
            this._experimentTextBox});
            this._tableLayoutPanel1.SetColumnSpan(this._courseSelectGridView, 3);
            this._courseSelectGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._courseSelectGridView.Location = new System.Drawing.Point(3, 3);
            this._courseSelectGridView.Name = "_courseSelectGridView";
            this._courseSelectGridView.ReadOnly = true;
            this._courseSelectGridView.RowTemplate.Height = 24;
            this._courseSelectGridView.Size = new System.Drawing.Size(1152, 520);
            this._courseSelectGridView.TabIndex = 0;
            // 
            // _courseSelectCheckBox
            // 
            this._courseSelectCheckBox.DataPropertyName = "IsCourseSelected";
            this._courseSelectCheckBox.FalseValue = "false";
            this._courseSelectCheckBox.HeaderText = "選擇";
            this._courseSelectCheckBox.Name = "_courseSelectCheckBox";
            this._courseSelectCheckBox.ReadOnly = true;
            this._courseSelectCheckBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._courseSelectCheckBox.TrueValue = "true";
            this._courseSelectCheckBox.Width = 32;
            // 
            // _courseIdTextBox
            // 
            this._courseIdTextBox.DataPropertyName = "Course.CourseId";
            this._courseIdTextBox.HeaderText = "課號";
            this._courseIdTextBox.Name = "_courseIdTextBox";
            this._courseIdTextBox.ReadOnly = true;
            this._courseIdTextBox.Width = 51;
            // 
            // _classNameTextBox
            // 
            this._classNameTextBox.DataPropertyName = "Course.CourseName";
            this._classNameTextBox.HeaderText = "課程名稱";
            this._classNameTextBox.Name = "_classNameTextBox";
            this._classNameTextBox.ReadOnly = true;
            this._classNameTextBox.Width = 61;
            // 
            // _stageTextBox
            // 
            this._stageTextBox.DataPropertyName = "Course.Stage";
            this._stageTextBox.HeaderText = "階段";
            this._stageTextBox.Name = "_stageTextBox";
            this._stageTextBox.ReadOnly = true;
            this._stageTextBox.Width = 51;
            // 
            // _creditTextBox
            // 
            this._creditTextBox.DataPropertyName = "Course.Credit";
            this._creditTextBox.HeaderText = "學分數";
            this._creditTextBox.Name = "_creditTextBox";
            this._creditTextBox.ReadOnly = true;
            this._creditTextBox.Width = 61;
            // 
            // _hourTextBox
            // 
            this._hourTextBox.DataPropertyName = "Course.Hour";
            this._hourTextBox.HeaderText = "時數";
            this._hourTextBox.Name = "_hourTextBox";
            this._hourTextBox.ReadOnly = true;
            this._hourTextBox.Width = 51;
            // 
            // _necessityTextBox
            // 
            this._necessityTextBox.DataPropertyName = "Course.Necessity";
            this._necessityTextBox.HeaderText = "選必修";
            this._necessityTextBox.Name = "_necessityTextBox";
            this._necessityTextBox.ReadOnly = true;
            this._necessityTextBox.Width = 61;
            // 
            // _teacherTextBox
            // 
            this._teacherTextBox.DataPropertyName = "Course.Teacher";
            this._teacherTextBox.HeaderText = "教師";
            this._teacherTextBox.Name = "_teacherTextBox";
            this._teacherTextBox.ReadOnly = true;
            this._teacherTextBox.Width = 51;
            // 
            // _sundayTextBox
            // 
            this._sundayTextBox.DataPropertyName = "Course.CourseTime.Sunday";
            this._sundayTextBox.HeaderText = "日";
            this._sundayTextBox.Name = "_sundayTextBox";
            this._sundayTextBox.ReadOnly = true;
            this._sundayTextBox.Width = 42;
            // 
            // _mondayTextBox
            // 
            this._mondayTextBox.DataPropertyName = "Course.CourseTime.Monday";
            this._mondayTextBox.HeaderText = "一";
            this._mondayTextBox.Name = "_mondayTextBox";
            this._mondayTextBox.ReadOnly = true;
            this._mondayTextBox.Width = 42;
            // 
            // _tuesdayTextBox
            // 
            this._tuesdayTextBox.DataPropertyName = "Course.CourseTime.Tuesday";
            this._tuesdayTextBox.HeaderText = "二";
            this._tuesdayTextBox.Name = "_tuesdayTextBox";
            this._tuesdayTextBox.ReadOnly = true;
            this._tuesdayTextBox.Width = 42;
            // 
            // _WednesdayTextBox
            // 
            this._WednesdayTextBox.DataPropertyName = "Course.CourseTime.Wednesday";
            this._WednesdayTextBox.HeaderText = "三";
            this._WednesdayTextBox.Name = "_WednesdayTextBox";
            this._WednesdayTextBox.ReadOnly = true;
            this._WednesdayTextBox.Width = 42;
            // 
            // _thursdayTextBox
            // 
            this._thursdayTextBox.DataPropertyName = "Course.CourseTime.Thursday";
            this._thursdayTextBox.HeaderText = "四";
            this._thursdayTextBox.Name = "_thursdayTextBox";
            this._thursdayTextBox.ReadOnly = true;
            this._thursdayTextBox.Width = 42;
            // 
            // _fridayTextBox
            // 
            this._fridayTextBox.DataPropertyName = "Course.CourseTime.Friday";
            this._fridayTextBox.HeaderText = "五";
            this._fridayTextBox.Name = "_fridayTextBox";
            this._fridayTextBox.ReadOnly = true;
            this._fridayTextBox.Width = 42;
            // 
            // _saturdayTextbox
            // 
            this._saturdayTextbox.DataPropertyName = "Course.CourseTime.Saturday";
            this._saturdayTextbox.HeaderText = "六";
            this._saturdayTextbox.Name = "_saturdayTextbox";
            this._saturdayTextbox.ReadOnly = true;
            this._saturdayTextbox.Width = 42;
            // 
            // _classroomTextBox
            // 
            this._classroomTextBox.DataPropertyName = "Course.Classroom";
            this._classroomTextBox.HeaderText = "教室";
            this._classroomTextBox.Name = "_classroomTextBox";
            this._classroomTextBox.ReadOnly = true;
            this._classroomTextBox.Width = 51;
            // 
            // _numberOfStudentsTextBox
            // 
            this._numberOfStudentsTextBox.DataPropertyName = "Course.NumberOfStudents";
            this._numberOfStudentsTextBox.HeaderText = "修課人數";
            this._numberOfStudentsTextBox.Name = "_numberOfStudentsTextBox";
            this._numberOfStudentsTextBox.ReadOnly = true;
            this._numberOfStudentsTextBox.Width = 61;
            // 
            // _numberOfDropStudentsTextBox
            // 
            this._numberOfDropStudentsTextBox.DataPropertyName = "Course.NumberOfDropStudents";
            this._numberOfDropStudentsTextBox.HeaderText = "撤選人數";
            this._numberOfDropStudentsTextBox.Name = "_numberOfDropStudentsTextBox";
            this._numberOfDropStudentsTextBox.ReadOnly = true;
            this._numberOfDropStudentsTextBox.Width = 61;
            // 
            // _teachingAssistantTextBox
            // 
            this._teachingAssistantTextBox.DataPropertyName = "Course.TeachingAssistant";
            this._teachingAssistantTextBox.HeaderText = "TA";
            this._teachingAssistantTextBox.Name = "_teachingAssistantTextBox";
            this._teachingAssistantTextBox.ReadOnly = true;
            this._teachingAssistantTextBox.Width = 45;
            // 
            // _languageTextBox
            // 
            this._languageTextBox.DataPropertyName = "Course.Language";
            this._languageTextBox.HeaderText = "授課語言";
            this._languageTextBox.Name = "_languageTextBox";
            this._languageTextBox.ReadOnly = true;
            this._languageTextBox.Width = 61;
            // 
            // _syllabusTextBox
            // 
            this._syllabusTextBox.DataPropertyName = "Course.Syllabus";
            this._syllabusTextBox.HeaderText = "課程大綱與進度表";
            this._syllabusTextBox.Name = "_syllabusTextBox";
            this._syllabusTextBox.ReadOnly = true;
            this._syllabusTextBox.Width = 83;
            // 
            // _noteTextBox
            // 
            this._noteTextBox.DataPropertyName = "Course.Note";
            this._noteTextBox.HeaderText = "備註";
            this._noteTextBox.Name = "_noteTextBox";
            this._noteTextBox.ReadOnly = true;
            this._noteTextBox.Width = 51;
            // 
            // _auditTextbox
            // 
            this._auditTextbox.DataPropertyName = "Course.Audit";
            this._auditTextbox.HeaderText = "隨班附讀";
            this._auditTextbox.Name = "_auditTextbox";
            this._auditTextbox.ReadOnly = true;
            this._auditTextbox.Width = 61;
            // 
            // _experimentTextBox
            // 
            this._experimentTextBox.DataPropertyName = "Course.Experiment";
            this._experimentTextBox.HeaderText = "實驗實習";
            this._experimentTextBox.Name = "_experimentTextBox";
            this._experimentTextBox.ReadOnly = true;
            this._experimentTextBox.Width = 61;
            // 
            // _courseSubmitButton
            // 
            this._courseSubmitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._courseSubmitButton.Location = new System.Drawing.Point(813, 529);
            this._courseSubmitButton.Name = "_courseSubmitButton";
            this._courseSubmitButton.Size = new System.Drawing.Size(167, 87);
            this._courseSubmitButton.TabIndex = 1;
            this._courseSubmitButton.Text = "確認送出";
            this._courseSubmitButton.UseVisualStyleBackColor = true;
            // 
            // _courseCheckResultButton
            // 
            this._courseCheckResultButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._courseCheckResultButton.Location = new System.Drawing.Point(986, 529);
            this._courseCheckResultButton.Name = "_courseCheckResultButton";
            this._courseCheckResultButton.Size = new System.Drawing.Size(169, 87);
            this._courseCheckResultButton.TabIndex = 2;
            this._courseCheckResultButton.Text = "查看選課結果";
            this._courseCheckResultButton.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Course";
            this.dataGridViewTextBoxColumn1.HeaderText = "課號";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // SelectCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1158, 619);
            this.Controls.Add(this._tableLayoutPanel1);
            this.Name = "SelectCourseForm";
            this.Text = "CourseForm";
            this._tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._courseSelectGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel1;
        private System.Windows.Forms.DataGridView _courseSelectGridView;
        private System.Windows.Forms.Button _courseSubmitButton;
        private System.Windows.Forms.Button _courseCheckResultButton;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn _WednesdayTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _thursdayTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _fridayTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _saturdayTextbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _classroomTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _numberOfStudentsTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _numberOfDropStudentsTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _teachingAssistantTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _languageTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _syllabusTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _noteTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _auditTextbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _experimentTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

