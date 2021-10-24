using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseApplication.PresentationModels.CourseManagement;

namespace CourseApplication.Views.CourseManagement
{
    public partial class CourseManagementForm : Form
    {
        CourseManagementPresentationModel _courseManagementPresentationModel;
        public CourseManagementForm(CourseManagementPresentationModel courseManagementPresentationModel)
        {
            _courseManagementPresentationModel = courseManagementPresentationModel;
            InitializeComponent();
        }
    }
}
