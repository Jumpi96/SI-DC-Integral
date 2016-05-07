using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOADCI
{
    class TipoCliente
    {
        private int numero;
        private String descripcion;        

        public int Numero { get { return numero; } set { numero = value; } }
        public String Descripcion { get { return descripcion; } set { descripcion = value; } }

        public TipoCliente (int numero, String descripcion)
        {
            Numero = numero;
            Descripcion = descripcion;
        }

        public TipoCliente (int num)
        {

            DatabaseLocalDataSet databaseLocalDataSet = new DatabaseLocalDataSet();
            DatabaseLocalDataSetTableAdapters.TiposClienteTableAdapter customersTableAdapter1;
            customersTableAdapter1 = new DatabaseLocalDataSetTableAdapters.TiposClienteTableAdapter();
            customersTableAdapter1.Fill(databaseLocalDataSet.TiposCliente);
            DatabaseLocalDataSet.TiposClienteRow tiposClienteRow = databaseLocalDataSet.TiposCliente.FindByNumero(num);


            Numero = num;
            Descripcion = tiposClienteRow.Descripcion;
        }

    }
}
