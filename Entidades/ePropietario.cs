using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class ePropietario
    {
        public string CodigoPropietario { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string DNI { get; set; }
        public string Direccion { get; set; }
        public int Telf { get; set;}
        public int Cel { get; set; }
        public string Distrito { get; set; }
        public string Observaciones { get; set; }
        public eMascota CodigoMascota { get; set;}
        public override string ToString()
        {
            return Nombre;
        }

    }
}
