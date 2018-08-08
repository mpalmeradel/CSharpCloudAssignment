using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ABCEdWCFSerivce.Class
{
    [DataContract]
    public class Enrolment
    {
        [DataMember]
        public string StudentId { get; set; }
        [DataMember]
        public string CourseID { get; set; }
        [DataMember]
        public string Grade { get; set; }
    }
}