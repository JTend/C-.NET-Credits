namespace Creditos
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnRes = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panMenu = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnGestion = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnTablero = new System.Windows.Forms.Button();
            this.panWork = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnRes);
            this.panel1.Controls.Add(this.btnMax);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.panel1.Size = new System.Drawing.Size(772, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnMin
            // 
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(647, 5);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 40);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 4;
            this.btnMin.TabStop = false;
            this.toolTip1.SetToolTip(this.btnMin, "Minimizar");
            // 
            // btnRes
            // 
            this.btnRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRes.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRes.Image = global::Creditos.Properties.Resources.Res;
            this.btnRes.Location = new System.Drawing.Point(687, 5);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(40, 40);
            this.btnRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRes.TabIndex = 3;
            this.btnRes.TabStop = false;
            this.toolTip1.SetToolTip(this.btnRes, "Restaurar");
            this.btnRes.Visible = false;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // btnMax
            // 
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.Image = global::Creditos.Properties.Resources.Max;
            this.btnMax.Location = new System.Drawing.Point(727, 5);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(40, 40);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 2;
            this.btnMax.TabStop = false;
            this.toolTip1.SetToolTip(this.btnMax, "Maximizar");
            this.btnMax.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitulo.Location = new System.Drawing.Point(66, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(481, 37);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Ventas a crédito - Tablero de mando";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panMenu
            // 
            this.panMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(200)))));
            this.panMenu.Controls.Add(this.lblUsuario);
            this.panMenu.Controls.Add(this.btnInformes);
            this.panMenu.Controls.Add(this.btnUsuarios);
            this.panMenu.Controls.Add(this.btnGestion);
            this.panMenu.Controls.Add(this.btnVentas);
            this.panMenu.Controls.Add(this.btnConfig);
            this.panMenu.Controls.Add(this.btnTablero);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMenu.Location = new System.Drawing.Point(0, 50);
            this.panMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(250, 405);
            this.panMenu.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Image = ((System.Drawing.Image)(resources.GetObject("lblUsuario.Image")));
            this.lblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsuario.Location = new System.Drawing.Point(0, 350);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(250, 55);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Jose Tendero\r\n16197633\r\njoseg.tenderor@gmail.com";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnInformes
            // 
            this.btnInformes.BackColor = System.Drawing.Color.Transparent;
            this.btnInformes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformes.FlatAppearance.BorderSize = 0;
            this.btnInformes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnInformes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformes.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformes.ForeColor = System.Drawing.Color.White;
            this.btnInformes.Image = global::Creditos.Properties.Resources.ReportB;
            this.btnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.Location = new System.Drawing.Point(0, 250);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(250, 50);
            this.btnInformes.TabIndex = 5;
            this.btnInformes.Text = "Informes";
            this.btnInformes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInformes.UseVisualStyleBackColor = false;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = global::Creditos.Properties.Resources.UsuariosB;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 200);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(250, 50);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnGestion
            // 
            this.btnGestion.BackColor = System.Drawing.Color.Transparent;
            this.btnGestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestion.FlatAppearance.BorderSize = 0;
            this.btnGestion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnGestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestion.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestion.ForeColor = System.Drawing.Color.White;
            this.btnGestion.Image = global::Creditos.Properties.Resources.Gestion;
            this.btnGestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestion.Location = new System.Drawing.Point(0, 150);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(250, 50);
            this.btnGestion.TabIndex = 3;
            this.btnGestion.Text = "Gestión";
            this.btnGestion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestion.UseVisualStyleBackColor = false;
            this.btnGestion.Click += new System.EventHandler(this.btnGestion_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Image = global::Creditos.Properties.Resources.CalcB;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 100);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(250, 50);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.Image = global::Creditos.Properties.Resources.EngraneB;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(0, 50);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(250, 50);
            this.btnConfig.TabIndex = 1;
            this.btnConfig.Text = "Configurar";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnTablero
            // 
            this.btnTablero.BackColor = System.Drawing.Color.Transparent;
            this.btnTablero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTablero.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTablero.FlatAppearance.BorderSize = 0;
            this.btnTablero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.btnTablero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnTablero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTablero.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTablero.ForeColor = System.Drawing.Color.White;
            this.btnTablero.Image = global::Creditos.Properties.Resources.Tablero;
            this.btnTablero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTablero.Location = new System.Drawing.Point(0, 0);
            this.btnTablero.Margin = new System.Windows.Forms.Padding(0);
            this.btnTablero.Name = "btnTablero";
            this.btnTablero.Size = new System.Drawing.Size(250, 50);
            this.btnTablero.TabIndex = 0;
            this.btnTablero.Text = "Inicio";
            this.btnTablero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTablero.UseVisualStyleBackColor = false;
            this.btnTablero.Click += new System.EventHandler(this.btnTablero_Click);
            // 
            // panWork
            // 
            this.panWork.BackColor = System.Drawing.Color.White;
            this.panWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panWork.Location = new System.Drawing.Point(250, 50);
            this.panWork.Margin = new System.Windows.Forms.Padding(25);
            this.panWork.Name = "panWork";
            this.panWork.Size = new System.Drawing.Size(522, 405);
            this.panWork.TabIndex = 0;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(200)))));
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 455);
            this.Controls.Add(this.panWork);
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Text = "Creditos";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnTablero;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnGestion;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel panWork;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnRes;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

