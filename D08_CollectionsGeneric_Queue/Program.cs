using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

//queue --> fila --> fifo first-in, first-out

namespace D08_CollectionsGeneric_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region Queue inteiros (fila) --> (fifo)

            Queue<int> queueIntegers= new Queue<int>();

            for (int i = 0; i < 5; i++)
            {
                queueIntegers.Enqueue(i);
            }

            queueIntegers.Enqueue(10);
            queueIntegers.Enqueue(11);

            Utility.WriteTitle("\nQueue");

            int countQueueIntegers = queueIntegers.Count();

            Console.WriteLine($"\nCount: {countQueueIntegers}");


            foreach (int item in queueIntegers)
            {
                Console.WriteLine($"Value: {item}, Count: {countQueueIntegers}");
            }

            Utility.WriteTitle("Dequeue");
            for (int i = 0; i < countQueueIntegers; i++)
            {                
                Console.WriteLine($"Value: {queueIntegers.Dequeue()}");
            }          

            #endregion
            Utility.TerminateConsole();

        }
    }
}
