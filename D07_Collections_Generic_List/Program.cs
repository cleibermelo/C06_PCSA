using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D07_Collections_Generic_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region List: ints

            List<int> list = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region List: courses
            List<Course> listCourse = new List<Course>();

            Course course1 = new Course(1, "Dev", "c#");
            Course course2 = new Course(2, "BD", "sql");

            listCourse.Add(course1);
            listCourse.Add(course2);

            foreach (Course item in listCourse)
            {
                Console.WriteLine($"Course: {item.CourseID}, Name: {item.CourseName}, Area: {item.Area}");
            }

            #endregion


            Utility.TerminateConsole();

        }
    }
}
