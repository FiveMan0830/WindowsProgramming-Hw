
namespace CourseApplication.Views.CourseSelecting
{
    partial class CourseSelectingForm
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
            this._courseSelectingTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this._courseSelectingSubmitButton = new System.Windows.Forms.Button();
            this._courseSelectionResultButton = new System.Windows.Forms.Button();
            this._courseSelectingTabControl = new System.Windows.Forms.TabControl();
            this._coursePage1 = new System.Windows.Forms.TabPage();
            this._coursePage2 = new System.Windows.Forms.TabPage();
            this._courseSelectingTableLayout.SuspendLayout();
            this._courseSelectingTabControl.SuspendLayout();
            this._coursePage1.SuspendLayout();
            this._coursePage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _courseSelectingTableLayout
            // 
            this._courseSelectingTableLayout.ColumnCount = 3;
            this._courseSelectingTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this._courseSelectingTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._courseSelectingTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._courseSelectingTableLayout.Controls.Add(this._courseSelectingSubmitButton, 1, 1);
            this._courseSelectingTableLayout.Controls.Add(this._courseSelectionResultButton, 2, 1);
            this._courseSelectingTableLayout.Controls.Add(this._courseSelectingTabControl, 0, 0);
            this._courseSelectingTableLayout.Location = new System.Drawing.Point(13, 13);
            this._courseSelectingTableLayout.Name = "_courseSelectingTableLayout";
            this._courseSelectingTableLayout.RowCount = 2;
            this._courseSelectingTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this._courseSelectingTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._courseSelectingTableLayout.Size = new System.Drawing.Size(1001, 526);
            this._courseSelectingTableLayout.TabIndex = 0;
            // 
            // _courseSelectingSubmitButton
            // 
            this._courseSelectingSubmitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._courseSelectingSubmitButton.Location = new System.Drawing.Point(603, 423);
            this._courseSelectingSubmitButton.Name = "_courseSelectingSubmitButton";
            this._courseSelectingSubmitButton.Size = new System.Drawing.Size(194, 100);
            this._courseSelectingSubmitButton.TabIndex = 0;
            this._courseSelectingSubmitButton.Text = "確認送出";
            this._courseSelectingSubmitButton.UseVisualStyleBackColor = true;
            this._courseSelectingSubmitButton.Click += new System.EventHandler(this._courseSelectingSubmitButton_Click);
            // 
            // _courseSelectionResultButton
            // 
            this._courseSelectionResultButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._courseSelectionResultButton.Location = new System.Drawing.Point(803, 423);
            this._courseSelectionResultButton.Name = "_courseSelectionResultButton";
            this._courseSelectionResultButton.Size = new System.Drawing.Size(195, 100);
            this._courseSelectionResultButton.TabIndex = 1;
            this._courseSelectionResultButton.Text = "查看選課結果";
            this._courseSelectionResultButton.UseVisualStyleBackColor = true;
            this._courseSelectionResultButton.Click += new System.EventHandler(this._courseSelectionResultButton_Click);
            // 
            // _courseSelectingTabControl
            // 
            this._courseSelectingTableLayout.SetColumnSpan(this._courseSelectingTabControl, 3);
            this._courseSelectingTabControl.Controls.Add(this._coursePage1);
            this._courseSelectingTabControl.Controls.Add(this._coursePage2);
            this._courseSelectingTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._courseSelectingTabControl.Location = new System.Drawing.Point(3, 3);
            this._courseSelectingTabControl.Name = "_courseSelectingTabControl";
            this._courseSelectingTabControl.SelectedIndex = 0;
            this._courseSelectingTabControl.Size = new System.Drawing.Size(995, 414);
            this._courseSelectingTabControl.TabIndex = 2;
            // 
            // _coursePage1
            // 
            this._coursePage1.Controls.Add(this._courseSelectingDataGridComponent1);
            this._coursePage1.Location = new System.Drawing.Point(4, 22);
            this._coursePage1.Name = "_coursePage1";
            this._coursePage1.Padding = new System.Windows.Forms.Padding(3);
            this._coursePage1.Size = new System.Drawing.Size(987, 388);
            this._coursePage1.TabIndex = 0;
            this._coursePage1.Text = "資工三";
            this._coursePage1.UseVisualStyleBackColor = true;
            // 
            // _coursePage2
            // 
            this._coursePage2.Controls.Add(this._courseSelectingDataGridComponent2);
            this._coursePage2.Location = new System.Drawing.Point(4, 22);
            this._coursePage2.Name = "_coursePage2";
            this._coursePage2.Padding = new System.Windows.Forms.Padding(3);
            this._coursePage2.Size = new System.Drawing.Size(987, 388);
            this._coursePage2.TabIndex = 1;
            this._coursePage2.Text = "電子三甲";
            this._coursePage2.UseVisualStyleBackColor = true;
            // 
            // _courseSelectingDataGridComponent1
            // 
            this._courseSelectingDataGridComponent1.Location = new System.Drawing.Point(3, 3);
            this._courseSelectingDataGridComponent1.Name = "_courseSelectingDataGridComponent1";
            this._courseSelectingDataGridComponent1.Size = new System.Drawing.Size(1032, 412);
            this._courseSelectingDataGridComponent1.TabIndex = 0;
            // 
            // _courseSelectingDataGridComponent2
            // 
            this._courseSelectingDataGridComponent2.Location = new System.Drawing.Point(3, 3);
            this._courseSelectingDataGridComponent2.Name = "_courseSelectingDataGridComponent2";
            this._courseSelectingDataGridComponent2.Size = new System.Drawing.Size(975, 378);
            this._courseSelectingDataGridComponent2.TabIndex = 1;
            // 
            // CourseSelectingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 548);
            this.Controls.Add(this._courseSelectingTableLayout);
            this.Name = "CourseSelectingForm";
            this.Text = "CourseSelectingForm";
            this._courseSelectingTableLayout.ResumeLayout(false);
            this._courseSelectingTabControl.ResumeLayout(false);
            this._coursePage1.ResumeLayout(false);
            this._coursePage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _courseSelectingTableLayout;
        private System.Windows.Forms.Button _courseSelectingSubmitButton;
        private System.Windows.Forms.Button _courseSelectionResultButton;
        private System.Windows.Forms.TabControl _courseSelectingTabControl;
        private System.Windows.Forms.TabPage _coursePage1;
        private System.Windows.Forms.TabPage _coursePage2;
        private CourseSelectingDataGridComponent _courseSelectingDataGridComponent1;
        private CourseSelectingDataGridComponent _courseSelectingDataGridComponent2;
    }
}