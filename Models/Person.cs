using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace INF272Prac2.Models
{
    public class Person
    {
        [DisplayName("STUDENT NUMBER")]
        public string StudentNo { get; set; }

        [DisplayName("NAME")]
        public string StudentName { get; set; }

        [DisplayName("SURNAME")]
        public string StudentSurname { get; set; }

        [DisplayName("EMAIL")]
        public string StudentEmail { get; set; }

        [DisplayName("LINK")]
        public string MyLink { get; set; }  
    }
}