using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D10_CollectionsGeneric_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dicionario é uma par de key/value
            Utility.SetUnicodeConsole();

            #region Dictionary: criar e inserir valores iniciais
            Dictionary<string, string> listCountries = new Dictionary<string, string>()
            {
                {"PT", "Portugal" },
                {"ES", "Espanha" },
                {"BR", "Brasil" },
                {"VE", "Venezuela" }
            };

            listCountries.Add("MZ", "Moçambique");
            #endregion

            #region Dictionary: listar
            ListDictionary(listCountries);
            #endregion

            #region Dictionary: inserir um pais se não existir na lista
            // 1 pesquisar

            string key = "AN";
            
            if(FindKey(listCountries, key))
            {
                Console.WriteLine("Pais duplicado.");
            }
            else
            {
                string value = "Angola";
                InsertInDictionary(listCountries, key, value);
            }

            #endregion

            #region Dictionary: voltar a listar
            ListDictionary(listCountries);
            #endregion


            Utility.TerminateConsole();
        }

        static void ListDictionary(Dictionary<string, string> listCountries)
        {
            Utility.WriteTitle("Dictionay");
            foreach (KeyValuePair<string, string> item in listCountries)
            {
                Console.WriteLine($"Country: {item.Key} - {item.Value}");
            }
        }

        static bool FindKey(Dictionary<string, string> listCountries, string key)
        {
            bool found = listCountries.ContainsKey(key);
            return found;
        }

        static void InsertInDictionary(Dictionary<string, string> listCountries, string key, string value)
        {
            //string value = key.ToUpper() + "01";
            listCountries.Add(key, value);
        }
    }
}
