using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOADCI
{
    class Presupuesto
    {
        DatabaseLocalDataSet databaseLocalDataSet = new DatabaseLocalDataSet();
        DatabaseLocalDataSetTableAdapters.PresupuestosTableAdapter presupuestosTableAdapter = new DatabaseLocalDataSetTableAdapters.PresupuestosTableAdapter();

        private int numero;
        private String nombre;
        private DateTime fecha;
        private int modPor;
        private Obra obra;          

        public int Numero { get { return numero; } set { numero = value; } }
        public String Nombre { get { return nombre; } set { nombre = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public int ModPor { get { return modPor; } set { modPor = value; } }
        public Obra Obra { get { return obra; } set { obra = value; } }

        public Presupuesto (int numero, String nombre, DateTime fecha, Obra obra, int modPor)
        {
            Numero = numero;
            Nombre = nombre;
            Fecha = fecha;
            ModPor = modPor;
            Obra = obra;
        }

        public Presupuesto (int num)
        {
            presupuestosTableAdapter.Fill(databaseLocalDataSet.Presupuestos);
            DatabaseLocalDataSet.PresupuestosRow presupuestosRow = databaseLocalDataSet.Presupuestos.FindByNumero(num);

            Numero = num;
            Nombre = presupuestosRow.Nombre;
            Fecha = presupuestosRow.Fecha;
            ModPor = presupuestosRow.ModPor;
            Obra = new Obra(presupuestosRow.NumeroObra);
        }

        public void BorrarPagosAsociados()
        {
            DatabaseLocalDataSetTableAdapters.PagosTableAdapter pagosTableAdapter;
            pagosTableAdapter = new DatabaseLocalDataSetTableAdapters.PagosTableAdapter();
            pagosTableAdapter.FillByPresupuesto(databaseLocalDataSet.Pagos, this.Numero);

            Pago pago;

            foreach (DatabaseLocalDataSet.PagosRow row in databaseLocalDataSet.Pagos.Rows)
            {
                pago = new Pago(row.Numero);
                pago.Borrar();
            }
        }


        public void Borrar()
        {
            presupuestosTableAdapter.DeleteByNumero(numero); 

        }

        public void crearCarpetas()
        {
            DatabaseLocalDataSetTableAdapters.CarpetasTableAdapter carpetasTableAdapter;
            carpetasTableAdapter = new DatabaseLocalDataSetTableAdapters.CarpetasTableAdapter();
            carpetasTableAdapter.FillByTipo(databaseLocalDataSet.Carpetas, this.Obra.Tipo.Numero);

            String cadena= @Globales.PATH + "\\" + Obra.Cliente.Nombre + "\\" + Obra.Nombre + "\\" + this.Nombre;

            foreach (DatabaseLocalDataSet.CarpetasRow row in databaseLocalDataSet.Carpetas.Rows)
            {
                Directory.CreateDirectory(cadena + "\\" + row.Nombre);
            }
        }
    }
}
