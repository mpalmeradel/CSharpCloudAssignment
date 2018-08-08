using ABCEdWCFSerivce.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ABCEdWCFSerivce
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITafeDBService" in both code and config file together.
    [ServiceContract]
    public interface ITafeDBService
    {
        [OperationContract]
        int insertStudent(string id, string name, DateTime dateEnrolled);

        [OperationContract]
        int insertCourse(string id, string name, Decimal cost);

        [OperationContract]
        List<Student> viewStudents();

        [OperationContract]
        List<Course> viewCourses();

        [OperationContract]
        int enrol(string courseId, string studentID);

        [OperationContract]
        //SqlDataReader getEnrolmentsForStudent(string studentID);
        List<Course> getEnrolmentsForStudent(string studentID);

        [OperationContract]
        //SqlDataReader getStudentsEnrolledInCourse(string courseID);
        List<Student> getStudentsEnrolledInCourse(string courseID);

    }
}
