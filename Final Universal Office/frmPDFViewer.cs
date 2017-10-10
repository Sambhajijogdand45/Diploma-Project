using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Ribbonpad
{
    public partial class frmPDFViewer : DevComponents.DotNetBar.Office2007Form
    {
        public frmPDFViewer(string fileName)
        {
            InitializeComponent();
            webBrowser1.Navigate(fileName);
            this.Text = "PDF:" + fileName;
        }
    }
}
