﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOADCI
{
    class Pago
    {
        DatabaseFinalDataSet databaseFinalDataSet = new DatabaseFinalDataSet();
        DatabaseFinalDataSetTableAdapters.PagosTableAdapter pagosTableAdapter = new DatabaseFinalDataSetTableAdapters.PagosTableAdapter();

        private int numero;
        private DateTime fecha;
        private float monto;
        private Presupuesto presupuesto;
        private int modPor;
        private String detalle;

        public int Numero { get { return numero; } set { numero = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public float Monto { get { return monto; } set { monto = value; } }
        public Presupuesto Presupuesto { get { return presupuesto; } set { presupuesto = value; } }
        public int ModPor { get { return modPor; } set { modPor = value; } }
        public String Detalle { get { return detalle; } set { detalle = value; } }

        public Pago (int numero, DateTime fecha, float monto, Presupuesto presupuesto, int modPor, String detalle)
        {
            Numero = numero;
            Fecha = fecha;
            Presupuesto = presupuesto;
            Monto = monto;
            ModPor = modPor;
            Detalle = detalle;
        }

        public Pago (int num)
        {
            pagosTableAdapter.Fill(databaseFinalDataSet.Pagos);
            DatabaseFinalDataSet.PagosRow pagosRow = databaseFinalDataSet.Pagos.FindByNumero(num);

            Numero = num;
            Fecha = pagosRow.Fecha;
            ModPor = pagosRow.CreadoPor;
            Presupuesto = new Presupuesto(pagosRow.NumeroPresupuesto);
            Detalle = pagosRow.Detalle;
        }

        public void Borrar()
        {
            pagosTableAdapter.DeleteByNumero(numero);
        }

    }
}
