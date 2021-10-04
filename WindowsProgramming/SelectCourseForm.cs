using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseApplication.Model.Dto;

namespace CourseApplication
{
    public partial class SelectCourseForm : Form
    {
        private readonly SelectCoursePresentationModel _selectCoursePresentationModel;

        public SelectCourseForm(SelectCoursePresentationModel selectCoursePresentationModel)
        {
            _selectCoursePresentationModel = selectCoursePresentationModel;
            InitializeComponent();
            _courseSelectGridView.AutoGenerateColumns = false;
            _courseSelectGridView.CellFormatting += MapCellDataToPropertyValue;

            this.Load += LoadSelectCourseForm;
        }
        /// <summary>
        /// Load Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadSelectCourseForm(object sender, EventArgs e)
        {
            _selectCoursePresentationModel.LoadCourses();
            _courseSelectGridView.DataSource = _selectCoursePresentationModel.Courses;
            // InitializeLayout();
        }

        /// <summary>
        /// 初始化界面
        /// </summary>
        private void InitializeLayout()
        {
            const int FORM_WIDTH = 800;
            const int FORM_HEIGHT = 600;
            this.Size = new Size(FORM_WIDTH, FORM_HEIGHT);
        }

        /// <summary>
        /// Mapping 對應 Property 資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MapCellDataToPropertyValue(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((_courseSelectGridView.Rows[e.RowIndex].DataBoundItem != null) &&
                (_courseSelectGridView.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = GetPropertyValue(
                    _courseSelectGridView.Rows[e.RowIndex].DataBoundItem,
                    _courseSelectGridView.Columns[e.ColumnIndex].DataPropertyName
                );
            }
        }

        /// <summary>
        /// 取得 Property 對應資料
        /// </summary>
        /// <param name="property"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private object GetPropertyValue(object property, string propertyName)
        {
            if (propertyName.Contains("."))
            {
                var leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
                foreach (var propertyInfo in property.GetType().GetProperties())
                {
                    if (propertyInfo.Name == leftPropertyName)
                    {
                        return GetPropertyValue(
                            propertyInfo.GetValue(property),
                            propertyName.Substring(propertyName.IndexOf(".") + 1));
                    }
                }
            }
            return property.GetType().GetProperty(propertyName).GetValue(property, null);
        }
    }
}
