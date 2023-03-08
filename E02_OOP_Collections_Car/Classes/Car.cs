using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E02_OOP_Collections_Car.Interfaces;
using D00_Utility;

namespace E02_OOP_Collections_Car.Classes
{
    public class Car : ICar
    {
        #region Enums
        public enum EnumMarca
        {
            Fiat,
            Opel,
            Renault
        }

        public enum EnumModelo
        {
            Tipo,
            Panda,
            Corsa,
            Zafira,
            Clio,
            Megane
        }

        public enum EnumCor
        {
            Branco,
            Preto,
            Cinza,
            Vermelho,
            Azul,
            Amarelo
        }
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Matricula { set; get; }
        public string Cilindrada { set; get; }
        public int Velocidade { set; get; }
        public DateTime RegistroData { set; get; }
        public EnumMarca? Marca { get; set; }
        public EnumModelo? Modelo { get; set; }
        public EnumCor? Cor { get; set; }
        #endregion

        #region Constructors
        public Car()
        {
            Id = 0;
            Marca = null;
            Modelo = null;
            Matricula = "";
            Cilindrada = string.Empty;
            Velocidade = 0;
            RegistroData= DateTime.MinValue;
        }

        public Car(int id, string matricula, string cilindrada, int velocidade, DateTime registroData, EnumMarca marca, EnumModelo modelo, EnumCor cor)
        {
            Id = id;
            Matricula = matricula;
            Cilindrada = cilindrada;
            Velocidade = velocidade;
            RegistroData = registroData;
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
        }

        public Car(int id, EnumMarca marca, EnumModelo modelo, string cilindrada)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada;
        }
        #endregion

        #region Destrucutor
        ~Car()
        {
            Console.WriteLine("finalizar ação...");
        }
        #endregion

        #region Lista
        List<Car> listCar = new List<Car>
        {

        };
        #endregion

        #region Methods
        public void Acelerar(int valorAceleracao)
        {
            Utility.WriteTitle("\nAcelerando Carro");
            Velocidade += valorAceleracao;
            Console.WriteLine($"Velocidade Atual: {Velocidade} km/h");
        }
        public void Desacelerar(int valorDesaceleracao)
        {
            Utility.WriteTitle("\nDesacelerando Carro");
            Velocidade = Velocidade - valorDesaceleracao;
            Console.WriteLine($"Velocidade Atual: {Velocidade} km/h");
        }
        public void Parar()
        {
            Utility.WriteTitle("\nParando Carro");
            Velocidade = 0;
            Console.WriteLine($"Velocidade Atual: {Velocidade} km/h");
        }
        public void Criar() 
        {
            //Car cardata = new Car();
            string acao;
            Utility.WriteTitle("Criar Carros");
            Console.Write("\nAção: ");
            acao = Console.ReadLine();
            while (acao == "criar")
            {
                Console.Write("\nMarca: ");
                string marca = Console.ReadLine();
                Console.Write("\nModelo: ");
                string modelo = Console.ReadLine();
                Console.Write("\nCor: ");
                string cor = Console.ReadLine();
                Console.Write("\nMatricula: ");
                string matricula = Console.ReadLine();
                Console.Write("\nCilindrada: ");
                string cilindrada = Console.ReadLine();
                Console.Write("\nVelocidade: ");
                int velocidade = int.Parse(Console.ReadLine());
                Console.Write("\nData Registo: ");
                DateTime registroData = DateTime.Parse(Console.ReadLine());

                if (Enum.IsDefined(typeof(EnumMarca), marca) && Enum.IsDefined(typeof(EnumModelo), modelo) && Enum.IsDefined(typeof(EnumCor), cor))
                {
                    Car newCar = new Car 
                    { 
                        Id = listCar.Count + 1, 
                        Marca = (EnumMarca?)Enum.Parse(typeof(EnumMarca), marca), 
                        Modelo = (EnumModelo?)Enum.Parse(typeof(EnumModelo), modelo), 
                        Cor = (EnumCor?)Enum.Parse(typeof(EnumCor), cor), 
                        Matricula = matricula, 
                        Cilindrada = cilindrada, 
                        Velocidade = velocidade, 
                        RegistroData = registroData 
                    };

                    listCar.Add(newCar);
                    Console.WriteLine($"\nCarId: {newCar.Id}, Matricula: {newCar.Matricula}, Marca: {newCar.Marca}, Modelo: {newCar.Modelo} Cor: {newCar.Cor}, Cilindrada: {newCar.Cilindrada}, Velocidade: {newCar.Velocidade}, Data Registo: {newCar.RegistroData.ToShortDateString()} successfully!");
                }
                else
                {
                    Console.WriteLine("Valores não encontrado.");
                }
                Utility.TerminateConsole();
                Console.Write("\nAção: ");
                acao = Console.ReadLine();
            }
        }
        public void Listar()
        {
            Utility.WriteTitle("Lista Carros");
            foreach (var item in listCar)
            {
                Console.WriteLine($"Id: {item.Id}, Matricula: {item.Matricula}, Marca: {item.Marca}, Modelo: {item.Modelo}, Cor: {item.Cor}, Cilindrada: {item.Cilindrada}, Velocidade: {item.Velocidade}, Data Registro: {item.RegistroData.ToShortDateString()}");
            }
        }
        #endregion
    }
}
