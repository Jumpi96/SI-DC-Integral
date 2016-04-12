using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOADCI
{
    class Contacto
    {

        private String nombre;
        private String descripcion;
        private int numeroCliente;
        private String telCel;
        private String correo;
        private int modPor;

        public String Nombre { get { return nombre; } set { nombre = value; } }
        public String Descripcion { get { return descripcion; } set { descripcion = value; } }
        public int NumeroCliente { get { return numeroCliente; } set { numeroCliente = value; } }
        public String TelCel { get { return telCel; } set { telCel = value; } }
        public String Correo { get { return correo; } set { correo=value; } }
        public int ModPor { get { return ModPor; } set { modPor = value; } }

        public Contacto (String nombre, String descripcion, int numCli, String telCel, String correo, int modPor)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            NumeroCliente = numCli;
            TelCel = telCel;
            Correo = correo;
            ModPor = modPor;
        }
    }
}
