using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOADCI
{
    class Estado
    {
        private int numero;
        private String nombre;

        public int Numero { get { return numero; } set { numero = value; } }
        public String Nombre { get { return nombre; } set { nombre = value; } }

        public Estado(int numero, String nombre)
        {
            Numero = numero;
            Nombre = nombre;
        }

        public Estado(int num)
        {

            DatabaseLocalDataSet databaseLocalDataSet = new DatabaseLocalDataSet();
            DatabaseLocalDataSetTableAdapters.EstadosTableAdapter customersTableAdapter1;
            customersTableAdapter1 = new DatabaseLocalDataSetTableAdapters.EstadosTableAdapter();
            customersTableAdapter1.Fill(databaseLocalDataSet.Estados);
            DatabaseLocalDataSet.EstadosRow estadoRow = databaseLocalDataSet.Estados.FindByNumero(num);


            Numero = num;
            Nombre = estadoRow.Nombre;
        }

    }
}
