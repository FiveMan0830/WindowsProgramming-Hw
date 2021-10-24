using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseApplication.Model;

namespace CourseApplication.PresentationModels.StartUp
{
    public class StartUpPresentationModel
    {
        public bool IsNotCourseSelectingFormOpened
        {
            get; set;
        }
        public bool IsNotCourseManagementFormOpened
        {
            get; set;
        }
        public StartUpPresentationModel()
        {
            IsNotCourseSelectingFormOpened = true;
            IsNotCourseManagementFormOpened = true;
        }
    }
}
