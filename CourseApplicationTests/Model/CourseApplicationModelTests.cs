using Microsoft.VisualStudio.TestTools.UnitTesting;
using CourseApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.Model.Tests
{
    [TestClass()]
    public class CourseApplicationModelTests
    {
        CourseApplicationModel model;
        PrivateObject privateModel;
        Class testDepartment1;
        Class testDepartment2;
        Course testCourse1;
        Course testCourse2;
        Course testCourse3;
        Course testCourse4;
        Course testCourse5;
        Course testDuplicateCourse1;
        /// <summary>
        /// 初始化
        /// </summary>
        [TestInitialize()]
        public void CourseApplicationModelInitialize()
        {
            model = new CourseApplicationModel();
            privateModel = new PrivateObject(model);
            List<Course> courses1 = new List<Course>();
            testDepartment2 = new Class("TestDepartment2");
            testCourse1 = new Course();
            courses1.Add(testCourse1);
            testDepartment1 = new Class("TestDepartment1", courses1);
            testCourse2 = new Course();
            testCourse3 = new Course();
            testCourse4 = new Course();
            testCourse5 = new Course();
            testDuplicateCourse1 = new Course();
            testCourse1.CourseId = "1";
            testCourse1.CourseName = "testCourse1";
            testCourse2.CourseId = "2";
            testCourse2.CourseName = "testCourse2";
            testCourse3.CourseId = "3";
            testCourse3.CourseName = "testCourse3";
            testCourse4.CourseId = "4";
            testCourse4.CourseName = "testCourse4";
            testCourse5.CourseId = "5";
            testCourse5.CourseName = "testCourse5";
            testCourse4.Monday = "1 2";
            testCourse5.Monday = "1 2";
        }

        /// <summary>
        /// 以名稱取得系
        /// </summary>
        [TestMethod()]
        public void GetDepartmentByNameTest()
        {
            List<Class> classes = new List<Class>();
            classes.Add(testDepartment1);
            classes.Add(testDepartment2);
            privateModel.SetFieldOrProperty("_class", classes);

            GetDepartmentByNameSuccessfully();
            GetDepartmentByNameFailed(); 
        }

        /// <summary>
        /// 取得成功
        /// </summary>
        public void GetDepartmentByNameSuccessfully()
        {
            List<Class> classes = new List<Class>();
            classes.Add(testDepartment1);
            classes.Add(testDepartment2);
            privateModel.SetFieldOrProperty("_class", classes);

            Assert.AreEqual(model.GetDepartmentByName("TestDepartment1"), testDepartment1);
            Assert.AreEqual(model.GetDepartmentByName("TestDepartment2"), testDepartment2);
        }

        /// <summary>
        /// 取得失敗
        /// </summary>
        public void GetDepartmentByNameFailed()
        {
            Assert.IsNull(model.GetDepartmentByName("TestDepartment3"));
        }

        /// <summary>
        /// 儲存以選課程測試
        /// </summary>
        [TestMethod()]
        public void AddCourseChosenTest()
        {
            List<Course> addCourse = new List<Course>();
            addCourse.Add(testCourse2);
            addCourse.Add(testCourse1);
            model.AddCourseToChosen(addCourse);
            Assert.AreEqual(model._chosenCourses.Count(), 2);


            Assert.AreEqual("課程名稱相同 : 2 testCourse2、2 testCourse2\n課程課號相同 : 2 testCourse2、2 testCourse2\n課程名稱相同 : 1 testCourse1、1 testCourse1\n課程課號相同 : 1 testCourse1、1 testCourse1\n", model.AddCourseToChosen(addCourse));
        }

        /// <summary>
        /// 退選測試
        /// </summary>
        [TestMethod()]
        public void DropCourseChosenTest()
        {
            model._chosenCourses.Add(testCourse1);
            model._chosenCourses.Add(testCourse2);

            Assert.AreEqual(model._chosenCourses.Count(), 2);
            model.DropCourseFromChosen(3);
            model.DropCourseFromChosen(1);
            Assert.AreEqual(model._chosenCourses.Count(), 1);

        }

        /// <summary>
        /// 移動課程測試
        /// </summary>
        [TestMethod()]
        public void MoveCourseToClassTest()
        {
            List<Class> classes = new List<Class>();
            classes.Add(testDepartment1);
            classes.Add(testDepartment2);
            testDepartment2.AddCourse(testCourse2);
            Assert.AreEqual(testDepartment1.Courses.Count(), 1);
            Assert.AreEqual(testDepartment2.Courses.Count(), 1);

            privateModel.SetFieldOrProperty("_class", classes);
            model.MoveCourseToClass("TestDepartment2", testCourse1, testCourse1);
            Assert.AreEqual(testDepartment2.Courses.Count(), 2);
            model.MoveCourseToClass("TestDepartment2", null, testCourse3);
            Assert.AreEqual(testDepartment2.Courses.Count(), 3);
        }

        /// <summary>
        /// 測試
        /// </summary>
        [TestMethod()]
        public void GetClassByCourseTest()
        {
            List<Class> classes = new List<Class>();
            classes.Add(testDepartment1);
            testDepartment1.AddCourse(testCourse1);
            classes.Add(testDepartment2);
            testDepartment2.AddCourse(testCourse2);
            privateModel.SetFieldOrProperty("_class", classes);
            Assert.AreEqual("TestDepartment1", model.GetClassByCourse(testCourse1));

            Assert.AreEqual("TestDepartment2", model.GetClassByCourse(testCourse2));

            Assert.IsNull(model.GetClassByCourse(testCourse3));
        }

        /// <summary>
        /// 測試notify
        /// </summary>
        [TestMethod()]
        public void NotifyChosenCourseChangedTest()
        {
            bool eventTriggered = false;
            model._chosenCourseChanged += delegate
            {
                eventTriggered = true;
            };
            privateModel.Invoke("NotifyChosenCourseChanged");
            Assert.IsTrue(eventTriggered);
        }

        /// <summary>
        /// 測試notify
        /// </summary>
        [TestMethod()]
        public void NotifyClassCourseChangedTest()
        {
            bool eventTriggered = false;
            model._classCourseChanged += delegate
            {
                eventTriggered = true;
            };
            privateModel.Invoke("NotifyClassCourseChanged");
            Assert.IsTrue(eventTriggered);
        }

        /// <summary>
        /// 測試比對時間
        /// </summary>
        [TestMethod()]
        public void CheckTimeDuplicateTest()
        {
            string[] args1 = new string[] {"1 2 3", "4 5"};
            Assert.IsFalse((bool)privateModel.Invoke("CheckTimeDuplicate", args1));
            string[] args2 = new string[] { "1 2 4", "4 5" };
            Assert.IsTrue((bool)privateModel.Invoke("CheckTimeDuplicate", args2));
        }

        /// <summary>
        /// 測試比對時間
        /// </summary>
        [TestMethod()]
        public void CheckIfCourseTimeComplicatedTest()
        {
            Course[] args1 = new Course[2] { testCourse4, testCourse5 };
            Assert.AreEqual("課程衝堂 : 4 testCourse4、5 testCourse5\n", privateModel.Invoke("CheckIfCourseTimeComplicated", args1));
        }
    }
}