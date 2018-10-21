using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PracticaPrimerParcial.ServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public double PerimetroTriangulo(double L1, double L2, double L3)
        {
           // Logica.Especificacion.OperacionTriangulo laEspecificacion;
            var laEspecificacion = new Logica.Especificacion.OperacionTriangulo();
            var resultado = laEspecificacion.PerimetroDeTriangulo(L1, L2, L3);
            return resultado;
        }



        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public double PerimetroDeTriangulo(double L1, double L2, double L3)
        {
            throw new NotImplementedException();
        }
    }
}
