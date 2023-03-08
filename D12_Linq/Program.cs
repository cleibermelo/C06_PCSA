using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D12_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //D01_HelloWorld words = new D01_HelloWorld();
            //Utility.WriteTitle("Hello World Methods Syntax");
            //words.HelloWorldMethodsSyntax();
            //Utility.WriteTitle("Hello World Query Syntax");
            //words.HelloWorldQuerySyntax();


            List<string> listNames = D02_ShortNames.CreateNames();
            List<int> listNumbers = D02_ShortNames.CriarListNumerosInteiros();

            D02_ShortNames.ListNames(listNames);

            D02_ShortNames.ListShortNames(listNames);

            D02_ShortNames.MethodListShortNames(listNames);

            D02_ShortNames.ListNumbers(listNumbers);





            Utility.TerminateConsole();
        }
    }
}
