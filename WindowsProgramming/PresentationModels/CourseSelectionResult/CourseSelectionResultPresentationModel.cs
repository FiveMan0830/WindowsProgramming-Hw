using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseApplication.Model;

namespace CourseApplication.PresentationModels.CourseSelectionResult
{
    public class CourseSelectionResultPresentationModel
    {
        public CourseApplicationModel _courseApplicationModel;
        public CourseSelectionResultPresentationModel(CourseApplicationModel courseApplicationModel)
        {
            _courseApplicationModel = courseApplicationModel;
        }
        // No States
        public void DropCourse(int index)
        {
            _courseApplicationModel.DropCourseChosen(index);
        }
    }
}
