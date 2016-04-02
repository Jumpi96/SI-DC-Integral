using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOADCIntegral
{
    class Pago
    {
        private int Numero { get; set; }
        private DateTime Fecha { get; set; }
        private float Monto { get; set; }
        private int CreadoPor { get; set; }
        private int ModPor { get; set; }

        public Pago (int numero, DateTime fecha, float monto, int creadoPor, int modPor)
        {
            Numero = numero;
            Fecha = fecha;
            Monto = monto;
            CreadoPor = creadoPor;
            ModPor = modPor;
        }

    }
}
