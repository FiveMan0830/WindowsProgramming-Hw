using Microsoft.VisualStudio.TestTools.UnitTesting;
using CourseApplication.PresentationModels.CourseSelecting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.PresentationModels.CourseSelecting.Tests
{
    [TestClass()]
    public class CourseSelectingPresentationModelTests
    {
        CourseSelectingPresentationModel model;
        PrivateObject privateModel;
        /// <summary>
        /// 初始化
        /// </summary>
        [TestInitialize()]
        public void CourseSelectingPresentationModelInitialize()
        {
            model = new CourseSelectingPresentationModel(new Model.CourseApplicationModel());
            privateModel = new PrivateObject(model);
        }
        /// <summary>
        /// 測試初始化課程
        /// </summary>
        [TestMethod()]
        public void InitializeCourseTest()
        {
            model.InitializeCourse();
            Assert.AreEqual(model._courses.Count(), 2);
        }
        /// <summary>
        /// 測試通知
        /// </summary>
        [TestMethod()]
        public void NoticeOnSelectCourseTest()
        {
            List<Dto.CourseSelectingDto> dtoList = new List<Dto.CourseSelectingDto>();
            dtoList.Add(new Dto.CourseSelectingDto(new Model.Course(), true));
            model._courses.Add("testDepartment", dtoList);
            model.NoticeOnSelectCourse();
            Assert.AreEqual(model._courseApplicationModel._chosenCourses.Count(), 1);
        }
        /// <summary>
        /// 測試通知
        /// </summary>
        [TestMethod()]
        public void NoticeOnCheckBoxClickedTest()
        {
            List<Dto.CourseSelectingDto> dtoList = new List<Dto.CourseSelectingDto>();
            dtoList.Add(new Dto.CourseSelectingDto(new Model.Course(), true));
            model._courses.Add("testDepartment", dtoList);
            model.NoticeOnCheckBoxClicked(0, "testDepartment");
            List<Dto.CourseSelectingDto> outValue;
            model._courses.TryGetValue("testDepartment", out outValue);
            Assert.IsFalse(outValue[0].IsCourseSelected);
        }
        /// <summary>
        /// 測試GetCourses
        /// </summary>
        [TestMethod()]
        public void GetCoursesByDepartmentTest()
        {
            Model.Course course = new Model.Course();
            Model.CourseApplicationModel courseApplicationModel = (Model.CourseApplicationModel)privateModel.GetFieldOrProperty("_courseApplicationModel");
            PrivateObject privateCourseApplicationModel = new PrivateObject(courseApplicationModel);
            List<Model.Course> courses = new List<Model.Course>();
            courses.Add(course);
            Model.Class @class = new Model.Class("testDepartment");
            @class.Courses = courses;
            List<Model.Class> classList = new List<Model.Class>();
            classList.Add(@class);

            privateCourseApplicationModel.SetFieldOrProperty("_class", classList);

            Assert.AreEqual(1, model.GetCoursesByDepartment("testDepartment").Count());
        }
        /// <summary>
        /// 測試去除以選課程
        /// </summary>
        [TestMethod()]
        public void RemoveChosenClassTest()
        {
            Model.Course course1 = new Model.Course();
            Model.Course course2 = new Model.Course();
            Model.Course course3 = new Model.Course();

            List<Dto.CourseSelectingDto> courses = new List<Dto.CourseSelectingDto>();
            courses.Add(new Dto.CourseSelectingDto(course1));
            courses.Add(new Dto.CourseSelectingDto(course2));
            model._courseApplicationModel._chosenCourses.Add(course1);
            model._courseApplicationModel._chosenCourses.Add(course3);
            Assert.AreEqual(1, ((List<Dto.CourseSelectingDto>)privateModel.Invoke("RemoveChosenClass", courses)).Count());
        }

        [TestMethod()]
        public void NotifyTest()
        {
            bool triggered = false;
            model.PropertyChanged += delegate
            {
                triggered = true;
            };
            privateModel.Invoke("Notify", "");
            Assert.IsTrue(triggered);
        }

        [TestMethod()]
        public void NotifyOnCourseDtosChangedTest()
        {
            bool triggered = false;
            model._courseDtosChanged += delegate
            {
                triggered = true;
            };
            privateModel.Invoke("NotifyOnCourseDtosChanged");
            Assert.IsTrue(triggered);
        }

        [TestMethod()]
        public void IsAnyCourseSelectedTest()
        {
            List<Dto.CourseSelectingDto> dtoList = new List<Dto.CourseSelectingDto>();
            dtoList.Add(new Dto.CourseSelectingDto(new Model.Course(), false));
            model._courses.Add("testDepartment", dtoList);
            Assert.IsFalse(model.IsAnyCourseSelected);
            dtoList.Add(new Dto.CourseSelectingDto(new Model.Course(), true));
            Assert.IsTrue(model.IsAnyCourseSelected);
        }

        [TestMethod()]
        public void IsNotCourseSelectionResultFormOpenedTest()
        {
            model.IsNotCourseSelectionResultFormOpened = false;
            Assert.IsFalse(model.IsNotCourseSelectionResultFormOpened);
            model.IsNotCourseSelectionResultFormOpened = true;
            Assert.IsTrue(model.IsNotCourseSelectionResultFormOpened);
        }
    }
}