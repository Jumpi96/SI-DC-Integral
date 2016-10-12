using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOADCI
{
    class Obra
    {
        DatabaseFinalDataSet databaseFinalDataSet = new DatabaseFinalDataSet();
        DatabaseFinalDataSetTableAdapters.ObrasTableAdapter obrasTableAdapter;

        private int numero;
        private String nombre;
        private Cliente cliente;
        private int modPor;

        public int Numero { get { return numero; } set { numero = value; } }
        public String Nombre { get { return nombre; } set { nombre = value; } }
        public Cliente Cliente {  get { return cliente; } set { cliente = value; } }
        public int ModPor { get { return modPor; } set { modPor = value; } }

        public Obra (int numero, String nombre, Cliente cliente, int modPor)
        {
            Numero = numero;
            Nombre = nombre;
            Cliente = cliente;
            ModPor = modPor;
        }

        public Obra (int num)
        {
            obrasTableAdapter = new DatabaseFinalDataSetTableAdapters.ObrasTableAdapter();
            obrasTableAdapter.Fill(databaseFinalDataSet.Obras);
            DatabaseFinalDataSet.ObrasRow obrasRow = databaseFinalDataSet.Obras.FindByNumero(num);

            Numero = num;
            Nombre = obrasRow.Nombre;
            Cliente = new Cliente(obrasRow.NumeroCliente);
            ModPor = modPor;
        }


        public void borrarPresupuestosAsociados()
        {
            DatabaseFinalDataSetTableAdapters.PresupuestosTableAdapter presupuestosTableAdapter;
            presupuestosTableAdapter = new DatabaseFinalDataSetTableAdapters.PresupuestosTableAdapter();
            presupuestosTableAdapter.FillByObra(databaseFinalDataSet.Presupuestos,this.Numero);

            Presupuesto pres;

            foreach(DatabaseFinalDataSet.PresupuestosRow row in databaseFinalDataSet.Presupuestos.Rows)
            {
                pres = new Presupuesto(row.Numero);
                pres.Borrar();
            }
        }

        public void Borrar()
        {
            borrarPresupuestosAsociados();
            obrasTableAdapter.DeleteByNumero(numero);
        }

    }
}
