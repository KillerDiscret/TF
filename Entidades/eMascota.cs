using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eMascota
    {
        public string CodigoMascota { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Tipo { get; set; }
        public string Raza { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Esterelizado { get; set; }
        public string Observaciones { get; set; }
        public eVisita CodigoVisita { get; set; }
        public override string ToString()
        {
            return Nombre;
        }


    }
}
