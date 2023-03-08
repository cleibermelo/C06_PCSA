using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;
using E02_OOP_Collections_Car.Classes;

namespace E02_OOP_Collections_Car
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car();
            car.Criar();
            car.Listar();
            car.Acelerar(20);
            car.Acelerar(40);
            car.Acelerar(20);
            car.Desacelerar(20);
            car.Desacelerar(40);
            car.Parar();

            Utility.TerminateConsole();
        }
    }
}
