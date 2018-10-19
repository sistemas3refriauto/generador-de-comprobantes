using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Facturas
{
    class LeerFacturaComprobantePago
    {
        #region variables
        string prefix = "cfdi";
        private Comprobante comprobante;
        #endregion
        public string tipoFactura(string rutaXml)
        {
            setComprobante(rutaXml);
            return comprobante.TipoDeComprobante;
        }
        private void setComprobante(string rutaXml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Comprobante));
            XmlTextReader reader = new XmlTextReader(rutaXml);
            comprobante = (Comprobante)serializer.Deserialize(reader);
        }
        public Comprobante getComprobante
        {
            get { return comprobante; }
        }
    }
}
