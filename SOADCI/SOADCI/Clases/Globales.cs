using System;


namespace SOADCI
{
    public class Globales
    {
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
        {
        }


    }
}

