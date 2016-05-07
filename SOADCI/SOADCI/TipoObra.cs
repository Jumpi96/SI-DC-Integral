using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOADCI
{
    class TipoObra
    {
        private int numero;
        private String descripcion;

        public int Numero { get { return numero; } set { numero = value; } }
        public String Descripcion { get { return descripcion; } set { descripcion = value; } }

        public TipoObra(int numero, String descripcion)
        {
            Numero = numero;
            Descripcion = descripcion;
        }

        public TipoObra(int num)
        {

            DatabaseLocalDataSet databaseLocalDataSet = new DatabaseLocalDataSet();
            DatabaseLocalDataSetTableAdapters.TiposObraTableAdapter customersTableAdapter1;
            customersTableAdapter1 = new DatabaseLocalDataSetTableAdapters.TiposObraTableAdapter();
            customersTableAdapter1.Fill(databaseLocalDataSet.TiposObra);
            DatabaseLocalDataSet.TiposObraRow tiposObraRow = databaseLocalDataSet.TiposObra.FindByNumero(num);


            Numero = num;
            Descripcion = tiposObraRow.Descripcion;
        }

    }
}
