using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ABCEdWCFSerivce.Class
{
    [DataContract]
    public class Student
    { 
        [DataMember]
        public string StudentID { get; set; }
        [DataMember]
        public string StudentName { get; set; }
        [DataMember]
        public DateTime DateEnrolled { get; set; }
    
    }
}