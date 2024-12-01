using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Model.Models
{

    public class Class
    {
        public int ClassId { get; set; }      // شناسه کلاس
        public string ClassName { get; set; } // نام کلاس
        public int TeacherId { get; set; }   // شناسه استاد (کلید خارجی)
        public Teacher Teacher { get; set; } // ارتباط با استاد
        public Collection<Student> Students { get; set; } // ارتباط با استاد
    }


}
