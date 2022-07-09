using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador_web
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtURL.Text);
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnadelante_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnrecargar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/");
        }
    }
}
