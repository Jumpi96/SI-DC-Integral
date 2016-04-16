using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOADCI
{
    class Contacto
    {

        DatabaseLocalDataSet databaseLocalDataSet = new DatabaseLocalDataSet();
        DatabaseLocalDataSetTableAdapters.ContactosTableAdapter contactosTableAdapter;

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
            Telefono = telCel;
            Correo = correo;
            ModPor = modPor;
        }

        public Contacto(int num) {
            databaseLocalDataSet = new DatabaseLocalDataSet(); 
            contactosTableAdapter = new DatabaseLocalDataSetTableAdapters.ContactosTableAdapter();
            contactosTableAdapter.Fill(databaseLocalDataSet.Contactos);
            DatabaseLocalDataSet.ContactosRow contactosRow = databaseLocalDataSet.Contactos.FindByNumero(num);

            Numero = num;
            Nombre = contactosRow.Nombre;
            Descripcion = contactosRow.Descripcion;
            Cliente = new Cliente(contactosRow.NumeroCliente);
            Telefono = contactosRow.Telefono;
            Correo = contactosRow.Correo;
            ModPor = contactosRow.ModPor;

        }

        public void Borrar()
        {
            contactosTableAdapter.DeleteByNumero(numero);
        }
    }
}
