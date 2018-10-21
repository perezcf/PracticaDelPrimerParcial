using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaPrimerParcial.ServiceWCF.Logica.Accion
{
    public class OperacionTriangulo
    {

        private IList<string> MiListaDeErrores = new List<string>(new string[] { });

        public IList<string> listaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }


        internal double PerimetroTriangulo(double L1, double L2, double L3)
        {

            var Validacion = new Logica.Validacion.OperacionTriangulo();
            double resultado = 0.0;

            if (Validacion.LadosNoNegativos(L1, L2, L3))
            {
                if (Validacion.LadosValidos(L1, L2, L3))
                {
                    resultado = L1 + L2 + L3;

                }
                else
                {

                    MiListaDeErrores.Add("La suma de los lados menores es mayor que el valor de lado mayor");
                }        

            }
            else
            {
                MiListaDeErrores.Add("Alguno de los lados es negativo");
            }

            return resultado;

        }


    }


}