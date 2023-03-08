using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E01_Linq_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Clientes> listClients = Clientes.GetClientes();
            Clientes.ListClientLondres(listClients);
            Clientes.ListClientLisboaOuMadrid(listClients);
            Clientes.ListClienteNomeIdade(listClients);
            Clientes.ListClienteEPaisDeOrigiem(listClients);
            Clientes.ListClientMoramLondres(listClients);
            Clientes.ListClientMaisNovoDeLondres(listClients);           

            Utility.TerminateConsole();
        }
    }
}
