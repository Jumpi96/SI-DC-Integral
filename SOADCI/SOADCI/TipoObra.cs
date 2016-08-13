using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOADCI
{
    class TipoPresupuesto
    {
        private int numero;
        private String descripcion;

        public int Numero { get { return numero; } set { numero = value; } }
        public String Descripcion { get { return descripcion; } set { descripcion = value; } }

        public TipoPresupuesto(int numero, String descripcion)
        {
            Numero = numero;
            Descripcion = descripcion;
        }

        public TipoPresupuesto(int num)
        {

            DatabaseFinalDataSet databaseFinalDataSet = new DatabaseFinalDataSet();
            DatabaseFinalDataSetTableAdapters.TiposPresupuestoTableAdapter customersTableAdapter1;
            customersTableAdapter1 = new DatabaseFinalDataSetTableAdapters.TiposPresupuestoTableAdapter();
            customersTableAdapter1.Fill(databaseFinalDataSet.TiposPresupuesto);
            DatabaseFinalDataSet.TiposPresupuestoRow tiposObraRow = databaseFinalDataSet.TiposPresupuesto.FindByNumero(num);

            Numero = num;
            Descripcion = tiposObraRow.Descripcion;
        }

    }
}
