﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ABCEdWCFSerivce.Class
{
    [DataContract]
    public class Course
    {
        [DataMember]
        public string CourseID { get; set; }
        [DataMember]
        public string CourseName { get; set; }
        [DataMember]
        public decimal Cost { get; set; }
    }
}