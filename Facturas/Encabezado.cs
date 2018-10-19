using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturas
{
    public class Encabezado
    {
        public string Nombre { get; set; }
        public string RFC { get; set; }
        public string rigemen { get; set; }
        public string telefono { get; set; }
        public string certificadoEmisor { get; set; }
        public string version { get; set; }
        public string serie { get; set; }
        public string fechahora { get; set; }
    }
}
