using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_OOP_Collections_Car.Interfaces
{
    public interface ICar
    {
        #region properties
        int Id { get; }
        string Matricula { get; }
        string Cilindrada { get; }
        int Velocidade { get; }
        DateTime RegistroData { get; }
        #endregion

        #region Methods

        void Parar();
        void Acelerar(int valorAceleracao);
        void Desacelerar(int valorDesaceleracao);
        #endregion

    }
}
