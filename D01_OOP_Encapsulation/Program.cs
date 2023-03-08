using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D01_OOP_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course= new Course();
            course.ReadCourse();
            course.ListCourse();
            Utility.TerminateConsole();          
        }
    }
}
