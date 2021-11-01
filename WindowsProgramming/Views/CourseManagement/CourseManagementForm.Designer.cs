
namespace CourseApplication.Views.CourseManagement
{
    partial class CourseManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._courseManageTabControl = new System.Windows.Forms.TabControl();
            this._courseManagementTabPage = new System.Windows.Forms.TabPage();
            this._courseManageLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._allCourseListBox = new System.Windows.Forms.ListBox();
            this._addNewCourseButton = new System.Windows.Forms.Button();
            this._courseManageSaveButton = new System.Windows.Forms.Button();
            this._courseManageGroupBox = new System.Windows.Forms.GroupBox();
            this._courseDetailLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._hourLabel = new System.Windows.Forms.Label();
            this._noteLabel = new System.Windows.Forms.Label();
            this._teachingAssistantLabel = new System.Windows.Forms.Label();
            this._stageLabel = new System.Windows.Forms.Label();
            this._classLabel = new System.Windows.Forms.Label();
            this._courseIdLabel = new System.Windows.Forms.Label();
            this._creditLabel = new System.Windows.Forms.Label();
            this._courseNameLabel = new System.Windows.Forms.Label();
            this._teacherLabel = new System.Windows.Forms.Label();
            this._languageLabel = new System.Windows.Forms.Label();
            this._necessityLabel = new System.Windows.Forms.Label();
            this._courseStatusComboBox = new System.Windows.Forms.ComboBox();
            this._hourComboBox = new System.Windows.Forms.ComboBox();
            this._classComboBox = new System.Windows.Forms.ComboBox();
            this._necessityComboBox = new System.Windows.Forms.ComboBox();
            this._courseIdTextBox = new System.Windows.Forms.TextBox();
            this._courseNameTextBox = new System.Windows.Forms.TextBox();
            this._stageTextBox = new System.Windows.Forms.TextBox();
            this._creditTextBox = new System.Windows.Forms.TextBox();
            this._teacherTextBox = new System.Windows.Forms.TextBox();
            this._teachingAssistantTextBox = new System.Windows.Forms.TextBox();
            this._noteTextBox = new System.Windows.Forms.TextBox();
            this._languageTextBox = new System.Windows.Forms.TextBox();
            this._courseTimeDataGridView = new System.Windows.Forms.DataGridView();
            this._coursePeriodTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._sundayCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._mondayCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._tuesdayCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._wednesdayCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._thursdayCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._fridayCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._saturdayCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._classManagementTabPage = new System.Windows.Forms.TabPage();
            this._courseManageTabControl.SuspendLayout();
            this._courseManagementTabPage.SuspendLayout();
            this._courseManageLayoutPanel.SuspendLayout();
            this._courseManageGroupBox.SuspendLayout();
            this._courseDetailLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._courseTimeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _courseManageTabControl
            // 
            this._courseManageTabControl.Controls.Add(this._courseManagementTabPage);
            this._courseManageTabControl.Controls.Add(this._classManagementTabPage);
            this._courseManageTabControl.Location = new System.Drawing.Point(13, 13);
            this._courseManageTabControl.Name = "_courseManageTabControl";
            this._courseManageTabControl.SelectedIndex = 0;
            this._courseManageTabControl.Size = new System.Drawing.Size(1038, 564);
            this._courseManageTabControl.TabIndex = 0;
            // 
            // _courseManagementTabPage
            // 
            this._courseManagementTabPage.Controls.Add(this._courseManageLayoutPanel);
            this._courseManagementTabPage.Location = new System.Drawing.Point(4, 22);
            this._courseManagementTabPage.Name = "_courseManagementTabPage";
            this._courseManagementTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._courseManagementTabPage.Size = new System.Drawing.Size(1030, 538);
            this._courseManagementTabPage.TabIndex = 0;
            this._courseManagementTabPage.Text = "課程管理";
            this._courseManagementTabPage.UseVisualStyleBackColor = true;
            // 
            // _courseManageLayoutPanel
            // 
            this._courseManageLayoutPanel.ColumnCount = 3;
            this._courseManageLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._courseManageLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this._courseManageLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._courseManageLayoutPanel.Controls.Add(this._allCourseListBox, 0, 0);
            this._courseManageLayoutPanel.Controls.Add(this._addNewCourseButton, 0, 1);
            this._courseManageLayoutPanel.Controls.Add(this._courseManageSaveButton, 2, 1);
            this._courseManageLayoutPanel.Controls.Add(this._courseManageGroupBox, 1, 0);
            this._courseManageLayoutPanel.Location = new System.Drawing.Point(7, 7);
            this._courseManageLayoutPanel.Name = "_courseManageLayoutPanel";
            this._courseManageLayoutPanel.RowCount = 2;
            this._courseManageLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this._courseManageLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._courseManageLayoutPanel.Size = new System.Drawing.Size(1017, 525);
            this._courseManageLayoutPanel.TabIndex = 0;
            // 
            // _allCourseListBox
            // 
            this._allCourseListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._allCourseListBox.FormattingEnabled = true;
            this._allCourseListBox.ItemHeight = 12;
            this._allCourseListBox.Location = new System.Drawing.Point(3, 3);
            this._allCourseListBox.Name = "_allCourseListBox";
            this._allCourseListBox.Size = new System.Drawing.Size(248, 414);
            this._allCourseListBox.TabIndex = 0;
            this._allCourseListBox.SelectedIndexChanged += new System.EventHandler(this.ChangedAllCourseListBoxSelectedIndex);
            // 
            // _addNewCourseButton
            // 
            this._addNewCourseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addNewCourseButton.Location = new System.Drawing.Point(3, 423);
            this._addNewCourseButton.Name = "_addNewCourseButton";
            this._addNewCourseButton.Size = new System.Drawing.Size(248, 99);
            this._addNewCourseButton.TabIndex = 1;
            this._addNewCourseButton.Text = "新增課程";
            this._addNewCourseButton.UseVisualStyleBackColor = true;
            this._addNewCourseButton.Click += new System.EventHandler(this.ClickAddNewCourseButtonEvent);
            // 
            // _courseManageSaveButton
            // 
            this._courseManageSaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._courseManageSaveButton.Enabled = false;
            this._courseManageSaveButton.Location = new System.Drawing.Point(867, 423);
            this._courseManageSaveButton.Name = "_courseManageSaveButton";
            this._courseManageSaveButton.Size = new System.Drawing.Size(147, 99);
            this._courseManageSaveButton.TabIndex = 2;
            this._courseManageSaveButton.Text = "儲存";
            this._courseManageSaveButton.UseVisualStyleBackColor = true;
            this._courseManageSaveButton.Click += new System.EventHandler(this.ClickCourseManageSaveButtonEvent);
            // 
            // _courseManageGroupBox
            // 
            this._courseManageLayoutPanel.SetColumnSpan(this._courseManageGroupBox, 2);
            this._courseManageGroupBox.Controls.Add(this._courseDetailLayoutPanel);
            this._courseManageGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._courseManageGroupBox.Location = new System.Drawing.Point(257, 3);
            this._courseManageGroupBox.Name = "_courseManageGroupBox";
            this._courseManageGroupBox.Size = new System.Drawing.Size(757, 414);
            this._courseManageGroupBox.TabIndex = 3;
            this._courseManageGroupBox.TabStop = false;
            this._courseManageGroupBox.Text = "編輯課程";
            // 
            // _courseDetailLayoutPanel
            // 
            this._courseDetailLayoutPanel.ColumnCount = 8;
            this._courseDetailLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._courseDetailLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._courseDetailLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._courseDetailLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._courseDetailLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._courseDetailLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._courseDetailLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._courseDetailLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._courseDetailLayoutPanel.Controls.Add(this._hourLabel, 0, 4);
            this._courseDetailLayoutPanel.Controls.Add(this._noteLabel, 0, 3);
            this._courseDetailLayoutPanel.Controls.Add(this._teachingAssistantLabel, 0, 2);
            this._courseDetailLayoutPanel.Controls.Add(this._stageLabel, 0, 1);
            this._courseDetailLayoutPanel.Controls.Add(this._classLabel, 2, 4);
            this._courseDetailLayoutPanel.Controls.Add(this._courseIdLabel, 2, 0);
            this._courseDetailLayoutPanel.Controls.Add(this._creditLabel, 2, 1);
            this._courseDetailLayoutPanel.Controls.Add(this._courseNameLabel, 4, 0);
            this._courseDetailLayoutPanel.Controls.Add(this._teacherLabel, 4, 1);
            this._courseDetailLayoutPanel.Controls.Add(this._languageLabel, 4, 2);
            this._courseDetailLayoutPanel.Controls.Add(this._necessityLabel, 6, 1);
            this._courseDetailLayoutPanel.Controls.Add(this._courseStatusComboBox, 0, 0);
            this._courseDetailLayoutPanel.Controls.Add(this._hourComboBox, 1, 4);
            this._courseDetailLayoutPanel.Controls.Add(this._classComboBox, 3, 4);
            this._courseDetailLayoutPanel.Controls.Add(this._necessityComboBox, 7, 1);
            this._courseDetailLayoutPanel.Controls.Add(this._courseIdTextBox, 3, 0);
            this._courseDetailLayoutPanel.Controls.Add(this._courseNameTextBox, 5, 0);
            this._courseDetailLayoutPanel.Controls.Add(this._stageTextBox, 1, 1);
            this._courseDetailLayoutPanel.Controls.Add(this._creditTextBox, 3, 1);
            this._courseDetailLayoutPanel.Controls.Add(this._teacherTextBox, 5, 1);
            this._courseDetailLayoutPanel.Controls.Add(this._teachingAssistantTextBox, 1, 2);
            this._courseDetailLayoutPanel.Controls.Add(this._noteTextBox, 1, 3);
            this._courseDetailLayoutPanel.Controls.Add(this._languageTextBox, 5, 2);
            this._courseDetailLayoutPanel.Controls.Add(this._courseTimeDataGridView, 0, 5);
            this._courseDetailLayoutPanel.Location = new System.Drawing.Point(7, 22);
            this._courseDetailLayoutPanel.Name = "_courseDetailLayoutPanel";
            this._courseDetailLayoutPanel.RowCount = 6;
            this._courseDetailLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._courseDetailLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._courseDetailLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._courseDetailLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._courseDetailLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._courseDetailLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._courseDetailLayoutPanel.Size = new System.Drawing.Size(744, 386);
            this._courseDetailLayoutPanel.TabIndex = 0;
            // 
            // _hourLabel
            // 
            this._hourLabel.AutoSize = true;
            this._hourLabel.Location = new System.Drawing.Point(3, 152);
            this._hourLabel.Name = "_hourLabel";
            this._hourLabel.Size = new System.Drawing.Size(43, 12);
            this._hourLabel.TabIndex = 0;
            this._hourLabel.Text = "時數(*)";
            // 
            // _noteLabel
            // 
            this._noteLabel.AutoSize = true;
            this._noteLabel.Location = new System.Drawing.Point(3, 114);
            this._noteLabel.Name = "_noteLabel";
            this._noteLabel.Size = new System.Drawing.Size(29, 12);
            this._noteLabel.TabIndex = 1;
            this._noteLabel.Text = "備註";
            // 
            // _teachingAssistantLabel
            // 
            this._teachingAssistantLabel.AutoSize = true;
            this._teachingAssistantLabel.Location = new System.Drawing.Point(3, 76);
            this._teachingAssistantLabel.Name = "_teachingAssistantLabel";
            this._teachingAssistantLabel.Size = new System.Drawing.Size(53, 12);
            this._teachingAssistantLabel.TabIndex = 2;
            this._teachingAssistantLabel.Text = "教學助理";
            // 
            // _stageLabel
            // 
            this._stageLabel.AutoSize = true;
            this._stageLabel.Location = new System.Drawing.Point(3, 38);
            this._stageLabel.Name = "_stageLabel";
            this._stageLabel.Size = new System.Drawing.Size(43, 12);
            this._stageLabel.TabIndex = 3;
            this._stageLabel.Text = "階段(*)";
            // 
            // _classLabel
            // 
            this._classLabel.AutoSize = true;
            this._classLabel.Location = new System.Drawing.Point(188, 152);
            this._classLabel.Name = "_classLabel";
            this._classLabel.Size = new System.Drawing.Size(43, 12);
            this._classLabel.TabIndex = 4;
            this._classLabel.Text = "班級(*)";
            // 
            // _courseIdLabel
            // 
            this._courseIdLabel.AutoSize = true;
            this._courseIdLabel.Location = new System.Drawing.Point(188, 0);
            this._courseIdLabel.Name = "_courseIdLabel";
            this._courseIdLabel.Size = new System.Drawing.Size(43, 12);
            this._courseIdLabel.TabIndex = 5;
            this._courseIdLabel.Text = "課號(*)";
            // 
            // _creditLabel
            // 
            this._creditLabel.AutoSize = true;
            this._creditLabel.Location = new System.Drawing.Point(188, 38);
            this._creditLabel.Name = "_creditLabel";
            this._creditLabel.Size = new System.Drawing.Size(43, 12);
            this._creditLabel.TabIndex = 6;
            this._creditLabel.Text = "學分(*)";
            // 
            // _courseNameLabel
            // 
            this._courseNameLabel.AutoSize = true;
            this._courseNameLabel.Location = new System.Drawing.Point(373, 0);
            this._courseNameLabel.Name = "_courseNameLabel";
            this._courseNameLabel.Size = new System.Drawing.Size(67, 12);
            this._courseNameLabel.TabIndex = 7;
            this._courseNameLabel.Text = "課程名稱(*)";
            // 
            // _teacherLabel
            // 
            this._teacherLabel.AutoSize = true;
            this._teacherLabel.Location = new System.Drawing.Point(373, 38);
            this._teacherLabel.Name = "_teacherLabel";
            this._teacherLabel.Size = new System.Drawing.Size(43, 12);
            this._teacherLabel.TabIndex = 8;
            this._teacherLabel.Text = "教師(*)";
            // 
            // _languageLabel
            // 
            this._languageLabel.AutoSize = true;
            this._languageLabel.Location = new System.Drawing.Point(373, 76);
            this._languageLabel.Name = "_languageLabel";
            this._languageLabel.Size = new System.Drawing.Size(53, 12);
            this._languageLabel.TabIndex = 9;
            this._languageLabel.Text = "授課語言";
            // 
            // _necessityLabel
            // 
            this._necessityLabel.AutoSize = true;
            this._necessityLabel.Location = new System.Drawing.Point(558, 38);
            this._necessityLabel.Name = "_necessityLabel";
            this._necessityLabel.Size = new System.Drawing.Size(31, 12);
            this._necessityLabel.TabIndex = 10;
            this._necessityLabel.Text = "修(*)";
            // 
            // _courseStatusComboBox
            // 
            this._courseDetailLayoutPanel.SetColumnSpan(this._courseStatusComboBox, 2);
            this._courseStatusComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._courseStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._courseStatusComboBox.Enabled = false;
            this._courseStatusComboBox.FormattingEnabled = true;
            this._courseStatusComboBox.Items.AddRange(new object[] {
            "開課",
            "停開"});
            this._courseStatusComboBox.Location = new System.Drawing.Point(3, 3);
            this._courseStatusComboBox.Name = "_courseStatusComboBox";
            this._courseStatusComboBox.Size = new System.Drawing.Size(179, 20);
            this._courseStatusComboBox.TabIndex = 11;
            this._courseStatusComboBox.TextChanged += new System.EventHandler(this.ChangedCourseStatusComboBoxText);
            // 
            // _hourComboBox
            // 
            this._hourComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._hourComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._hourComboBox.Enabled = false;
            this._hourComboBox.FormattingEnabled = true;
            this._hourComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this._hourComboBox.Location = new System.Drawing.Point(77, 155);
            this._hourComboBox.Name = "_hourComboBox";
            this._hourComboBox.Size = new System.Drawing.Size(105, 20);
            this._hourComboBox.TabIndex = 12;
            this._hourComboBox.TextChanged += new System.EventHandler(this.ChangedHourComboBoxText);
            // 
            // _classComboBox
            // 
            this._classComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._classComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._classComboBox.Enabled = false;
            this._classComboBox.FormattingEnabled = true;
            this._classComboBox.Items.AddRange(new object[] {
            "資工三",
            "電子三甲"});
            this._classComboBox.Location = new System.Drawing.Point(262, 155);
            this._classComboBox.Name = "_classComboBox";
            this._classComboBox.Size = new System.Drawing.Size(105, 20);
            this._classComboBox.TabIndex = 13;
            this._classComboBox.TextChanged += new System.EventHandler(this.ChangedClassComboBoxText);
            // 
            // _necessityComboBox
            // 
            this._necessityComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._necessityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._necessityComboBox.Enabled = false;
            this._necessityComboBox.FormattingEnabled = true;
            this._necessityComboBox.Items.AddRange(new object[] {
            "○",
            "△",
            "☆",
            "●",
            "▲",
            "★"});
            this._necessityComboBox.Location = new System.Drawing.Point(632, 41);
            this._necessityComboBox.Name = "_necessityComboBox";
            this._necessityComboBox.Size = new System.Drawing.Size(109, 20);
            this._necessityComboBox.TabIndex = 14;
            this._necessityComboBox.TextChanged += new System.EventHandler(this.ChangedNecessityComboBoxText);
            // 
            // _courseIdTextBox
            // 
            this._courseIdTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._courseIdTextBox.Enabled = false;
            this._courseIdTextBox.Location = new System.Drawing.Point(262, 3);
            this._courseIdTextBox.Name = "_courseIdTextBox";
            this._courseIdTextBox.Size = new System.Drawing.Size(105, 22);
            this._courseIdTextBox.TabIndex = 15;
            this._courseIdTextBox.TextChanged += new System.EventHandler(this.ChangedCourseIdTextBoxText);
            // 
            // _courseNameTextBox
            // 
            this._courseDetailLayoutPanel.SetColumnSpan(this._courseNameTextBox, 3);
            this._courseNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._courseNameTextBox.Enabled = false;
            this._courseNameTextBox.Location = new System.Drawing.Point(447, 3);
            this._courseNameTextBox.Name = "_courseNameTextBox";
            this._courseNameTextBox.Size = new System.Drawing.Size(294, 22);
            this._courseNameTextBox.TabIndex = 16;
            this._courseNameTextBox.TextChanged += new System.EventHandler(this.ChangedCourseNameTextBoxText);
            // 
            // _stageTextBox
            // 
            this._stageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._stageTextBox.Enabled = false;
            this._stageTextBox.Location = new System.Drawing.Point(77, 41);
            this._stageTextBox.Name = "_stageTextBox";
            this._stageTextBox.Size = new System.Drawing.Size(105, 22);
            this._stageTextBox.TabIndex = 17;
            this._stageTextBox.TextChanged += new System.EventHandler(this.ChangedStageTextBoxText);
            // 
            // _creditTextBox
            // 
            this._creditTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._creditTextBox.Enabled = false;
            this._creditTextBox.Location = new System.Drawing.Point(262, 41);
            this._creditTextBox.Name = "_creditTextBox";
            this._creditTextBox.Size = new System.Drawing.Size(105, 22);
            this._creditTextBox.TabIndex = 18;
            this._creditTextBox.TextChanged += new System.EventHandler(this.ChangedCreditTextBoxText);
            // 
            // _teacherTextBox
            // 
            this._teacherTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._teacherTextBox.Enabled = false;
            this._teacherTextBox.Location = new System.Drawing.Point(447, 41);
            this._teacherTextBox.Name = "_teacherTextBox";
            this._teacherTextBox.Size = new System.Drawing.Size(105, 22);
            this._teacherTextBox.TabIndex = 19;
            this._teacherTextBox.TextChanged += new System.EventHandler(this.ChangedTeacherTextBoxText);
            // 
            // _teachingAssistantTextBox
            // 
            this._courseDetailLayoutPanel.SetColumnSpan(this._teachingAssistantTextBox, 3);
            this._teachingAssistantTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._teachingAssistantTextBox.Enabled = false;
            this._teachingAssistantTextBox.Location = new System.Drawing.Point(77, 79);
            this._teachingAssistantTextBox.Name = "_teachingAssistantTextBox";
            this._teachingAssistantTextBox.Size = new System.Drawing.Size(290, 22);
            this._teachingAssistantTextBox.TabIndex = 20;
            this._teachingAssistantTextBox.TextChanged += new System.EventHandler(this.ChangedTeachingAssistantTextBoxText);
            // 
            // _noteTextBox
            // 
            this._courseDetailLayoutPanel.SetColumnSpan(this._noteTextBox, 7);
            this._noteTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._noteTextBox.Enabled = false;
            this._noteTextBox.Location = new System.Drawing.Point(77, 117);
            this._noteTextBox.Name = "_noteTextBox";
            this._noteTextBox.Size = new System.Drawing.Size(664, 22);
            this._noteTextBox.TabIndex = 21;
            this._noteTextBox.TextChanged += new System.EventHandler(this.ChangedNoteTextBoxText);
            // 
            // _languageTextBox
            // 
            this._courseDetailLayoutPanel.SetColumnSpan(this._languageTextBox, 3);
            this._languageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._languageTextBox.Enabled = false;
            this._languageTextBox.Location = new System.Drawing.Point(447, 79);
            this._languageTextBox.Name = "_languageTextBox";
            this._languageTextBox.Size = new System.Drawing.Size(294, 22);
            this._languageTextBox.TabIndex = 22;
            this._languageTextBox.TextChanged += new System.EventHandler(this.ChangedLanguageTextBoxText);
            // 
            // _courseTimeDataGridView
            // 
            this._courseTimeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._courseTimeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._coursePeriodTextBoxColumn,
            this._sundayCheckBoxColumn,
            this._mondayCheckBoxColumn,
            this._tuesdayCheckBoxColumn,
            this._wednesdayCheckBoxColumn,
            this._thursdayCheckBoxColumn,
            this._fridayCheckBoxColumn,
            this._saturdayCheckBoxColumn});
            this._courseDetailLayoutPanel.SetColumnSpan(this._courseTimeDataGridView, 8);
            this._courseTimeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._courseTimeDataGridView.Location = new System.Drawing.Point(3, 193);
            this._courseTimeDataGridView.Name = "_courseTimeDataGridView";
            this._courseTimeDataGridView.RowTemplate.Height = 24;
            this._courseTimeDataGridView.Size = new System.Drawing.Size(738, 190);
            this._courseTimeDataGridView.TabIndex = 23;
            // 
            // _coursePeriodTextBoxColumn
            // 
            this._coursePeriodTextBoxColumn.DataPropertyName = "Index";
            this._coursePeriodTextBoxColumn.HeaderText = "節數";
            this._coursePeriodTextBoxColumn.Name = "_coursePeriodTextBoxColumn";
            // 
            // _sundayCheckBoxColumn
            // 
            this._sundayCheckBoxColumn.DataPropertyName = "Sunday";
            this._sundayCheckBoxColumn.FalseValue = "False";
            this._sundayCheckBoxColumn.HeaderText = "日";
            this._sundayCheckBoxColumn.Name = "_sundayCheckBoxColumn";
            this._sundayCheckBoxColumn.TrueValue = "True";
            // 
            // _mondayCheckBoxColumn
            // 
            this._mondayCheckBoxColumn.DataPropertyName = "Monday";
            this._mondayCheckBoxColumn.FalseValue = "False";
            this._mondayCheckBoxColumn.HeaderText = "一";
            this._mondayCheckBoxColumn.Name = "_mondayCheckBoxColumn";
            this._mondayCheckBoxColumn.TrueValue = "True";
            // 
            // _tuesdayCheckBoxColumn
            // 
            this._tuesdayCheckBoxColumn.DataPropertyName = "Tuesday";
            this._tuesdayCheckBoxColumn.FalseValue = "False";
            this._tuesdayCheckBoxColumn.HeaderText = "二";
            this._tuesdayCheckBoxColumn.Name = "_tuesdayCheckBoxColumn";
            this._tuesdayCheckBoxColumn.TrueValue = "True";
            // 
            // _wednesdayCheckBoxColumn
            // 
            this._wednesdayCheckBoxColumn.DataPropertyName = "Wednesday";
            this._wednesdayCheckBoxColumn.FalseValue = "False";
            this._wednesdayCheckBoxColumn.HeaderText = "三";
            this._wednesdayCheckBoxColumn.Name = "_wednesdayCheckBoxColumn";
            this._wednesdayCheckBoxColumn.TrueValue = "True";
            // 
            // _thursdayCheckBoxColumn
            // 
            this._thursdayCheckBoxColumn.DataPropertyName = "Thursday";
            this._thursdayCheckBoxColumn.FalseValue = "False";
            this._thursdayCheckBoxColumn.HeaderText = "四";
            this._thursdayCheckBoxColumn.Name = "_thursdayCheckBoxColumn";
            this._thursdayCheckBoxColumn.TrueValue = "True";
            // 
            // _fridayCheckBoxColumn
            // 
            this._fridayCheckBoxColumn.DataPropertyName = "Friday";
            this._fridayCheckBoxColumn.FalseValue = "False";
            this._fridayCheckBoxColumn.HeaderText = "五";
            this._fridayCheckBoxColumn.Name = "_fridayCheckBoxColumn";
            this._fridayCheckBoxColumn.TrueValue = "True";
            // 
            // _saturdayCheckBoxColumn
            // 
            this._saturdayCheckBoxColumn.DataPropertyName = "Saturday";
            this._saturdayCheckBoxColumn.FalseValue = "False";
            this._saturdayCheckBoxColumn.HeaderText = "六";
            this._saturdayCheckBoxColumn.Name = "_saturdayCheckBoxColumn";
            this._saturdayCheckBoxColumn.TrueValue = "True";
            // 
            // _classManagementTabPage
            // 
            this._classManagementTabPage.Location = new System.Drawing.Point(4, 22);
            this._classManagementTabPage.Name = "_classManagementTabPage";
            this._classManagementTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._classManagementTabPage.Size = new System.Drawing.Size(1030, 538);
            this._classManagementTabPage.TabIndex = 1;
            this._classManagementTabPage.Text = "班級管理";
            this._classManagementTabPage.UseVisualStyleBackColor = true;
            // 
            // CourseManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 589);
            this.Controls.Add(this._courseManageTabControl);
            this.Name = "CourseManagementForm";
            this.Text = "CourseManagementForm";
            this._courseManageTabControl.ResumeLayout(false);
            this._courseManagementTabPage.ResumeLayout(false);
            this._courseManageLayoutPanel.ResumeLayout(false);
            this._courseManageGroupBox.ResumeLayout(false);
            this._courseDetailLayoutPanel.ResumeLayout(false);
            this._courseDetailLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._courseTimeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _courseManageTabControl;
        private System.Windows.Forms.TabPage _courseManagementTabPage;
        private System.Windows.Forms.TabPage _classManagementTabPage;
        private System.Windows.Forms.TableLayoutPanel _courseManageLayoutPanel;
        private System.Windows.Forms.ListBox _allCourseListBox;
        private System.Windows.Forms.Button _addNewCourseButton;
        private System.Windows.Forms.Button _courseManageSaveButton;
        private System.Windows.Forms.GroupBox _courseManageGroupBox;
        private System.Windows.Forms.TableLayoutPanel _courseDetailLayoutPanel;
        private System.Windows.Forms.Label _hourLabel;
        private System.Windows.Forms.Label _noteLabel;
        private System.Windows.Forms.Label _teachingAssistantLabel;
        private System.Windows.Forms.Label _stageLabel;
        private System.Windows.Forms.Label _classLabel;
        private System.Windows.Forms.Label _courseIdLabel;
        private System.Windows.Forms.Label _creditLabel;
        private System.Windows.Forms.Label _courseNameLabel;
        private System.Windows.Forms.Label _teacherLabel;
        private System.Windows.Forms.Label _languageLabel;
        private System.Windows.Forms.Label _necessityLabel;
        private System.Windows.Forms.ComboBox _courseStatusComboBox;
        private System.Windows.Forms.ComboBox _hourComboBox;
        private System.Windows.Forms.ComboBox _classComboBox;
        private System.Windows.Forms.ComboBox _necessityComboBox;
        private System.Windows.Forms.TextBox _courseIdTextBox;
        private System.Windows.Forms.TextBox _courseNameTextBox;
        private System.Windows.Forms.TextBox _stageTextBox;
        private System.Windows.Forms.TextBox _creditTextBox;
        private System.Windows.Forms.TextBox _teacherTextBox;
        private System.Windows.Forms.TextBox _teachingAssistantTextBox;
        private System.Windows.Forms.TextBox _noteTextBox;
        private System.Windows.Forms.TextBox _languageTextBox;
        private System.Windows.Forms.DataGridView _courseTimeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn _coursePeriodTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _sundayCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _mondayCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _tuesdayCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _wednesdayCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _thursdayCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _fridayCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _saturdayCheckBoxColumn;
    }
}