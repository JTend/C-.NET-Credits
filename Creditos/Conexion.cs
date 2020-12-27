using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Creditos
{
    public partial class Conexion : Form
    {
        public Conexion()
        {
            InitializeComponent();
        }
        
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                Login.MyS = new ConMySQL(TxtServer.Text, TxtBD.Text, TxtUsuario.Text, TxtClave.Text);
                BtnEntrar.Enabled = true;
            }
            catch(InvalidOperationException E)
            {
                MessageBox.Show("No se pudo establecer la conexión.\n" + E.Message);
            }
            catch(MySqlException EE)
            {
                MessageBox.Show("No se pudo establecer la conexión.\n" + EE.Message);
            }
            
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            Login.ACC.Sentencia("update conex set dirip = '" + TxtServer.Text + "', BaseD = '" + TxtBD.Text + "', Usuario = '"+ TxtUsuario.Text +"', clave = '"+ TxtClave.Text +"' where tipocon = 1");
            new Login().ShowDialog();
            this.Close();
        }

        private void TxtServer_TextChanged(object sender, EventArgs e)
        {
            BtnEntrar.Enabled = false;
        }

        private void TxtBD_TextChanged(object sender, EventArgs e)
        {
            BtnEntrar.Enabled = false;
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            BtnEntrar.Enabled = false;
        }

        private void TxtClave_TextChanged(object sender, EventArgs e)
        {
            BtnEntrar.Enabled = false;
        }
    }
}
