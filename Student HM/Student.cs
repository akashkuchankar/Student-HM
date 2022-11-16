using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_HM
{
    [Serializable]
    public class Student
    {
        public int studentrollno { get; set; }  
        public string studentname { get; set; }    
        public string  percentage { get; set; }  
    }
}
