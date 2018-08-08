using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
//using ABCEdWCFSerivce.Class;
using System.Data.SqlClient;
using System.Configuration;
using ABCEdWCFSerivce.Class;

namespace ABCEdWCFSerivce
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TafeDBService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TafeDBService.svc or TafeDBService.svc.cs at the Solution Explorer and start debugging.
    public class TafeDBService : ITafeDBService
    {
        TafeDBEntities db = new TafeDBEntities();

        public int enrol(string courseId, string studentID)
        {
            int rowsUpdated = 1;
            TblEnrolment enrolment = new TblEnrolment();
            enrolment.StudentID = studentID;
            enrolment.CourseID = courseId;
            enrolment.Grade = "NR";

            db.TblEnrolments.Add(enrolment);

            try
            {
                db.SaveChanges();
            }
            catch
            {
                rowsUpdated = -1;
            }
            return rowsUpdated;
        }

        public List<Course> getEnrolmentsForStudent(string studentID)
        {
            List<Course> courses = new List<Course>();
            
            foreach (TblEnrolment e in db.TblEnrolments)
                if (e.StudentID.Trim() == studentID.Trim())
                {
                    foreach (TblCourse c in db.TblCourses)
                    {
                        if (c.CourseID == e.CourseID)
                        {
                            Course course = new Course();
                            course.CourseID = c.CourseID;
                            course.CourseName = c.CourseName;
                            course.Cost = (decimal)c.Cost;

                            courses.Add(course);
                        }
                    }
                }
            
                
            return courses;
                        
        }

        public List<Student> getStudentsEnrolledInCourse(string courseID)
        {
            List<Student> students = new List<Student>();
            
            foreach (TblEnrolment e in db.TblEnrolments)
                if (e.CourseID.Trim() == courseID.Trim())
                    foreach(TblStudent s in db.TblStudents)
                        if (s.StudentID == e.StudentID)
                        {
                            Student student = new Student();
                            student.StudentID = s.StudentID;
                            student.StudentName = s.StudentName;
                            student.DateEnrolled = (DateTime)s.DateEnrolled;

                            students.Add(student);
                        }

            return students;
        }

        public int insertCourse(string id, string name, decimal cost)
        {
            int rowsUpdated = 1;

            TblCourse course = new TblCourse();
            course.CourseID = id;
            course.CourseName = name;
            course.Cost = cost;

            db.TblCourses.Add(course);

            try
            {
                db.SaveChanges();
            }
            catch
            {
                rowsUpdated = -1;
            }

            return rowsUpdated;
        }

        public int insertStudent(string id, string name, DateTime dateEnrolled)
        {
            int rowsUpdated = 1;

            TblStudent student = new TblStudent();
            student.StudentID = id;
            student.StudentName = name;
            student.DateEnrolled = dateEnrolled;

            db.TblStudents.Add(student);

            try
            {
                db.SaveChanges();
            }
            catch 
            {
                rowsUpdated = -1;
            }
                        
            return rowsUpdated;
        }

        public List<Course> viewCourses()
        {
            List<Class.Course> courses = new List<Class.Course>();

            foreach(TblCourse course in db.TblCourses)
            {
                Class.Course c = new Class.Course();
                c.CourseID = course.CourseID;
                c.CourseName = course.CourseName;
                c.Cost = (decimal)course.Cost;

                courses.Add(c);
            }
              
            return courses;
        }

        public List<Student> viewStudents()
        {
            List<Class.Student> students = new List<Class.Student>();

            foreach(TblStudent student in db.TblStudents)
            {
                Class.Student s = new Class.Student();
                s.StudentID = student.StudentID;
                s.StudentName = student.StudentName;
                if (student.DateEnrolled != null)
                    s.DateEnrolled = (DateTime)student.DateEnrolled;
                else
                    s.DateEnrolled = DateTime.Now;

                students.Add(s);
            }

            return students;
        }
                
    }
}
