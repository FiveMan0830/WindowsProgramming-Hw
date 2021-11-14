using Microsoft.VisualStudio.TestTools.UnitTesting;
using CourseApplication.PresentationModels.CourseManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.PresentationModels.CourseManagement.Tests
{
    [TestClass()]
    public class CourseManagementPresentationModelTests
    {
        CourseManagementPresentationModel model;
        PrivateObject privateModel;

        /// <summary>
        /// 測試初始化
        /// </summary>
        [TestInitialize()]
        public void CourseManagementPresentationModelInitialize()
        {
            Model.CourseApplicationModel courseApplicationModel = new Model.CourseApplicationModel();
            model = new CourseManagementPresentationModel(courseApplicationModel);
            privateModel = new PrivateObject(model);
        }
        /// <summary>
        /// 測試Set Class
        /// </summary>
        [TestMethod()]
        public void SetClassTest()
        {
            model.SetClass("testClass");
            Assert.AreEqual(privateModel.GetFieldOrProperty("_class"), "testClass");
        }
        /// <summary>
        /// 測試初始化 
        /// </summary>
        [TestMethod()]
        public void InitializeNameListTest()
        {
            model.InitializeNameList();

            Assert.IsNotNull(privateModel.GetFieldOrProperty("_courseNameList"));
        }
        /// <summary>
        /// 測試新增狀態改變
        /// </summary>
        [TestMethod()]
        public void HandleAddNewCourseTest()
        {
            model.HandleAddNewCourse();

            Assert.IsTrue((bool)privateModel.GetFieldOrProperty("_isAddCourseState"));
            Assert.IsNotNull(privateModel.GetFieldOrProperty("_toBeChangedCourse"));
            Assert.IsNotNull(model._currentCourse);
        }
        /// <summary>
        /// 測試更改狀態改變
        /// </summary>
        [TestMethod()]
        public void HandleChangeSelectedIndexTest()
        {
            model.HandleChangeSelectedIndex(0);
            Assert.IsFalse((bool)privateModel.GetFieldOrProperty("_isAddCourseState"));
            Assert.AreEqual(privateModel.GetFieldOrProperty("_currentIndex"), 0);
            Assert.IsNotNull(model._currentCourse);
            Assert.IsNotNull(privateModel.GetFieldOrProperty("_class"));
            Assert.IsNotNull(privateModel.GetFieldOrProperty("_toBeChangedCourse"));
        }
        /// <summary>
        /// 測試是否觸發
        /// </summary>
        [TestMethod()]
        public void NoticeOnCheckBoxClickedTest()
        {
            bool notifyTriggered = false;
            model._timeGridChanged += delegate
            {
                notifyTriggered = true;
            };
            model.NoticeOnCheckBoxClicked();
            Assert.IsTrue(notifyTriggered);
        }

        [TestMethod()]
        public void HandleTextChangedTest()
        {
            privateModel.SetFieldOrProperty("_currentCourse", new Model.Course());
            model.HandleTextChanged("CourseId", "111111");
            Assert.AreEqual(model._currentCourse.CourseId, "111111");
        }

        [TestMethod()]
        public void HandleSaveButtonClickTest()
        {
            privateModel.SetFieldOrProperty("_currentCourse", new Model.Course());
            privateModel.SetFieldOrProperty("_isAddCourseState", true);
            int coursesCount = model._courseApplicationModel._curriculum._courses.Count();
            model.HandleSaveButtonClick();
            Assert.AreEqual(model._courseApplicationModel._curriculum._courses.Count(), coursesCount+1);
            privateModel.SetFieldOrProperty("_isAddCourseState", false);
            model.HandleSaveButtonClick();
            Assert.AreEqual(model._courseApplicationModel._curriculum._courses.Count(), coursesCount+1);
        }

        [TestMethod()]
        public void NotifyTest()
        {
            bool notifyTriggered = false;
            model.PropertyChanged += delegate
            {
                notifyTriggered = true;
            };
            model.Notify("");
            Assert.IsTrue(notifyTriggered);
        }

        [TestMethod()]
        public void SaveTimeAsStringTest()
        {
            List<Dto.CourseTimeDTO> courseTimeGrid = new List<Dto.CourseTimeDTO>();
            Dto.CourseTimeDTO dto5 = new Dto.CourseTimeDTO(5);
            Dto.CourseTimeDTO dto6 = new Dto.CourseTimeDTO(6);
            dto5.Monday = true;
            dto6.Monday = true;
            courseTimeGrid.Add(new Dto.CourseTimeDTO(1));
            courseTimeGrid.Add(new Dto.CourseTimeDTO(2));
            courseTimeGrid.Add(new Dto.CourseTimeDTO(3));
            courseTimeGrid.Add(new Dto.CourseTimeDTO(4));
            courseTimeGrid.Add(dto5);
            courseTimeGrid.Add(dto6);
            courseTimeGrid.Add(new Dto.CourseTimeDTO(7));
            courseTimeGrid.Add(new Dto.CourseTimeDTO(8));

            privateModel.SetFieldOrProperty("_courseTimeGrid", courseTimeGrid);

            Assert.AreEqual("5 6",privateModel.Invoke("SaveTimeAsString", "Monday"));
        }

        [TestMethod()]
        public void GetClassNameTest()
        {
            privateModel.SetFieldOrProperty("_class", "testName");
            Assert.AreEqual("testName", model.GetClassName);
        }

        [TestMethod()]
        public void GetCourseStateTest()
        {
            privateModel.SetFieldOrProperty("_isAddCourseState", true);
            Assert.AreEqual("新增課程", model.GetCourseState);
            privateModel.SetFieldOrProperty("_isAddCourseState", false);
            Assert.AreEqual("編輯課程", model.GetCourseState);
        }

        [TestMethod()]
        public void IsDataChangedTest()
        {
            privateModel.SetFieldOrProperty("_toBeChangedCourse", new Model.Course());
            privateModel.SetFieldOrProperty("_currentCourse", new Model.Course());
            Assert.IsFalse(model.IsDataChanged);
            Model.Course course = new Model.Course();
            course.CourseId = "1";
            privateModel.SetFieldOrProperty("_currentCourse", course);
            Assert.IsTrue(model.IsDataChanged);
        }

        [TestMethod()]
        public void IsRequiredNotEmptyTest()
        {
            privateModel.SetFieldOrProperty("_currentCourse", new Model.Course());
            Assert.IsFalse(model.IsRequiredNotEmpty);
            Model.Course course = new Model.Course();
            course.CourseId = "1";
            course.CourseName = "courseName";
            course.Credit = "1";
            course.Stage = "1";
            course.Teacher = "Teacher";
            course.Hour = "1";
            course.Necessity = "Necessity";
            privateModel.SetFieldOrProperty("_currentCourse", course);
            Assert.IsTrue(model.IsRequiredNotEmpty);
        }

        [TestMethod()]
        public void IsHourMatchTimeTest()
        {
            Model.Course course = new Model.Course();
            course.Hour = "2";
            privateModel.SetFieldOrProperty("_currentCourse", course);
            Assert.IsFalse(model.IsHourMatchTime);


            List<Dto.CourseTimeDTO> courseTimeGrid = new List<Dto.CourseTimeDTO>();
            Dto.CourseTimeDTO dto5 = new Dto.CourseTimeDTO(5);
            Dto.CourseTimeDTO dto6 = new Dto.CourseTimeDTO(6);
            dto5.Monday = true;
            dto6.Monday = true;
            courseTimeGrid.Add(new Dto.CourseTimeDTO(1));
            courseTimeGrid.Add(new Dto.CourseTimeDTO(2));
            courseTimeGrid.Add(new Dto.CourseTimeDTO(3));
            courseTimeGrid.Add(new Dto.CourseTimeDTO(4));
            courseTimeGrid.Add(dto5);
            courseTimeGrid.Add(dto6);
            courseTimeGrid.Add(new Dto.CourseTimeDTO(7));
            courseTimeGrid.Add(new Dto.CourseTimeDTO(8));

            privateModel.SetFieldOrProperty("_courseTimeGrid", courseTimeGrid);
            Assert.IsTrue(model.IsHourMatchTime);
        }

        [TestMethod()]
        public void IsSaveEnabledTest()
        {
            /// Is Data Changed
            privateModel.SetFieldOrProperty("_toBeChangedCourse", new Model.Course());
            Model.Course course = new Model.Course();

            /// Is Require Not Empty
            course.CourseId = "1";
            course.CourseName = "courseName";
            course.Credit = "1";
            course.Stage = "1";
            course.Teacher = "Teacher";
            course.Hour = "1";
            course.Necessity = "Necessity";

            /// Is Hour Match Time
            List<Dto.CourseTimeDTO> courseTimeGrid = new List<Dto.CourseTimeDTO>();
            Dto.CourseTimeDTO dto6 = new Dto.CourseTimeDTO(6);
            dto6.Monday = true;
            courseTimeGrid.Add(new Dto.CourseTimeDTO(1));
            courseTimeGrid.Add(new Dto.CourseTimeDTO(2));
            courseTimeGrid.Add(new Dto.CourseTimeDTO(3));
            courseTimeGrid.Add(new Dto.CourseTimeDTO(4));
            courseTimeGrid.Add(new Dto.CourseTimeDTO(5));
            courseTimeGrid.Add(dto6);
            courseTimeGrid.Add(new Dto.CourseTimeDTO(7));
            courseTimeGrid.Add(new Dto.CourseTimeDTO(8));

            privateModel.SetFieldOrProperty("_currentCourse", course);
            privateModel.SetFieldOrProperty("_courseTimeGrid", courseTimeGrid);
            Assert.IsTrue(model.IsSaveEnabled);
            privateModel.SetFieldOrProperty("_currentCourse", new Model.Course());
            Assert.IsFalse(model.IsSaveEnabled);
            privateModel.SetFieldOrProperty("_currentCourse", course);
            course.CourseName = "";
            Assert.IsFalse(model.IsSaveEnabled);
        }
    }
}