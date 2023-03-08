using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D06_Collections.ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region ArrayList: multi-value

            System.Collections.ArrayList listaMultivalor = new System.Collections.ArrayList();
            listaMultivalor.Add(1.5);
            listaMultivalor.Add(true);
            listaMultivalor.Add(new DateTime(2023, 2, 28));

            //adicionar os numeros 4, 5, 6

            for(int i = 4; i < 7; i++)
            {
                listaMultivalor.Add(i);
            }
            foreach (var item in listaMultivalor)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region ArrayList: objects

            System.Collections.ArrayList newListaMultivalor = new System.Collections.ArrayList();
            //{
            //    new Course(){ CourseID=1, CourseName="Dev", Area="c#"},
            //    new Course(){ CourseID=2, CourseName="BD", Area="sql"}
            //};

            Course course1 = new Course(1,  "Dev",  "c#");
            Course course2 = new Course(2, "BD", "sql");

            newListaMultivalor.Add(course1);
            newListaMultivalor.Add(course2);

            foreach (Course item in newListaMultivalor)
            {
                Console.WriteLine($"Course: {item.CourseID}, Name: {item.CourseName}, Area: {item.Area}");
            }

            #endregion

            Utility.TerminateConsole();
        }
    }
}
