using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseApplication.PresentationModels.CourseSelecting;

namespace CourseApplication.Views.CourseSelecting
{
    public partial class CourseSelectingDataGridComponent : UserControl
    {
        private const string SEPARATOR = ".";
        string _departmentName;
        CourseSelectingPresentationModel _presentationModel;

        public CourseSelectingDataGridComponent(CourseSelectingPresentationModel model, string departmentName)
        {
            _presentationModel = model;
            _departmentName = departmentName;
            InitializeComponent();
            _courseSelectingDataGridView.AutoGenerateColumns = false;
            _courseSelectingDataGridView.CellFormatting += MapCellDataToPropertyValue;
            _courseSelectingDataGridView.CellValueChanged += DispatchOnCourseGridCellValueChanged;
            _courseSelectingDataGridView.CellMouseUp += DispatchOnCourseGridCellMouseUp;
        }

        /// <summary>
        /// 取Component
        /// </summary>
        /// <returns></returns>
        public DataGridView GetCourseSelectingDataGridView()
        {
            return _courseSelectingDataGridView;
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
                _courseSelectingDataGridView.EndEdit();
            }
        }

        /// <summary>
        /// 確認典籍欄位是否為「選擇」欄
        /// </summary>
        /// <param name="columnIndex"></param>
        /// <returns></returns>
        public bool IsCourseCheckBoxColumn(int columnIndex)
        {
            return columnIndex == _courseSelectCheckBox.Index;
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
                _presentationModel.NoticeOnCheckBoxClicked(e.RowIndex, _departmentName);
            }
        }

        /// <summary>
        /// Mapping 對應 Property 資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MapCellDataToPropertyValue(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((_courseSelectingDataGridView.Rows[e.RowIndex].DataBoundItem != null) &&
                (_courseSelectingDataGridView.Columns[e.ColumnIndex].DataPropertyName.Contains(SEPARATOR)))
            {
                e.Value = GetPropertyValue(
                    _courseSelectingDataGridView.Rows[e.RowIndex].DataBoundItem,
                    _courseSelectingDataGridView.Columns[e.ColumnIndex].DataPropertyName
                );
            }
        }

        /// <summary>
        /// 取得 Property 對應資料 TODO Use DTO
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
