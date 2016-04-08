using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOADCI
{
    class Cliente
    {

        private int numero;
        private String nombre;
        private String domicilio;
        private String telFijo;
        private String telCel;
        private String correo;
        private int tipo;
        private int modPor;

        public int Numero { get { return numero; } set { numero = value; } }
        public String Nombre { get { return nombre; } set { nombre = value; } }
        public String Domicilio { get { return domicilio; } set { domicilio = value; } }
        public String TelFijo { get { return telFijo; } set { telFijo = value; } }
        public String TelCel { get { return telCel; } set { telCel = value; } }
        public String Correo { get { return correo; } set { correo = value; } }
        public int Tipo { get { return tipo; } set { tipo = value; } }
        public int ModPor { get { return modPor; } set { modPor = value; } }

        public Cliente(int numero,String nombre,String domicilio,String telFijo, String telCel, String correo, int tipo,
            int modPor)
        {
            Nombre = nombre;
            Numero = numero;
            Domicilio = domicilio;
            TelFijo = telFijo;
            TelCel = telCel;
            Correo = correo;
            Tipo = tipo;
            ModPor = modPor;
        }

        

    }
}
