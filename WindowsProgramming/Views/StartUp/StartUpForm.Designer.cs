
namespace CourseApplication.Views.StartUp
{
    partial class StartUpForm
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
            this._startUpLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._courseSelectButton = new System.Windows.Forms.Button();
            this._courseManageButton = new System.Windows.Forms.Button();
            this._exitButton = new System.Windows.Forms.Button();
            this._startUpLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _startUpLayoutPanel
            // 
            this._startUpLayoutPanel.ColumnCount = 2;
            this._startUpLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this._startUpLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._startUpLayoutPanel.Controls.Add(this._courseSelectButton, 0, 0);
            this._startUpLayoutPanel.Controls.Add(this._courseManageButton, 0, 1);
            this._startUpLayoutPanel.Controls.Add(this._exitButton, 1, 2);
            this._startUpLayoutPanel.Location = new System.Drawing.Point(13, 13);
            this._startUpLayoutPanel.Name = "_startUpLayoutPanel";
            this._startUpLayoutPanel.RowCount = 3;
            this._startUpLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this._startUpLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this._startUpLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._startUpLayoutPanel.Size = new System.Drawing.Size(775, 425);
            this._startUpLayoutPanel.TabIndex = 0;
            // 
            // _courseSelectButton
            // 
            this._startUpLayoutPanel.SetColumnSpan(this._courseSelectButton, 2);
            this._courseSelectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._courseSelectButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._courseSelectButton.Location = new System.Drawing.Point(3, 3);
            this._courseSelectButton.Name = "_courseSelectButton";
            this._courseSelectButton.Size = new System.Drawing.Size(769, 164);
            this._courseSelectButton.TabIndex = 0;
            this._courseSelectButton.Text = "Course Selecting System";
            this._courseSelectButton.UseVisualStyleBackColor = true;
            // 
            // _courseManageButton
            // 
            this._startUpLayoutPanel.SetColumnSpan(this._courseManageButton, 2);
            this._courseManageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._courseManageButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._courseManageButton.Location = new System.Drawing.Point(3, 173);
            this._courseManageButton.Name = "_courseManageButton";
            this._courseManageButton.Size = new System.Drawing.Size(769, 164);
            this._courseManageButton.TabIndex = 1;
            this._courseManageButton.Text = "Course Management System";
            this._courseManageButton.UseVisualStyleBackColor = true;
            // 
            // _exitButton
            // 
            this._exitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._exitButton.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._exitButton.Location = new System.Drawing.Point(545, 343);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(227, 79);
            this._exitButton.TabIndex = 2;
            this._exitButton.Text = "Exit";
            this._exitButton.UseVisualStyleBackColor = true;
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._startUpLayoutPanel);
            this.Name = "StartUpForm";
            this.Text = "StartUpForm";
            this._startUpLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _startUpLayoutPanel;
        private System.Windows.Forms.Button _courseSelectButton;
        private System.Windows.Forms.Button _courseManageButton;
        private System.Windows.Forms.Button _exitButton;
    }
}