using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial2
{
    class Rol
    {
        private string _NombreRuta;
        private int _NumeroSalida;
        private int _NumeroCamion;
        private string _NombreChofer;



        public string NombreRuta (string nombre)
        {
            _NombreRuta = nombre;

            return _NombreRuta;
        }

        public int NumeroSalida (int numsalida)
        {
            _NumeroSalida = numsalida;

            return _NumeroSalida;
        }

        public int NumeroCamion (int numerocam)
        {
            _NumeroCamion = numerocam;
            return _NumeroCamion;
        }

        public string Chofer (string nombrechofer)
        {
            _NombreChofer = nombrechofer;
            return _NombreChofer;
        }

       
    }
}
