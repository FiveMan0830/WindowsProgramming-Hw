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
    public class CourseTests
    {
        Course testCourse;

        /// <summary>
        /// 測試初始化
        /// </summary>
        [TestInitialize()]
        public void InitializeCourseTest()
        {
            testCourse = new Course();
            testCourse.CourseId = "1";
            testCourse.CourseName = "TestCourse";
            testCourse.Stage = "1";
            testCourse.Credit = "1";
            testCourse.Hour = "1";
            testCourse.Necessity = "○";
            testCourse.Teacher = "TestTeacher";
            testCourse.Sunday = "";
            testCourse.Monday = "3";
            testCourse.Tuesday = "";
            testCourse.Wednesday = "";
            testCourse.Thursday = "";
            testCourse.Friday = "";
            testCourse.Saturday = "";
            testCourse.Classroom = "TestClassroom";
            testCourse.NumberOfStudents = "50";
            testCourse.NumberOfDropStudents = "0";
            testCourse.TeachingAssistant = "TestTA";
            testCourse.Language = "";
            testCourse.Syllabus = "";
            testCourse.Note = "";
            testCourse.Audit = "";
            testCourse.Experiment = "";
        }

        /// <summary>
        /// 測試複製是否相同
        /// </summary>
        [TestMethod()]
        public void GetCloneTest()
        {
            Course course = testCourse.GetClone();
            Assert.AreEqual(course.CourseId, testCourse.CourseId);
            Assert.AreEqual(course.CourseName, testCourse.CourseName);
            Assert.AreEqual(course.Stage, testCourse.Stage);
            Assert.AreEqual(course.Credit, testCourse.Credit);
            Assert.AreEqual(course.Hour, testCourse.Hour);
            Assert.AreEqual(course.Necessity, testCourse.Necessity);
            Assert.AreEqual(course.Teacher, testCourse.Teacher);
            Assert.AreEqual(course.Sunday, testCourse.Sunday);
            Assert.AreEqual(course.Monday, testCourse.Monday);
            Assert.AreEqual(course.Tuesday, testCourse.Tuesday);
            Assert.AreEqual(course.Wednesday, testCourse.Wednesday);
            Assert.AreEqual(course.Friday, testCourse.Friday);
            Assert.AreEqual(course.Saturday, testCourse.Saturday);
            Assert.AreEqual(course.Classroom, testCourse.Classroom);
            Assert.AreEqual(course.NumberOfStudents, testCourse.NumberOfStudents);
            Assert.AreEqual(course.NumberOfDropStudents, testCourse.NumberOfDropStudents);
            Assert.AreEqual(course.TeachingAssistant, testCourse.TeachingAssistant);
            Assert.AreEqual(course.Language, testCourse.Language);
            Assert.AreEqual(course.Syllabus, testCourse.Syllabus);
            Assert.AreEqual(course.Note, testCourse.Note);
            Assert.AreEqual(course.Audit, testCourse.Audit);
            Assert.AreEqual(course.Experiment, testCourse.Experiment);
        }
    }
}