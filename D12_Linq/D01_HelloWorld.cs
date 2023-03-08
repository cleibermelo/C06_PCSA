using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12_Linq
{
    internal class D01_HelloWorld
    {
        #region HelloWorldMethodsSyntax
        public void HelloWorldMethodsSyntax()
        {
            string[] words =
            {   "t-sql",
                "hello",
                "wonderful",
                "linq",
                "beatiful",
                "world"
            };
            //filtrar os nome com 5 caracteres

            var filteredwords = words
                .Where(w => w.Length == 5)
                .OrderByDescending(w => w)
                .Select(w => w.ToUpper());

            foreach (var word in filteredwords)
            {
                Console.WriteLine(word);
            }
        }
        #endregion

        #region HelloWorldQuerySyntax
        public void HelloWorldQuerySyntax()
        {
            string[] words =
            {   
                "t-sql",
                "hello",
                "wonderful",
                "linq",
                "beatiful",
                "world"
            };
            //filtrar os nome com 5 caracteres

            var filteredwords = from word in words
                where word.Length == 5
                orderby word descending
                select word.ToUpper();

            foreach (var word in filteredwords)
            {
                Console.WriteLine(word);
            }
        }
        #endregion
    }
}
