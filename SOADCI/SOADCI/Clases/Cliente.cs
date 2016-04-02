using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOADCIntegral
{
    class Cliente
    {
        private int Numero { get; set; }
        private String Nombre { get; set; }
        private String Domicilio { get; set; }
        private String TelFijo { get; set; }
        private String TelCel { get; set; }
        private String Correo { get; set; }
        private int Tipo { get; set; }
        private int CreadoPor { get; set; }
        private int ModPor { get; set; }

        public Cliente(int numero,String nombre,String domicilio,String telFijo, String telCel, String correo, int tipo,
            int creadoPor, int modPor)
        {
            Numero = numero;
            Domicilio = domicilio;
            TelFijo = telFijo;
            TelCel = telCel;
            Correo = correo;
            Tipo = tipo;
            CreadoPor = creadoPor;
            ModPor = modPor;
        }

        

    }
}
