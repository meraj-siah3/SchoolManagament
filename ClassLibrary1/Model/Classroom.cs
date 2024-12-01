using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    public class Classroom
    {
        public int ClassId { get; set; }  
        public string ClassName { get; set; }   
        public int TeacherId { get; set; }   // شناسه استاد (کلید خارجی)
        public  School  teacher { get; set; } // ارتباط با استاد
        public Collection<Student> Students { get; set; }   
    }
}
