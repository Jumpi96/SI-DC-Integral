using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOADCI
{
    class Contacto
    {

        private int numero;
        private String nombre;
        private String descripcion;
        private Cliente cliente;
        private String telefono;
        private String correo;
        private int modPor;

        public int Numero { get { return numero; } set { numero = value; } }
        public String Nombre { get { return nombre; } set { nombre = value; } }
        public String Descripcion { get { return descripcion; } set { descripcion = value; } }
        public Cliente Cliente { get { return cliente; } set { cliente = value; } }
        public String Telefono { get { return telefono; } set { telefono = value; } }
        public String Correo { get { return correo; } set { correo=value; } }
        public int ModPor { get { return ModPor; } set { modPor = value; } }

        public Contacto (int numero, String nombre, String descripcion, Cliente cliente, String telCel, String correo, int modPor)
        {
            Numero = numero;
            Nombre = nombre;
            Descripcion = descripcion;
            Cliente = cliente;
            telefono = telCel;
            Correo = correo;
            ModPor = modPor;
        }
    }
}
