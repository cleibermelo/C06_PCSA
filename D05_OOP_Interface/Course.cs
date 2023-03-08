using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_OOP_Interface
{
    public class Course : ICourse
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Area { get; set; }

        public void ListCourse()
        {

        }

        public void ListCourse(string courseName, string area)
        {

        }

        public virtual void ReadCourse()
        {

        }
    }
}
