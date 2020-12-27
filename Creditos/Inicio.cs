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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.9);
            Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.95);
            CenterToScreen();
            btnTablero_Click(this, null);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(panMenu.Width == 250)
            {
                panMenu.Width = 57;
            }
            else panMenu.Width = 250;
        }

        private void btnTablero_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Ventas a crédito - Tablero principal";
            if (this.panWork.Controls.Count > 0)
                this.panWork.Controls.RemoveAt(0);
            Tablero Tab = new Tablero();
            Tab.TopLevel = false;
            Tab.Dock = DockStyle.Fill;
            this.panWork.Controls.Add(Tab);
            this.panWork.Tag = Tab;
            Tab.Show();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Ventas a crédito - Configuración";
            if (this.panWork.Controls.Count > 0)
                this.panWork.Controls.RemoveAt(0);
            frmSetup Tab = new frmSetup();
            Tab.TopLevel = false;
            Tab.Dock = DockStyle.Fill;
            this.panWork.Controls.Add(Tab);
            this.panWork.Tag = Tab;
            Tab.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Ventas a crédito - Atención al cliente";
            if(this.panWork.Controls.Count > 0)
                this.panWork.Controls.RemoveAt(0);
            frmVentas Frm = new frmVentas();
            Frm.TopLevel = false;
            Frm.Dock = DockStyle.Fill;
            this.panWork.Controls.Add(Frm);
            this.panWork.Tag = Frm;
            Frm.Show();
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Ventas a crédito - Gestión de créditos";
            if (this.panWork.Controls.Count > 0)
                this.panWork.Controls.RemoveAt(0);
            frmGestion Frm = new frmGestion();
            Frm.TopLevel = false;
            Frm.Dock = DockStyle.Fill;
            this.panWork.Controls.Add(Frm);
            this.panWork.Tag = Frm;
            Frm.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Ventas a crédito - Usuarios del sistema";
            if (this.panWork.Controls.Count > 0)
                this.panWork.Controls.RemoveAt(0);
            frmUsuarios Frm = new frmUsuarios();
            Frm.TopLevel = false;
            Frm.Dock = DockStyle.Fill;
            this.panWork.Controls.Add(Frm);
            this.panWork.Tag = Frm;
            Frm.Show();
        }
        
        private void btnInformes_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Ventas a crédito - Reportes";
            if (this.panWork.Controls.Count > 0)
                this.panWork.Controls.RemoveAt(0);
            frmReportes Frm = new frmReportes();
            Frm.TopLevel = false;
            Frm.Dock = DockStyle.Fill;
            this.panWork.Controls.Add(Frm);
            this.panWork.Tag = Frm;
            Frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btnMax.Visible = false;
                btnRes.Visible = true;
            }
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                btnMax.Visible = true;
                btnRes.Visible = false;
            }
        }
    }
}
