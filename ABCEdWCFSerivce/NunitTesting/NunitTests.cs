using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using ABCEdWCFSerivce.Class;

namespace NunitTesting
{
    [TestFixture]
    public class NunitTests
    {
        [Test]
        public void testCourseCourseIDGetterSetter()
        {
            Course c = new Course();
            c.CourseID = "test";
            Assert.AreEqual(c.CourseID, "test");
        }

        [Test]
        public void testCourseCourseNameGetterSetter()
        {
            Course c = new Course();
            c.CourseName = "test";
            Assert.AreEqual(c.CourseName, "test");
        }

        [Test]
        public void testCourseCostGetterSetter()
        {
            Course c = new Course();
            c.Cost = 1.0m;
            Assert.AreEqual(c.Cost, 1.0m);
        }


        [Test]
        public void testEnrolmentStudentIdGetterSetter()
        {
            Enrolment e = new Enrolment();
            e.StudentId = "test";
            Assert.AreEqual(e.StudentId, "test");
        }

        [Test]
        public void testEnrolmentCourseIdGetterSetter()
        {
            Enrolment e = new Enrolment();
            e.CourseID = "test";
            Assert.AreEqual(e.CourseID, "test");
        }

        [Test]
        public void testEnrolmentGradeGetterSetter()
        {
            Enrolment e = new Enrolment();
            e.Grade = "F";
            Assert.AreEqual(e.Grade, "F");
        }

        [Test]
        public void testStudentStudentIDGetterSetter()
        {
            Student s = new Student();
            s.StudentID = "test";
            Assert.AreEqual(s.StudentID, "test");
        }

        [Test]
        public void testStudentStudentNameGetterSetter()
        {
            Student s = new Student();
            s.StudentName = "test";
            Assert.AreEqual(s.StudentName, "test");
        }

        [Test]
        public void testStudentDateEnrolledGetterSetter()
        {
            Student s = new Student();
            DateTime d = DateTime.Now;

            s.DateEnrolled = d;
            Assert.AreEqual(s.DateEnrolled, d);
        }


    }
}
