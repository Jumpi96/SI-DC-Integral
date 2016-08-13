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
        DatabaseFinalDataSet databaseFinalDataSet = new DatabaseFinalDataSet();
        DatabaseFinalDataSetTableAdapters.PresupuestosTableAdapter presupuestosTableAdapter = new DatabaseFinalDataSetTableAdapters.PresupuestosTableAdapter();

        private int numero;
        private String nombre;
        private DateTime fecha;
        private int modPor;
        private Obra obra;
        private Estado estado;
        private TipoPresupuesto tipo;

        public int Numero { get { return numero; } set { numero = value; } }
        public String Nombre { get { return nombre; } set { nombre = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public int ModPor { get { return modPor; } set { modPor = value; } }
        public Obra Obra { get { return obra; } set { obra = value; } }
        public Estado Estado { get { return estado; } set { estado = value; } }
        public TipoPresupuesto Tipo { get { return tipo; } set { tipo = value; } }


        public Presupuesto (int numero, String nombre, DateTime fecha, Obra obra, int modPor, Estado estado, TipoPresupuesto tipo)
        {
            Numero = numero;
            Nombre = nombre;
            Fecha = fecha;
            ModPor = modPor;
            Obra = obra;
            Estado = estado;
            Tipo = tipo;
        }

        public Presupuesto (int num)
        {
            presupuestosTableAdapter.Fill(databaseFinalDataSet.Presupuestos);
            DatabaseFinalDataSet.PresupuestosRow presupuestosRow = databaseFinalDataSet.Presupuestos.FindByNumero(num);

            Numero = num;
            Nombre = presupuestosRow.Nombre;
            Fecha = presupuestosRow.Fecha;
            ModPor = presupuestosRow.ModPor;
            Obra = new Obra(presupuestosRow.NumeroObra);
            Estado = new Estado(presupuestosRow.Estado);
            Tipo = new TipoPresupuesto(presupuestosRow.Tipo);
        }

        public void BorrarPagosAsociados()
        {
            DatabaseFinalDataSetTableAdapters.PagosTableAdapter pagosTableAdapter;
            pagosTableAdapter = new DatabaseFinalDataSetTableAdapters.PagosTableAdapter();
            pagosTableAdapter.FillByPresupuesto(databaseFinalDataSet.Pagos, this.Numero);

            Pago pago;

            foreach (DatabaseFinalDataSet.PagosRow row in databaseFinalDataSet.Pagos.Rows)
            {
                pago = new Pago(row.Numero);
                pago.Borrar();
            }
        }


        public void Borrar()
        {
            this.BorrarPagosAsociados();
            presupuestosTableAdapter.DeleteByNumero(numero); 

        }

        public void crearCarpetas()
        {
            DatabaseFinalDataSetTableAdapters.CarpetasTableAdapter carpetasTableAdapter;
            carpetasTableAdapter = new DatabaseFinalDataSetTableAdapters.CarpetasTableAdapter();
            carpetasTableAdapter.FillByTipo(databaseFinalDataSet.Carpetas, Tipo.Numero);

            String cadena= Globales.getInstancia().PATH + "\\" + Obra.Cliente.Nombre + "\\" + Obra.Nombre + "\\" + this.Nombre;

            foreach (DatabaseFinalDataSet.CarpetasRow row in databaseFinalDataSet.Carpetas.Rows)
            {
                Directory.CreateDirectory(cadena + "\\" + row.Nombre);
            }
        }

        public void Imprimir()
        {
            EmitirReportePresupuesto rep = new EmitirReportePresupuesto();
            rep.LoadOrders(this);
            rep.ShowDialog();
        }
    }
}
