using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creditos
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Shown(object sender, EventArgs e)
        {
            if (this.panOpciones.Controls.Count > 0)
                this.panOpciones.Controls.RemoveAt(0);
            frmMenuinf Mnu = new frmMenuinf();
            Mnu.TopLevel = false;
            Mnu.Dock = DockStyle.Fill;
            this.panOpciones.Controls.Add(Mnu);
            this.panOpciones.Tag = Mnu;
            Mnu.Show();

            radioButton3_Click(this, e);
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            if (this.panInfo.Controls.Count > 0)
                this.panInfo.Controls.RemoveAt(0);
            rptVentas Mnu = new rptVentas();
            Mnu.TopLevel = false;
            Mnu.Dock = DockStyle.Fill;
            this.panInfo.Controls.Add(Mnu);
            this.panInfo.Tag = Mnu;
            Mnu.Show();
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            if (this.panInfo.Controls.Count > 0)
                this.panInfo.Controls.RemoveAt(0);
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            if (this.panInfo.Controls.Count > 0)
                this.panInfo.Controls.RemoveAt(0);
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            if (this.panInfo.Controls.Count > 0)
                this.panInfo.Controls.RemoveAt(0);
        }

        private void radioButton7_Click(object sender, EventArgs e)
        {
            if (this.panInfo.Controls.Count > 0)
                this.panInfo.Controls.RemoveAt(0);
        }

        private void radioButton8_Click(object sender, EventArgs e)
        {
            if (this.panInfo.Controls.Count > 0)
                this.panInfo.Controls.RemoveAt(0);
        }
    }
}
