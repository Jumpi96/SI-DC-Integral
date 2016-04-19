using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOADCI
{
    class Pago
    {
        DatabaseLocalDataSet databaseLocalDataSet = new DatabaseLocalDataSet();
        DatabaseLocalDataSetTableAdapters.PagosTableAdapter pagosTableAdapter = new DatabaseLocalDataSetTableAdapters.PagosTableAdapter();

        private int numero;
        private DateTime fecha;
        private float monto;
        private Presupuesto presupuesto;
        private int modPor;

        public int Numero { get { return numero; } set { numero = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public float Monto { get { return monto; } set { monto = value; } }
        public Presupuesto Presupuesto { get { return presupuesto; } set { presupuesto = value; } }
        public int ModPor { get { return modPor; } set { modPor = value; } }

        public Pago (int numero, DateTime fecha, float monto, Presupuesto presupuesto, int modPor)
        {
            Numero = numero;
            Fecha = fecha;
            Presupuesto = presupuesto;
            Monto = monto;
            ModPor = modPor;
        }

        public Pago (int num)
        {
            pagosTableAdapter.Fill(databaseLocalDataSet.Pagos);
            DatabaseLocalDataSet.PagosRow pagosRow = databaseLocalDataSet.Pagos.FindByNumero(num);

            Numero = num;
            Fecha = pagosRow.Fecha;
            ModPor = pagosRow.ModPor;
            Presupuesto = new Presupuesto(pagosRow.NumeroPresupuesto);
        }

        public void Borrar()
        {
            pagosTableAdapter.DeleteByNumero(numero);
        }

    }
}
