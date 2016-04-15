using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOADCI
{
    class Obra
    {
        DatabaseLocalDataSet databaseLocalDataSet = new DatabaseLocalDataSet();

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

        public Obra (int num)
        {
            DatabaseLocalDataSetTableAdapters.ObrasTableAdapter obrasTableAdapter;
            obrasTableAdapter = new DatabaseLocalDataSetTableAdapters.ObrasTableAdapter();
            obrasTableAdapter.Fill(databaseLocalDataSet.Obras);
            DatabaseLocalDataSet.ObrasRow obrasRow = databaseLocalDataSet.Obras.FindByNumero(num);

            Numero = num;
            Nombre = obrasRow.Nombre;
            Cliente = new Cliente(obrasRow.NumeroCliente);
            Tipo = new TipoObra(obrasRow.Tipo);
            ModPor = modPor;
        }


        public void borrarPresupuestosAsociados()
        {
            DatabaseLocalDataSetTableAdapters.PresupuestosTableAdapter presupuestosTableAdapter;
            presupuestosTableAdapter = new DatabaseLocalDataSetTableAdapters.PresupuestosTableAdapter();
            presupuestosTableAdapter.FillByObra(databaseLocalDataSet.Presupuestos,this.Numero);

            Presupuesto pres;

            foreach(DatabaseLocalDataSet.PresupuestosRow row in databaseLocalDataSet.Presupuestos.Rows)
            {
                pres = new Presupuesto(row.Numero);
                pres.Borrar();
            }
        }

    }
}
