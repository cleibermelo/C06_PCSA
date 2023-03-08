using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

// stack --> pilha --> lifo (last-in - first-out)

namespace D09_CollectionsGeneric_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region Stack inteiros - Pilha (lifo)

            Stack<int> stackIntegers = new Stack<int>();
            

            for (int i = 0; i < 6; i++)
            {
                stackIntegers.Push(i);
            }

            int stackIntegersCount = stackIntegers.Count;

            Utility.WriteTitle("\nStack Push");

            foreach (int item in stackIntegers)
            {
                Console.WriteLine($"Value: {item}");
            }

            Utility.WriteTitle("\nStack Pop");

            for (int i = 0; i < stackIntegersCount; i++)
            {
                Console.WriteLine($"Value: {stackIntegers.Pop()}");
            }
            #endregion

            Utility.TerminateConsole();
        }
    }
}
