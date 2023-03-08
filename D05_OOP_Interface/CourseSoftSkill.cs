using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_OOP_Interface
{
    public class CourseSoftSkill : Course, ICourseSoftSkill
    {
        public string SubArea { get; set; }

        public CourseSoftSkill() : base()
        {
            SubArea= string.Empty;
        }

        public override void ReadCourse()
        {

        }

    }
}
