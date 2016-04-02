using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOADCIntegral
{
    class TipoObra
    {
        private int Numero;
        private String Descripcion;
        private List<int> ArregloCarpetas = new List<int>();

        public TipoObra (int numero, String descripcion, List<int> arregloCarpetas)
        {
            Numero = numero;
            Descripcion = descripcion;
            ArregloCarpetas = arregloCarpetas;
        }
    }
}
