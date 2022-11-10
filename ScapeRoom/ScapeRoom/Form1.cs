using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScapeRoom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pbxClicCod_Click(object sender, EventArgs e) //Click en el panel de codigo pequeño
        {
            this.BackgroundImage = Properties.Resources.fondo_oscuro;
            pbxCodGran.Visible = true;
            pbxFondo.Visible = true;
            
        }

        private void pbxFondo_Click(object sender, EventArgs e) //Click en el panel de codigo grande
        {
            pbxCodGran.Visible = false;
            pbxFondo.Visible = false;
            this.BackgroundImage = Properties.Resources.fondo_claro;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbxFondo.Visible = false;
        }
    }
}
