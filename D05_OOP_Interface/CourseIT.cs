using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_OOP_Interface
{
    public class CourseIT : Course, ICourseIT
    {
        public bool Exam { get; set; }
    }
}
