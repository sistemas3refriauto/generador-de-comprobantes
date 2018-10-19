using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturas
{
    class listaDatosPago
    {
        List<datosPago> dp;
        public listaDatosPago()
        {
            dp = new List<datosPago>();
        }
        public List<datosPago> getDatosPago()
        {
            return dp;
        }
        public void addDatosPago(datosPago datosP)
        {
            dp.Add(datosP);
        }
    }
}
