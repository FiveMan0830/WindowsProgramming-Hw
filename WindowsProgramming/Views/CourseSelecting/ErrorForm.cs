using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseApplication.Views.CourseSelecting
{
    public partial class ErrorForm : Form
    {
        public ErrorForm()
        {
            InitializeComponent();
            this._errorString.Text = "加選成功";
        }

        public ErrorForm(string errorString)
        {
            InitializeComponent();
            this._errorString.Text = "加選失敗\n" + errorString;
        }

        /// <summary>
        /// 確認按鈕事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
