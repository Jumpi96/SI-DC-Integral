using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOADCI
{
    class Presupuesto
    {

        private int numero;
        private String nombre;
        private DateTime fecha;
        private int modPor;
        private int numObra;          

        public int Numero { get { return numero; } set { numero = value; } }
        public String Nombre { get { return nombre; } set { nombre = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public int ModPor { get { return modPor; } set { modPor = value; } }
        public int NumObra { get { return numObra; } set { numObra = value; } }

        public Presupuesto (int numero, String nombre, DateTime fecha, int numObra, int modPor)
        {
            Numero = numero;
            Nombre = nombre;
            Fecha = fecha;
            ModPor = modPor;
            NumObra = numObra;
        }

        public Presupuesto (int num)
        {
            DatabaseLocalDataSet databaseLocalDataSet = new DatabaseLocalDataSet();
            DatabaseLocalDataSetTableAdapters.PresupuestosTableAdapter presupuestosTableAdapter;
            presupuestosTableAdapter = new DatabaseLocalDataSetTableAdapters.PresupuestosTableAdapter();
            presupuestosTableAdapter.Fill(databaseLocalDataSet.Presupuestos);
            DatabaseLocalDataSet.PresupuestosRow presupuestosRow = databaseLocalDataSet.Presupuestos.FindByNumero(num);

            Numero = num;
            Nombre = presupuestosRow.Nombre;
            Fecha = presupuestosRow.Fecha;
            ModPor = presupuestosRow.ModPor;
            Obra = new Obra(presupuestosRow.NumeroObra);
        }


        public void Borrar()
        {

        }
    }
}
