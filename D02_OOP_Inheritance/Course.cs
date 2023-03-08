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

namespace D02_OOP_Inheritance
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
            set { courseName = value.ToUpper(); }
        }

        // bodied-expression
        public string Area 
        { 
            get => area; 
            set => area = value.ToUpper(); 
        }

        // read only
        //public string FullCourse => $"Course: {CourseId}: {Area} - {CourseName}";
        public virtual string FullCourse => $"Course: {CourseId}: {Area} - {CourseName}";
        #endregion

        #region Constructors

        public Course()
        {
            CourseId = 0;
            CourseName= string.Empty;
            Area = string.Empty;
        }

        public Course(int courseid, string coursename, string area)
        {
            CourseId = courseid;
            CourseName = coursename;
            Area = area;
        }
        #endregion

        #region Methods
        //read all course values
        public virtual void ReadCourse()
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
        public virtual void ListCourse()
        {
            Console.WriteLine($"\n\n{FullCourse}");
        }
        #endregion
    }
}
