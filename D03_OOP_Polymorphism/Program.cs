using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D03_OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region Course

            #endregion

            #region CourseIT
            CourseIT courseit = new CourseIT();
            Utility.WriteTitle("Course");

            courseit.ReadCourse();
            courseit.ListCourse();

            courseit.ListCourse(DateTime.Today);

            Utility.TerminateConsole();

            #endregion
            #region CourseSoftSkills
            CourseSoftSkills courseSoftSkills = new CourseSoftSkills();

            Utility.WriteTitle("Course Soft Skills");
            courseSoftSkills.ReadCourse();
            courseSoftSkills.ListCourse();
            courseSoftSkills.ListCourse("TesteA");
            Utility.TerminateConsole();
            #endregion


        }
    }
}
