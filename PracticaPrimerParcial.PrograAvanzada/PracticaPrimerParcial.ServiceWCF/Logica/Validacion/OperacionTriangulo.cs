using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.ServiceWCF.Logica.Validacion
{
    public class OperacionTriangulo
    {
        public bool LadosNoNegativos(double L1, double L2, double L3)
        {
            bool resultado = true;

            resultado = (L1 >= 0 && L2 >= 0 && L3>= 0);

            return resultado;
        }

        public bool LadosValidos(double L1, double L2, double L3)
        {

            bool resultado = true;

            var LadoMayor = 0.0;
            var LadoMenor1 = 0.0;
            var LadoMenor2 = 0.0;

            if (L1 > L2)
            {
                LadoMayor = L1;
                LadoMenor1 = L2;
            }
            else
            {
                LadoMayor = L2;
                LadoMenor1 = L1;
            }

            if (LadoMayor > L3)
            {
                LadoMenor2 = L3;
            }
            else
            {
                LadoMayor = L3;
                LadoMenor2 = L2;
            }

            var sumaMenores = LadoMenor1 + LadoMenor2;

            if (LadoMayor > sumaMenores)
            {
                resultado = false;
            }

            return resultado;

        }
    }
}