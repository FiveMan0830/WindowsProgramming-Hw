using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseApplication.PresentationModels.CourseSelectionResult;

namespace CourseApplication.Views.CourseSelectionResult
{
    public partial class CourseSelectionResultForm : Form
    {
        private CourseSelectionResultPresentationModel _courseSelectionResultPresentationModel;
        public CourseSelectionResultForm(CourseSelectionResultPresentationModel courseSelectionResultPresentationModel)
        {
            _courseSelectionResultPresentationModel = courseSelectionResultPresentationModel;
            InitializeComponent();
            _courseSelectingDataGridView.DataSource = _courseSelectionResultPresentationModel._courseApplicationModel._chosenCourses;
            _courseSelectingDataGridView.CellContentClick += new DataGridViewCellEventHandler(ClickCourseSelectingDataGridViewCellContent);

        }

        /// <summary>
        /// 退選課程按鈕按下事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickCourseSelectingDataGridViewCellContent(object sender, DataGridViewCellEventArgs e)
        {
            if (IsCourseDropColumn(e.ColumnIndex) && e.RowIndex != -1)
            {
                _courseSelectionResultPresentationModel.DropCourse(e.ColumnIndex);
            }
        }

        /// <summary>
        /// 確認典籍欄位是否為「選擇」欄
        /// </summary>
        /// <param name="columnIndex"></param>
        /// <returns></returns>
        public bool IsCourseDropColumn(int columnIndex)
        {
            return columnIndex == _dropCourseButton.Index;
        }
    }
}
