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
    public partial class frmSetup : Form
    {
        public frmSetup()
        {
            InitializeComponent();
        }

        private void frmSetup_Shown(object sender, EventArgs e)
        {
            radSumario_Click(this, e);

            if (this.panOpciones.Controls.Count > 0)
                this.panOpciones.Controls.RemoveAt(0);
            frmMenuinf Mnu = new frmMenuinf();
            Mnu.TopLevel = false;
            Mnu.Dock = DockStyle.Fill;
            this.panOpciones.Controls.Add(Mnu);
            this.panOpciones.Tag = Mnu;
            Mnu.Show();
        }

        private void radSumario_Click(object sender, EventArgs e)
        {
            if (this.panInfo.Controls.Count > 0)
                this.panInfo.Controls.RemoveAt(0);
            frmParam frm = new frmParam();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.panInfo.Controls.Add(frm);
            this.panInfo.Tag = frm;
            frm.Show();
        }
    }
}
