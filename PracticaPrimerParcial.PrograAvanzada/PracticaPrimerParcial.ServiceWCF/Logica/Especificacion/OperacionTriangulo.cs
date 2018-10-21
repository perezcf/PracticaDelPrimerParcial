using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.ServiceWCF.Logica.Especificacion
{
    public class OperacionTriangulo
    {
     
        public double PerimetroDeTriangulo(double L1, double L2, double L3)
        {
            var laAccion = new Logica.Accion.OperacionTriangulo();
            double resultado = laAccion.PerimetroTriangulo(L1, L2, L3);
            return resultado;

        }


    }



}