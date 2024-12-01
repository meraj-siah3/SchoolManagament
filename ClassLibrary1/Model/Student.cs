using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    public class Student
    {

        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }
        public int NationCode { get; set; }
        public String FatherName { get; set; }

        public Classroom Classes { get; set; }

    }
}
