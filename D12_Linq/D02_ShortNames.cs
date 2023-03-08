using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D12_Linq
{
    internal class D02_ShortNames
    {
        // selecionar os nomes mais curtos de uma lista generica de 10 nomes proprios. 
        //identificar o nome mais curto e depois pegar todos que são igual ao mais curto

        public static List<string> CreateNames() 
        {
            List<string> listNames = new List<string>();
            listNames.Add("Tiago");
            listNames.Add("Rui");
            listNames.Add("Manuela");
            listNames.Add("Catarino");
            listNames.Add("Henrique");
            listNames.Add("Ana");
            listNames.Add("Margarida");
            listNames.Add("Francisco");
            listNames.Add("Paula");
            listNames.Add("Ari");

            return listNames;
        }

        public static void ListNames(List<string> listNames)
        {
            //List<string> newList = CreateNames();         
            foreach (var item in listNames)
            {
                Console.WriteLine($"{item}");
            }
        }

        public static void ListShortNames(List<string> listNames)
        {
            var menorNome = (from nome in listNames
                             orderby nome.Length ascending
                            select nome).FirstOrDefault();

            var menoresNomes = from nome in listNames
                               where nome.Length == menorNome.Length
                               orderby nome
                               select nome;

            Utility.WriteTitle("Query Syntax List");                         

            foreach (var nome in menoresNomes)
            {
                Console.WriteLine(nome);
            }
        }

        public static void MethodListShortNames(List<string> listNames)
        {
            List<string> menoresNomes = listNames.Where(nome => nome.Length <= listNames.Min(n => n.Length)).ToList();

            Utility.WriteTitle("Method Syntax List");

            foreach (var nome in menoresNomes)
            {
                Console.WriteLine(nome);
            }
        }

        public static List<int> CriarListNumerosInteiros()
        {
            Random random = new Random();
            List<int> listNumbers = new List<int>();
            for (int i = 0; i < 11; i++)
            {
                int num = random.Next(1, 50);
                listNumbers.Add(num);
            }
            return listNumbers;
        }

        public static void ListNumbers(List<int> listNumbers)
        {
            var filteredNumbers = listNumbers
                .Where(num => num >= 10);

            Utility.WriteTitle("Numeros aleatorios");

            foreach (int num in filteredNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}

