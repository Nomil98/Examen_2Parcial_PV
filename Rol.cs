using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolución_Examen2
{
    class Rol
    {
        public int Economico { get; set; }
        public string Chofer { get; set; }
        public string Salida { get; set; }
        public string Ruta { get; set; }

        public Rol (int economico, string chofer, string salida, string ruta)
        {
            Economico = economico;
            Chofer = chofer;
            Salida = salida;
            Ruta = ruta;
        }

        public override string ToString()
        {
            return "camión" + Economico + "-->" + Ruta + "(" + Salida + ")" + Chofer;

        }
    }
}
