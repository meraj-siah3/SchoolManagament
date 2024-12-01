using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Model.Models
{
  public  class Teacher
    {


        public int TeacherId { get; set; }   // شناسه استاد
        public string FirstName { get; set; }  // نام استاد
        public string LastName { get; set; }   // نام خانوادگی استاد
        public string Email { get; set; }      // ایمیل استاد
        public ICollection<Class> Classes { get; set; }  // ارتباط یک استاد با چندین کلاس


    }
}
