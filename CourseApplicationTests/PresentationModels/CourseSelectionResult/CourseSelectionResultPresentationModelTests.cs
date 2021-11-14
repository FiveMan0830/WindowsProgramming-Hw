using Microsoft.VisualStudio.TestTools.UnitTesting;
using CourseApplication.PresentationModels.CourseSelectionResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.PresentationModels.CourseSelectionResult.Tests
{
    [TestClass()]
    public class CourseSelectionResultPresentationModelTests
    {
        CourseSelectionResultPresentationModel model;
        [TestInitialize()]
        public void CourseSelectionResultPresentationModelInitialize()
        {
            model = new CourseSelectionResultPresentationModel(new Model.CourseApplicationModel());
        }

        [TestMethod()]
        public void DropCourseTest()
        {
            model._courseApplicationModel._chosenCourses.Add(new Model.Course());
            model._courseApplicationModel._chosenCourses.Add(new Model.Course());

            Assert.AreEqual(2, model._courseApplicationModel._chosenCourses.Count());
            model.DropCourse(1);
            Assert.AreEqual(1, model._courseApplicationModel._chosenCourses.Count());
        }
    }
}