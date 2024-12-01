using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    public class Teacher
    {


        public int TeacherId { get; set; }   
        public string FirstName { get; set; }  
        public string LastName { get; set; }   
        public string Email { get; set; }      
        public ICollection<Classroom> Classes { get; set; }  // ارتباط یک استاد با چندین کلاس

    }
}
