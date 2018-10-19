using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;

namespace Facturas
{
    public partial class Form1 : Form
    {
        #region variables
        HelpOpenFile helpo;
        LeerFacturaComprobantePago fact;
        CrystalDecisions.CrystalReports.Engine.ReportDocument MyReportDocumenet;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                helpo = new HelpOpenFile();
                txtFile.Text = helpo.showDialog();
                Presentacion();
            }catch(Exception ex)
            {
                MessageBox.Show("LO SENTIMOS HEMOS TENIDO UN PROBLEMA \n" + ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
          
        }
        private void Presentacion()
        {
            try
            {
                if (txtFile.Text == string.Empty)
                    return;
                fact = new LeerFacturaComprobantePago();
                string tipfact = fact.tipoFactura(txtFile.Text);
                Comprobante comp = fact.getComprobante;
                qr_generate qr = new qr_generate();
                string qrstring;
                qrstring =
                    "&re=" + comp.Emisor.Rfc +
                    "&rr" + comp.Receptor.Rfc +
                    "&tt" + comp.Total +
                    "&id" + comp.Complemento.TimbreFiscalDigital.UUID;
                qr.createFromText(qrstring);
                datosPago _datosPago;
                listaDatosPago _listaDatosPago = new listaDatosPago();
                if (!(comp.Complemento.Pagos.Pago.DoctoRelacionado ==null))
                {
                    foreach (PagosPagoDoctoRelacionado pago in comp.Complemento.Pagos.Pago.DoctoRelacionado)
                    {
                        _datosPago = new datosPago();
                        int.Parse("" + pago.Folio);
                        _datosPago.Folio = "" + pago.Folio;
                        _datosPago.IdDocumento = pago.IdDocumento;
                        _datosPago.ImpPagado = pago.ImpPagado;
                        _datosPago.ImpSalAnt = pago.ImpSaldoAnt;
                        _datosPago.ImpSalInsoluto = pago.ImpSaldoInsoluto;
                        _datosPago.MetodoDePagoDR = pago.MetodoDePagoDR;
                        _datosPago.MonedaDR = pago.MonedaDR;
                        _datosPago.NumParcialidad = pago.NumParcialidad;
                        _listaDatosPago.addDatosPago(_datosPago);

                    }
                }
                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.Refresh();
                MyReportDocumenet = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                MyReportDocumenet.Load("CrystalReport2.rpt");
                MyReportDocumenet.SetDataSource(_listaDatosPago.getDatosPago());
                MyReportDocumenet.SetParameterValue("TipoDocumento", "COMPROBANTE DE PAGO");
                MyReportDocumenet.SetParameterValue("Nombre", comp.Emisor.Nombre);
                MyReportDocumenet.SetParameterValue("Rfc", comp.Emisor.Rfc);
                MyReportDocumenet.SetParameterValue("Regimen", comp.Emisor.RegimenFiscal);
                MyReportDocumenet.SetParameterValue("FechaExp", comp.Fecha);
                MyReportDocumenet.SetParameterValue("NombreCli", comp.Receptor.Nombre);
                MyReportDocumenet.SetParameterValue("RFCcli", comp.Receptor.Rfc);
                MyReportDocumenet.SetParameterValue("CDFI", comp.Receptor.UsoCFDI);
                MyReportDocumenet.SetParameterValue("CP", comp.LugarExpedicion);
                MyReportDocumenet.SetParameterValue("NoCert", comp.NoCertificado);
                MyReportDocumenet.SetParameterValue("UUID", comp.Complemento.TimbreFiscalDigital.UUID);
                MyReportDocumenet.SetParameterValue("NoCertSat", comp.Complemento.TimbreFiscalDigital.NoCertificadoSAT);
                MyReportDocumenet.SetParameterValue("FechaTrim", comp.Complemento.TimbreFiscalDigital.FechaTimbrado);
                MyReportDocumenet.SetParameterValue("version", comp.Version);
                MyReportDocumenet.SetParameterValue("CelloCfdi", comp.Complemento.TimbreFiscalDigital.SelloCFD);
                MyReportDocumenet.SetParameterValue("SelloSat", comp.Complemento.TimbreFiscalDigital.SelloSAT);
                MyReportDocumenet.SetParameterValue("QR", Application.StartupPath + "\\qr.png");
                MyReportDocumenet.SetParameterValue("TOTAL",comp.Complemento.Pagos.Pago.Monto);
                MyReportDocumenet.SetParameterValue("CforP", comp.Complemento.Pagos.Pago.FormaDePagoP);
                string formaP="";
                if (comp.Complemento.Pagos.Pago.FormaDePagoP == "01")
                    formaP = "Efectivo";
                if (comp.Complemento.Pagos.Pago.FormaDePagoP == "02")
                    formaP = "Cheque nominativo";
                if (comp.Complemento.Pagos.Pago.FormaDePagoP == "03")
                    formaP = "Transferencia electrónica de fondos";
                MyReportDocumenet.SetParameterValue("CforPD", formaP);
                MyReportDocumenet.SetParameterValue("Mon", comp.Complemento.Pagos.Pago.MonedaP);
                string mond = "";
                if (comp.Complemento.Pagos.Pago.MonedaP == "USD")
                    mond = "Dolar Americano";
                if (comp.Complemento.Pagos.Pago.MonedaP == "MXN")
                    mond = "Peso Mexicano";
                MyReportDocumenet.SetParameterValue("MonD", mond);

                string folio;
                if (comp.Folio == null)
                    folio = "";
                else
                    folio = comp.Folio;
                MyReportDocumenet.SetParameterValue("Folio", folio);
                string cadena;
                cadena = "||" + comp.Complemento.TimbreFiscalDigital.Version + "|" +
                    comp.Complemento.TimbreFiscalDigital.UUID + "|" +
                    comp.Complemento.TimbreFiscalDigital.FechaTimbrado + "|" +
                    comp.Complemento.TimbreFiscalDigital.SelloCFD + "|" +
                    comp.Complemento.TimbreFiscalDigital.NoCertificadoSAT;
                MyReportDocumenet.SetParameterValue("Cadena", cadena);
                crystalReportViewer1.ReportSource = MyReportDocumenet;
                crystalReportViewer1.Refresh();


                //crystalReportViewer1.ReportSource = comp.Complemento.Pagos.Pago.DoctoRelacionado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("LO SENTIMOS HEMOS TENIDO UN PROBLEMA \n" + ex.Message);
            }
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(MyReportDocumenet != null))
                return;
            crystalReportViewer1.PrintReport();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!(MyReportDocumenet != null))
                return;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Documento PDF|*.pdf";
            saveFileDialog1.Title = "Guardar comprobante de pago ";
            saveFileDialog1.FileName = Path.GetFileNameWithoutExtension(helpo.fileName);
            saveFileDialog1.ShowDialog();
            if (!(saveFileDialog1.FileName != ""))
                return;
            MyReportDocumenet.ExportToDisk(ExportFormatType.PortableDocFormat, saveFileDialog1.FileName);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
