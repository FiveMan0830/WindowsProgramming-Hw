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
        private const string SEPARATOR = ".";
        public SelectCourseForm(SelectCoursePresentationModel selectCoursePresentationModel)
        {
            _selectCoursePresentationModel = selectCoursePresentationModel;
            InitializeComponent();
            _courseSelectGridView.AutoGenerateColumns = false;
            _courseSelectGridView.CellFormatting += MapCellDataToPropertyValue;
            _courseSelectGridView.CellValueChanged += DispatchOnCourseGridCellValueChanged;
            _courseSelectGridView.CellMouseUp += DispatchOnCourseGridCellMouseUp;

            this.Load += LoadSelectCourseForm;

            _courseSubmitButton.DataBindings.Add("Enabled", _selectCoursePresentationModel, "IsAnyCourseSelected");
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
        /// 數值改動render
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DispatchOnCourseGridCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (IsCourseCheckBoxColumn(e.ColumnIndex) && e.RowIndex != -1)
            {
                _selectCoursePresentationModel.NoticeOnCheckBoxClicked();
            }
        }

        /// <summary>
        /// MouseUp後停止更改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DispatchOnCourseGridCellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (IsCourseCheckBoxColumn(e.ColumnIndex) && e.RowIndex != -1)
            {
                _courseSelectGridView.EndEdit();
            }
        }

        /// <summary>
        /// 確認典籍欄位是否為「選擇」欄
        /// </summary>
        /// <param name="columnIndex"></param>
        /// <returns></returns>
        private bool IsCourseCheckBoxColumn(int columnIndex)
        {
            return columnIndex == _courseSelectCheckBox.Index;
        }

        /// <summary>
        /// Mapping 對應 Property 資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MapCellDataToPropertyValue(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((_courseSelectGridView.Rows[e.RowIndex].DataBoundItem != null) &&
                (_courseSelectGridView.Columns[e.ColumnIndex].DataPropertyName.Contains(SEPARATOR)))
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
        /// TODO: 確認DATAMAP與遞迴之間效能差距
        private object GetPropertyValue(object property, string propertyName)
        {
            if (propertyName.Contains(SEPARATOR))
            {
                var leftPropertyName = propertyName.Substring(0, propertyName.IndexOf(SEPARATOR));
                foreach (var propertyInfo in property.GetType().GetProperties())
                {
                    if (propertyInfo.Name == leftPropertyName)
                    {
                        return GetPropertyValue(
                            propertyInfo.GetValue(property),
                            propertyName.Substring(propertyName.IndexOf(SEPARATOR) + 1));
                    }
                }
            }
            return property.GetType().GetProperty(propertyName).GetValue(property, null);
        }
    }
}
