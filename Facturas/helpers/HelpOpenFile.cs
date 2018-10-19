using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturas
{
    class HelpOpenFile
    {
        #region variables
        private OpenFileDialog openFileDialog1;
        public string fileName;
        public List<string> archivos;
        #endregion
        public HelpOpenFile(){
            openFileDialog1 = new OpenFileDialog
            {
                Title = "Seleccione archivo valido para factura",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "Archivo de factura (*.xml)|*.xml",
            };
        }
        public string showDialog()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                return openFileDialog1.FileName;
            }
            return "";
        }
        public string showDialogM()
        {
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                fileName = openFileDialog1.FileName;
                archivos = new List<string>();
                int Con = 0;
                foreach (string f in openFileDialog1.FileNames)
                {
                    archivos.Add(f);
                    Con++;
                }
                return "Se Procesaran "+Con;
            }
            return "";
        }
    }
}
