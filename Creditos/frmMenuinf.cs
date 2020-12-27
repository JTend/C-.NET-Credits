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
    public partial class frmMenuinf : Form
    {
        public frmMenuinf()
        {
            InitializeComponent();
        }

        private void frmMenuinf_Resize(object sender, EventArgs e)
        {
            panOpc1.Width = (int)(this.Width / 4);
            panOpc2.Width = (int)(this.Width / 4);
            panOpc3.Width = (int)(this.Width / 4);
            panOpc4.Width = (int)(this.Width / 4);
        }
    }
}
