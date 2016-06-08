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

            DatabaseFinalDataSet databaseFinalDataSet = new DatabaseFinalDataSet();
            DatabaseFinalDataSetTableAdapters.EstadosTableAdapter customersTableAdapter1;
            customersTableAdapter1 = new DatabaseFinalDataSetTableAdapters.EstadosTableAdapter();
            customersTableAdapter1.Fill(databaseFinalDataSet.Estados);
            DatabaseFinalDataSet.EstadosRow estadoRow = databaseFinalDataSet.Estados.FindByNumero(num);


            Numero = num;
            Nombre = estadoRow.Nombre;
        }

    }
}
