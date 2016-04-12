using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOADCI
{
    class Obra
    {
        private int numero;
        private String nombre;
        private Cliente cliente;
        private TipoObra tipo;
        private int modPor;

        public int Numero { get { return numero; } set { numero = value; } }
        public String Nombre { get { return nombre; } set { nombre = value; } }
        public Cliente Cliente {  get { return cliente; } set { cliente = value; } }
        public TipoObra Tipo { get { return tipo; } set { tipo = value; } }
        public int ModPor { get { return modPor; } set { modPor = value; } }

        public Obra (int numero, String nombre, Cliente cliente, TipoObra tipo, int modPor)
        {
            Numero = numero;
            Nombre = nombre;
            Cliente = cliente;
            Tipo = tipo;
            ModPor = modPor;
        }

    }
}
