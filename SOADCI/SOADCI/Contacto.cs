using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOADCI
{
    class Contacto
    {
        private String Nombre { get; set; }
        private String Descripcion { get; set; }
        private String TelCel { get; set; }
        private String Correo { get; set; }
        private int CreadoPor { get; set; }
        private int ModPor { get; set; }

        public Contacto (String nombre, String descripcion, String telCel, String correo, int creadoPor, int modPor)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            TelCel = telCel;
            Correo = correo;
            CreadoPor = creadoPor;
            ModPor = modPor;
        }
    }
}
