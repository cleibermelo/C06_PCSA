using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_OOP_Inheritance
{
    internal class CourseSoftSkills : Course
    {
        public string Subarea { get; set; }
        public override string FullCourse => $"Course: {CourseId}: {Area} ({Subarea}) - {CourseName}";

        public CourseSoftSkills() : base() 
        {
            Subarea = "";
        }

        public CourseSoftSkills(int courseid, string area, string coursename, string subarea) : base(courseid, area, coursename)
        {
            Subarea = subarea;
        }
    }
}
