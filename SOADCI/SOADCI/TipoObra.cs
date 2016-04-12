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
        private List<int> arregloCarpetas = new List<int>();

        public int Numero { get { return numero; } set { numero = value; } }
        public String Descripcion { get { return descripcion; } set { descripcion = value; } }
        public List<int> ArregloCarpetas { get { return arregloCarpetas; } set { arregloCarpetas = value; } }

        public TipoObra(int numero, String descripcion, List<int> arregloCarpetas)
        {
            Numero = numero;
            Descripcion = descripcion;
            ArregloCarpetas = arregloCarpetas;
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
            llenarLista(num);
        }

        private void llenarLista(int num)
        {

        }
    }
}
