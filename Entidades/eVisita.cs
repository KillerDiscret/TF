using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eVisita
    {
        public string CodigoVisita { get; set; }
        public DateTime FechaVisita { get; set; }
        public eAsunto CodigoAsunto { get; set;}
        
    }
}
