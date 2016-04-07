using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOADCI
{
    class Obra
    {
        private int Numero { get; set; }
        private String Nombre { get; set; }
        private int Tipo { get; set; }
        private int CreadoPor { get; set; }
        private int ModPor { get; set; }

        public Obra (int numero, String nombre, int tipo, int creadoPor, int modPor)
        {
            Numero = numero;
            Nombre = nombre;
            Tipo = tipo;
            CreadoPor = creadoPor;
            ModPor = modPor;
        }

    }
}
