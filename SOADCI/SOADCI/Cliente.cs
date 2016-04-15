using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOADCI
{
    class Cliente
    {

        DatabaseLocalDataSet databaseLocalDataSet = new DatabaseLocalDataSet();

        private int numero;
        private String nombre;
        private String domicilio;
        private String telFijo;
        private String telCel;
        private String correo;
        private TipoCliente tipo;
        private int modPor;

        public int Numero { get { return numero; } set { numero = value; } }
        public String Nombre { get { return nombre; } set { nombre = value; } }
        public String Domicilio { get { return domicilio; } set { domicilio = value; } }
        public String TelFijo { get { return telFijo; } set { telFijo = value; } }
        public String TelCel { get { return telCel; } set { telCel = value; } }
        public String Correo { get { return correo; } set { correo = value; } }
        public TipoCliente Tipo { get { return tipo; } set { tipo = value; } }
        public int ModPor { get { return modPor; } set { modPor = value; } }

        public Cliente(int numero, String nombre, String domicilio, String telFijo, String telCel, String correo, TipoCliente tipo,
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

        public Cliente(int numCliente)
        {
            databaseLocalDataSet = new DatabaseLocalDataSet();
            DatabaseLocalDataSetTableAdapters.ClientesTableAdapter customersTableAdapter1;
            customersTableAdapter1 = new DatabaseLocalDataSetTableAdapters.ClientesTableAdapter();
            customersTableAdapter1.Fill(databaseLocalDataSet.Clientes);
            DatabaseLocalDataSet.ClientesRow clientesRow = databaseLocalDataSet.Clientes.FindByNumero(numCliente);

            Nombre = clientesRow.Nombre;
            Numero = numCliente;
            Domicilio = clientesRow.Domicilio;
            TelFijo = clientesRow.TelFijo;
            TelCel = clientesRow.TelCel;
            Correo = clientesRow.Correo;
            Tipo = new TipoCliente(clientesRow.Tipo);
            ModPor = clientesRow.ModPor;
        }

        public void borrarObrasAsociadas()
        {
            DatabaseLocalDataSetTableAdapters.ObrasTableAdapter obrasTableAdapter;
            obrasTableAdapter = new DatabaseLocalDataSetTableAdapters.ObrasTableAdapter();
            obrasTableAdapter.FillObrasPorCliente(databaseLocalDataSet.Obras, this.Numero);
            Obra obra;

            foreach (DatabaseLocalDataSet.ObrasRow row in databaseLocalDataSet.Obras.Rows)
            {
                obra = new Obra(row.Numero);
                obra.Borrar();
            }

        }

        public void borrarContactosAsociados()
        {
            DatabaseLocalDataSetTableAdapters.ContactosTableAdapter contactosTableAdapter;
            contactosTableAdapter = new DatabaseLocalDataSetTableAdapters.ContactosTableAdapter();
            contactosTableAdapter.FillContactosPorCliente(databaseLocalDataSet.Contactos, this.Numero);
            Contacto contacto;

            foreach (DatabaseLocalDataSet.ObrasRow row in databaseLocalDataSet.Obras.Rows)
            {
                contacto = new Contacto(row.Numero);
                contacto.Borrar();
            }

        }




    }
}
