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
        /* private String path;
         private String pass;
         private String archivos;*/
        private static Globales instancia;

        public String PATH { get { return Properties.Settings.Default.Path; }
            set { Properties.Settings.Default.Path = value; Properties.Settings.Default.Save(); } }
        public String PASS { get { return Properties.Settings.Default.Pass; }
            set { Properties.Settings.Default.Pass = value;  Properties.Settings.Default.Save(); } }
        public String ARCHIVOS { get { return Properties.Settings.Default.Archivos; }
            set { Properties.Settings.Default.Archivos = value; Properties.Settings.Default.Save(); } }

        public static Globales getInstancia()
        {
            if (instancia == null)
                instancia = new Globales();
            return instancia;
        }

        private Globales()
        {/*
            path = ConfigurationManager.AppSettings["path"];
            pass = ConfigurationManager.AppSettings["pass"];
            archivos = ConfigurationManager.AppSettings["archivos"];*/
        }


        /*
        public const String PATH = "D:" + "\\" + "Desarrollo-Programación" + "\\" + "SI DC Integral" + "\\" + "Raíz";
        public const String PASS = "jero";
        */
    }
}

// S2009Daniel
