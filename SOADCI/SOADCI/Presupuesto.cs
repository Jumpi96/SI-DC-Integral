using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOADCI
{
    class Presupuesto
    {
        private int Numero { get; set; }
        private String Nombre { get; set; }
        private DateTime Fecha { get; set; }
        private int CreadoPor { get; set; }
        private int ModPor { get; set; }

        public Presupuesto (int numero, String nombre, DateTime fecha, int creadoPor, int modPor)
        {
            Numero = numero;
            Nombre = nombre;
            Fecha = fecha;
            CreadoPor = creadoPor;
            ModPor = modPor;
        }

    }
}
