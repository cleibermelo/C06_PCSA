using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D11_CollectionsGeneric_IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region IList<T>
            EvenNumber evenListNumbers01 = new EvenNumber();

            IList<int> listNumbers01 = evenListNumbers01.CreateEvenNumbersList(4);

            Console.WriteLine($"IList<T>");

            foreach (int item in listNumbers01)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region IEnumerable<T>

            EvenNumber evenListNumbers02 = new EvenNumber();

            IEnumerable<int> listNumbers02 = evenListNumbers02.CreateEvenNumbersIEnumerable(4);

            Utility.WriteTitle("IEnumerable");

            foreach (int item in listNumbers02)
            {
                Console.WriteLine(item);
            }
            #endregion

            Utility.TerminateConsole();
        }
    }
}
