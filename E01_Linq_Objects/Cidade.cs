using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_Linq_Objects
{
    public class Cidade
    {
        #region Properties
        public string Localidade { get; set; }
        public string Pais { get; set; }
        #endregion

        public static List<Cidade> GetCidade()
        {
            List<Cidade> cidade = new List<Cidade>
            {
                new Cidade { Localidade = "Porto", Pais = "Portugal"},
                new Cidade { Localidade = "Londres", Pais = "Inglaterra"},
                new Cidade { Localidade = "Paris", Pais = "França"},
                new Cidade { Localidade = "Madrid", Pais = "Espanha"},
            };
            return cidade;
        }
    }

    //List<Cidade> cidades = new List<Cidade>();

    //Cidade cidade1 = new Cidade { Localidade = "Porto", Pais = "Portugal" };
    //cidades.Add(cidade1);
}
