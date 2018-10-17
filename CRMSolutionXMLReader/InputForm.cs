using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using XMLOperations;

namespace CRMSolutionXMLReader
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            var resultn = ofd.ShowDialog();
            if (resultn == DialogResult.OK)
            {
                txtFilePath.Text = ofd.FileName;
            }
        }

        private void btnProcessXML_Click(object sender, EventArgs e)
        {
            CRMSolutionProcessing sp = new CRMSolutionProcessing();
            sp.processCRMSolutionFiles(txtFilePath.Text);
        }
    }
}
