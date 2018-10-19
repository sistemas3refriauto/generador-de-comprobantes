using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturas
{
    public class datosPago
    {
       public string Folio { get; set; }
        public string IdDocumento { get; set; }
        public string ImpPagado { get; set; }
        public String ImpSalAnt { get; set; }
        public string ImpSalInsoluto { get; set; }
        public string MetodoDePagoDR { get; set; }
        public string MonedaDR { get; set; }
        public string NumParcialidad { get; set; }

    }
}
