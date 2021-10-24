
namespace CourseApplication.Views.CourseSelecting
{
    partial class ErrorForm
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
            this._errorString = new System.Windows.Forms.Label();
            this._dialogSubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _errorString
            // 
            this._errorString.AutoSize = true;
            this._errorString.Location = new System.Drawing.Point(12, 32);
            this._errorString.Name = "_errorString";
            this._errorString.Size = new System.Drawing.Size(27, 12);
            this._errorString.TabIndex = 0;
            this._errorString.Text = "label";
            // 
            // _DialogSubmitButton
            // 
            this._dialogSubmitButton.Location = new System.Drawing.Point(379, 246);
            this._dialogSubmitButton.Name = "_DialogSubmitButton";
            this._dialogSubmitButton.Size = new System.Drawing.Size(75, 23);
            this._dialogSubmitButton.TabIndex = 1;
            this._dialogSubmitButton.Text = "確定";
            this._dialogSubmitButton.UseVisualStyleBackColor = true;
            this._dialogSubmitButton.Click += new System.EventHandler(this.SubmitButtonClick);
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 281);
            this.Controls.Add(this._dialogSubmitButton);
            this.Controls.Add(this._errorString);
            this.Name = "ErrorForm";
            this.Text = "ErrorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _errorString;
        private System.Windows.Forms.Button _dialogSubmitButton;
    }
}