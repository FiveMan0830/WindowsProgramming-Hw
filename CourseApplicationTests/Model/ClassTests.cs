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
    public class ClassTests
    {
        Class @class;
        /// <summary>
        /// 測試初始化
        /// </summary>
        [TestInitialize()]
        public void Initialize()
        {
            @class = new Class();
        }

        /// <summary>
        /// 測試增加課程成功
        /// </summary>
        [TestMethod()]
        public void AddCourseSuccessfullyTest()
        {
            @class.AddCourse(new Course());
            Assert.AreEqual(@class.Courses.Count(), 1);
            @class.AddCourse(new Course());
            Assert.AreEqual(@class.Courses.Count(), 2);
            @class.AddCourse(new Course());
            Assert.AreEqual(@class.Courses.Count(), 3);
        }

        /// <summary>
        /// 測試刪除課程成功
        /// </summary>
        [TestMethod()]
        public void RemoveCourseSuccessfullyTest()
        {
            Course course1 = new Course();
            Course course2 = new Course();
            Course course3 = new Course();
            @class.AddCourse(course1);
            Assert.AreEqual(@class.Courses.Count(), 1);
            @class.AddCourse(course2);
            Assert.AreEqual(@class.Courses.Count(), 2);
            @class.RemoveCourse(course2);
            Assert.AreEqual(@class.Courses.Count(), 1);
            @class.AddCourse(course3);
            Assert.AreEqual(@class.Courses.Count(), 2);
            @class.AddCourse(course2);
            Assert.AreEqual(@class.Courses.Count(), 3);
            @class.RemoveCourse(course2);
            Assert.AreEqual(@class.Courses.Count(), 2);
        }

        /// <summary>
        /// 測試刪除未存在之課程
        /// </summary>
        [TestMethod()]
        public void RemoveCourseFailWhenRemovingNonExistingCourseTest()
        {
            Course course1 = new Course();
            Course course2 = new Course();
            @class.AddCourse(course1);
            Assert.AreEqual(@class.Courses.Count(), 1);
            @class.AddCourse(course2);
            Assert.AreEqual(@class.Courses.Count(), 2);
            @class.RemoveCourse(course2);
            Assert.AreEqual(@class.Courses.Count(), 1);
            @class.RemoveCourse(course2);
            Assert.AreEqual(@class.Courses.Count(), 1);
        }
    }
}