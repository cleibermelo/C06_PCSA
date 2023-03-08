using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

/*Encapsulation
    Public classe members: methods, properties
    Private classe members: fields or attributes, variables
 */

namespace D01_OOP_Encapsulation
{
    public class Course
    {
        #region Fields
        private string courseName; //suporte da propriedade classica
        private string area;       //suporte da propriedade bodied-expression( operador lambda =>)
        #endregion

        #region Properties
        //Auto-implemented
        public int CourseId { get; set; }

        //Classica
        public string CourseName 
        { 
            get { return courseName; }
            set { courseName = value; }
        }

        // bodied-expression
        public string Area 
        { 
            get => area; 
            set => area = value; 
        }

        // read only
        public string FullCourse => $"Course: {CourseId}: {Area} - {CourseName}";
        #endregion

        #region Methods
        //read all course values
        public void ReadCourse()
        {
            //bool id;
            //int courseid;
            Console.Write("Course id: ");
            bool convertedId = int.TryParse(Console.ReadLine(), out int courseid);
            //CourseId = courseid;

            if(convertedId)
            {
                CourseId = courseid;
            }
            else
            {
                Console.WriteLine("Formato invalido!");
            }

            Console.Write("Course Area: ");
            Area = Console.ReadLine();

            Console.Write("Course Name: ");
            CourseName= Console.ReadLine();
        }
        //list course info
        public void ListCourse()
        {
            Console.WriteLine($"\n\n{FullCourse}");
        }
        #endregion
    }
}
