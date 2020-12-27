namespace Creditos
{
    partial class Conexion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtEstacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor MySQL:";
            // 
            // TxtServer
            // 
            this.TxtServer.Location = new System.Drawing.Point(45, 29);
            this.TxtServer.Name = "TxtServer";
            this.TxtServer.Size = new System.Drawing.Size(274, 25);
            this.TxtServer.TabIndex = 1;
            this.TxtServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtServer.TextChanged += new System.EventHandler(this.TxtServer_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Base de Datos:";
            // 
            // TxtBD
            // 
            this.TxtBD.Location = new System.Drawing.Point(45, 77);
            this.TxtBD.Name = "TxtBD";
            this.TxtBD.Size = new System.Drawing.Size(274, 25);
            this.TxtBD.TabIndex = 3;
            this.TxtBD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtBD.TextChanged += new System.EventHandler(this.TxtBD_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuario:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(45, 125);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(274, 25);
            this.TxtUsuario.TabIndex = 5;
            this.TxtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Clave:";
            // 
            // TxtClave
            // 
            this.TxtClave.Location = new System.Drawing.Point(45, 173);
            this.TxtClave.MaxLength = 50;
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '•';
            this.TxtClave.Size = new System.Drawing.Size(274, 25);
            this.TxtClave.TabIndex = 7;
            this.TxtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtClave.TextChanged += new System.EventHandler(this.TxtClave_TextChanged);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.Black;
            this.BtnSalir.Location = new System.Drawing.Point(154, 263);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(78, 31);
            this.BtnSalir.TabIndex = 10;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(125)))));
            this.BtnEntrar.Enabled = false;
            this.BtnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntrar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrar.ForeColor = System.Drawing.Color.White;
            this.BtnEntrar.Location = new System.Drawing.Point(238, 263);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(81, 31);
            this.BtnEntrar.TabIndex = 9;
            this.BtnEntrar.Text = "Guardar";
            this.BtnEntrar.UseVisualStyleBackColor = false;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // BtnConectar
            // 
            this.BtnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConectar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConectar.Location = new System.Drawing.Point(15, 263);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(75, 31);
            this.BtnConectar.TabIndex = 11;
            this.BtnConectar.Text = "Conectar";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Estacion:";
            // 
            // TxtEstacion
            // 
            this.TxtEstacion.Location = new System.Drawing.Point(45, 221);
            this.TxtEstacion.Name = "TxtEstacion";
            this.TxtEstacion.Size = new System.Drawing.Size(274, 25);
            this.TxtEstacion.TabIndex = 13;
            this.TxtEstacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Conexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(331, 311);
            this.Controls.Add(this.TxtEstacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtServer);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Conexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtEstacion;
    }
}