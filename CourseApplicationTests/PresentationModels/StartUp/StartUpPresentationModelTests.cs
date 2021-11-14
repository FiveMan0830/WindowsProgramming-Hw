using Microsoft.VisualStudio.TestTools.UnitTesting;
using CourseApplication.PresentationModels.StartUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.PresentationModels.StartUp.Tests
{
    [TestClass()]
    public class StartUpPresentationModelTests
    {
        StartUpPresentationModel model;
        [TestInitialize()]
        public void StartUpPresentationModelInitialize()
        {
            model = new StartUpPresentationModel();
        }

        [TestMethod()]
        public void IsNotCourseSelectingFormOpenedTest()
        {
            Assert.IsTrue(model.IsNotCourseSelectingFormOpened);
            model.IsNotCourseSelectingFormOpened = false;
            Assert.IsFalse(model.IsNotCourseSelectingFormOpened);
        }

        [TestMethod()]
        public void IsNotCourseManagementFormOpenedTest()
        {
            Assert.IsTrue(model.IsNotCourseManagementFormOpened);
            model.IsNotCourseManagementFormOpened = false;
            Assert.IsFalse(model.IsNotCourseManagementFormOpened);
        }
    }
}