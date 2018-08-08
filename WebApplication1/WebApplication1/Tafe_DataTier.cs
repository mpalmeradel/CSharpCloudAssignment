using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

using WebApplication1.TafeDBServiceReference;

namespace WebApplication1
{
    public class Tafe_DataTier
    {

        TafeDBServiceClient service;

        public Tafe_DataTier()
        {

        }


        public int insertStudent(string id, string name, DateTime dateEnrolled)
        {

            int rowsUpdated;
            try
            {
                service = new TafeDBServiceClient("BasicHttpBinding_ITafeDBService");
                rowsUpdated = service.insertStudent(id, name, dateEnrolled);
            }
            catch (Exception ex)
            {
                rowsUpdated = -1;
            }

            return rowsUpdated;
        }



        public int insertCourse(string id, string name, Decimal cost)
        {
            TafeDBServiceClient service = new TafeDBServiceClient("BasicHttpBinding_ITafeDBService");
            int rowsUpdated = service.insertCourse(id, name, cost);

            return rowsUpdated;
        }

        public List<Student> viewStudents()
        {
            TafeDBServiceClient service = new TafeDBServiceClient("BasicHttpBinding_ITafeDBService");
            List<Student> students = new List<Student>();

            students = service.viewStudents();

            return students;
        }

        public List<Course> viewCourses()
        {
            TafeDBServiceClient service = new TafeDBServiceClient("BasicHttpBinding_ITafeDBService");
            List<Course> courses = new List<Course>();

            courses = service.viewCourses();

            return courses;
        }


        public int enroll(String courseID, String studentID)
        {

            TafeDBServiceClient service = new TafeDBServiceClient("BasicHttpBinding_ITafeDBService");
            int rowsUpdated = service.enrol(courseID, studentID);
            return rowsUpdated;
        }

        public List<Course> getEnrolmentsForStudent(string studentID)
        {
            TafeDBServiceClient service = new TafeDBServiceClient("BasicHttpBinding_ITafeDBService");
            List<Course> courses = service.getEnrolmentsForStudent(studentID);
            return courses;
        }

        public List<Student> getStudentEnrolledInCourse(string courseID)
        {
            TafeDBServiceClient service = new TafeDBServiceClient("BasicHttpBinding_ITafeDBService");
            List<Student> students = service.getStudentsEnrolledInCourse(courseID);
            return students;
        }

    }
}