using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace D02_OOP_Inheritance
{
    public class CourseIT : Course
    {
        #region Properties
        public bool Exam { get; set; }

        public override string FullCourse => $"Course: {CourseId}: {Area} - {CourseName}, Exam? {Exam}";
        //public new string FullCourse => $"Course: {CourseId}: {Area} - {CourseName}, Exam? {Exam}";

        #endregion
        #region Constructors
        public CourseIT() : base()
        {
            Exam = false;
        }

        public CourseIT(int courseid, string coursename, string area, bool exam) : base(courseid, coursename, area)  
        {
            Exam = exam;
        }
        #endregion

        #region Methods
        public override void ReadCourse()
        {
            //invocar o metodo da base classe
            base.ReadCourse();

            //acrescentar o exame
            Console.Write("Course exam (false, true)?");
            Exam = Convert.ToBoolean(Console.ReadLine());
        }

        public override void ListCourse()
        {
            //base.FullCourse;
        }

        #endregion

    }
}
