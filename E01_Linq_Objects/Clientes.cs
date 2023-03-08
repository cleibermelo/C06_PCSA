using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E01_Linq_Objects
{
    public class Clientes
    {
        #region Properties
        public string Nome { get; set; }
        public string Localidade { get; set; }
        public int Idade { get; set; }
        #endregion

        #region Metodo GetClientes
        public static List<Clientes> GetClientes()
        {
            List<Clientes> clientes = new List<Clientes>
            {
                new Clientes { Nome = "Amália", Localidade = "Porto", Idade = 35},
                new Clientes { Nome = "John", Localidade = "Londres", Idade = 35},
                new Clientes { Nome = "Charles", Localidade = "Londres", Idade = 53},
                new Clientes { Nome = "Lucy", Localidade = "Paris", Idade = 21},
                new Clientes { Nome = "Javi", Localidade = "Madrid", Idade = 14}
            };
            return clientes;
        }
        #endregion

        #region List Client Londres
        public static void ListClientLondres(List<Clientes> clientes)
        {
            var nomeClientes = clientes.Where(c => c.Localidade == "Londres")
                                       .Select(c => c.Nome);

            Utility.WriteTitle("\n2.1 - Nome dos clientes da cidade de Londres");

            foreach (var nome in nomeClientes)
            {
                Console.WriteLine($"Cliente: {nome}");
            }
        }
        #endregion

        #region List Client Lisboa Ou Madrid
        public static void ListClientLisboaOuMadrid(List<Clientes> clientes)
        {
            var nomeClientes = clientes.Where(c => c.Localidade == "Lisboa" || c.Localidade == "Madrid")
                                       .Select(c => c.Nome);

            Utility.WriteTitle("\n2.2 - Nome dos clientes da cidade de Lisboa ou Madrid.");

            foreach (var nome in nomeClientes)
            {
                Console.WriteLine($"Cliente: {nome}");
            }
        }
        #endregion

        #region List Cliente Nome Idade formatado
        public static void ListClienteNomeIdade(List<Clientes> clientes)
        {
            var nomeClientes = clientes.Where(c => c.Idade > 18)
                                        .OrderByDescending(c => c.Idade)
                                        .Select(c => new {Nome = c.Nome, Idade = c.Idade});

            Utility.WriteTitle("\n2.3 - Listar clientes com mais de 18 anos e ordenada pela idade, descendentemente.");

            foreach (var nome in nomeClientes)
            {
                Console.WriteLine($"Cliente: {nome.Nome} - {nome.Idade}");
            }
        }
        #endregion

        #region List Clientes Moram Londres
        public static void ListClientMoramLondres(List<Clientes> clientes)
        {
            var nomeClientes = clientes.Count(c => c.Localidade == "Londres");

            Utility.WriteTitle("\n2.5 - Número de clientes que moram em Londres.");

            Console.WriteLine($"Quantidade: {nomeClientes}");
        }
        #endregion

        #region List Cliente Mais Novo De Londres
        public static void ListClientMaisNovoDeLondres(List<Clientes> clientes)
        {
            var nomeClientes = clientes.Where(c => c.Localidade == "Londres")
                .OrderBy(c => c.Idade)
                .FirstOrDefault();

            Utility.WriteTitle("\n2.6 - O cliente mais novo que mora em Londres..");

            Console.WriteLine($"Cliente: {nomeClientes.Nome}");
        }
        #endregion

        #region List Cliente Mais Novo De Londres
        public static void ListClienteEPaisDeOrigiem(List<Clientes> clientes)
        {
            List<Cidade> cidade = Cidade.GetCidade();
            var nomeClientes = clientes.Join(cidade, c => c.Localidade,
                                             cd => cd.Localidade,
                                             (c, cd) => new { Nome = c.Nome, Pais = cd.Pais });

            Utility.WriteTitle("\n2.4 - O nome dos clientes e o país de origem.");

            foreach (var nome in nomeClientes)
            {
                Console.WriteLine($"Cliente: {nome.Nome} - {nome.Pais}");
            }
        }
        #endregion
    }
}
