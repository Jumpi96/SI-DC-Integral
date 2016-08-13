using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SOADCI
{
    public class Globales
    {
        private String path;
        private String pass;
        private static Globales instancia;

        public String PATH { get { return getInstancia().path; } }
        public String PASS { get { return getInstancia().pass; } }

        public static Globales getInstancia()
        {
            if (instancia == null)
                instancia = new Globales();
            return instancia;
        }

        private Globales()
        {
            path = ConfigurationManager.AppSettings["path"];
            pass = ConfigurationManager.AppSettings["pass"];
        }


        /*
        public const String PATH = "D:" + "\\" + "Desarrollo-Programación" + "\\" + "SI DC Integral" + "\\" + "Raíz";
        public const String PASS = "jero";
        */
    }
}

// S2009Daniel
