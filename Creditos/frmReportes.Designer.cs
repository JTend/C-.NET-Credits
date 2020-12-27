namespace Creditos
{
    partial class frmReportes
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
            this.panOpciones = new System.Windows.Forms.Panel();
            this.panSup = new System.Windows.Forms.Panel();
            this.panInfo = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.panSup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panOpciones
            // 
            this.panOpciones.BackColor = System.Drawing.Color.Transparent;
            this.panOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panOpciones.Location = new System.Drawing.Point(20, 267);
            this.panOpciones.Name = "panOpciones";
            this.panOpciones.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panOpciones.Size = new System.Drawing.Size(718, 163);
            this.panOpciones.TabIndex = 5;
            // 
            // panSup
            // 
            this.panSup.BackColor = System.Drawing.Color.Transparent;
            this.panSup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSup.Controls.Add(this.panInfo);
            this.panSup.Controls.Add(this.tableLayoutPanel1);
            this.panSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSup.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.panSup.Location = new System.Drawing.Point(20, 20);
            this.panSup.Name = "panSup";
            this.panSup.Size = new System.Drawing.Size(718, 247);
            this.panSup.TabIndex = 4;
            // 
            // panInfo
            // 
            this.panInfo.BackColor = System.Drawing.Color.Transparent;
            this.panInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panInfo.Location = new System.Drawing.Point(202, 0);
            this.panInfo.Name = "panInfo";
            this.panInfo.Padding = new System.Windows.Forms.Padding(20);
            this.panInfo.Size = new System.Drawing.Size(514, 245);
            this.panInfo.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.radioButton3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButton8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButton7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButton6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.radioButton5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.radioButton4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(202, 245);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(125)))));
            this.radioButton3.Checked = true;
            this.radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Image = global::Creditos.Properties.Resources.Calc;
            this.radioButton3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton3.Location = new System.Drawing.Point(3, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(95, 75);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Creditos";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // radioButton8
            // 
            this.radioButton8.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton8.AutoSize = true;
            this.radioButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(125)))));
            this.radioButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton8.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioButton8.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.radioButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton8.ForeColor = System.Drawing.Color.White;
            this.radioButton8.Image = global::Creditos.Properties.Resources.UsuariosR;
            this.radioButton8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton8.Location = new System.Drawing.Point(104, 165);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(95, 77);
            this.radioButton8.TabIndex = 15;
            this.radioButton8.Text = "Usuarios";
            this.radioButton8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radioButton8.UseVisualStyleBackColor = false;
            this.radioButton8.Click += new System.EventHandler(this.radioButton8_Click);
            // 
            // radioButton7
            // 
            this.radioButton7.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton7.AutoSize = true;
            this.radioButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(125)))));
            this.radioButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton7.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioButton7.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.radioButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton7.ForeColor = System.Drawing.Color.White;
            this.radioButton7.Image = global::Creditos.Properties.Resources.Informe;
            this.radioButton7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton7.Location = new System.Drawing.Point(3, 165);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(95, 77);
            this.radioButton7.TabIndex = 14;
            this.radioButton7.Text = "Reimprimir";
            this.radioButton7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radioButton7.UseVisualStyleBackColor = false;
            this.radioButton7.Click += new System.EventHandler(this.radioButton7_Click);
            // 
            // radioButton6
            // 
            this.radioButton6.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton6.AutoSize = true;
            this.radioButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(125)))));
            this.radioButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioButton6.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.radioButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.ForeColor = System.Drawing.Color.White;
            this.radioButton6.Image = global::Creditos.Properties.Resources.UsuariosR;
            this.radioButton6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton6.Location = new System.Drawing.Point(104, 84);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(95, 75);
            this.radioButton6.TabIndex = 13;
            this.radioButton6.Text = "Vendedores";
            this.radioButton6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radioButton6.UseVisualStyleBackColor = false;
            this.radioButton6.Click += new System.EventHandler(this.radioButton6_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton5.AutoSize = true;
            this.radioButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(125)))));
            this.radioButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioButton5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.ForeColor = System.Drawing.Color.White;
            this.radioButton5.Image = global::Creditos.Properties.Resources.ConexR;
            this.radioButton5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton5.Location = new System.Drawing.Point(3, 84);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(95, 75);
            this.radioButton5.TabIndex = 12;
            this.radioButton5.Text = "Productos";
            this.radioButton5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radioButton5.UseVisualStyleBackColor = false;
            this.radioButton5.Click += new System.EventHandler(this.radioButton5_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(125)))));
            this.radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioButton4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.ForeColor = System.Drawing.Color.White;
            this.radioButton4.Image = global::Creditos.Properties.Resources.UsuariosR;
            this.radioButton4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton4.Location = new System.Drawing.Point(104, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(95, 75);
            this.radioButton4.TabIndex = 11;
            this.radioButton4.Text = "Clientes";
            this.radioButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radioButton4.UseVisualStyleBackColor = false;
            this.radioButton4.Click += new System.EventHandler(this.radioButton4_Click);
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.panOpciones);
            this.Controls.Add(this.panSup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportes";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "frmReportes";
            this.Shown += new System.EventHandler(this.frmReportes_Shown);
            this.panSup.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panOpciones;
        private System.Windows.Forms.Panel panSup;
        private System.Windows.Forms.Panel panInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}