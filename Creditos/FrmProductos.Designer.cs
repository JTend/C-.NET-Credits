namespace Creditos
{
    partial class FrmProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.CoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.udCant = new System.Windows.Forms.NumericUpDown();
            this.btnSel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCant)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cantidad:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgProductos
            // 
            this.dgProductos.AllowUserToAddRows = false;
            this.dgProductos.AllowUserToDeleteRows = false;
            this.dgProductos.AllowUserToResizeColumns = false;
            this.dgProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CoID,
            this.CoNombre,
            this.Cant,
            this.Precio});
            this.dgProductos.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgProductos.Location = new System.Drawing.Point(12, 36);
            this.dgProductos.MultiSelect = false;
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.ReadOnly = true;
            this.dgProductos.RowHeadersWidth = 10;
            this.dgProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgProductos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductos.Size = new System.Drawing.Size(427, 259);
            this.dgProductos.TabIndex = 16;
            this.dgProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductos_CellClick);
            // 
            // CoID
            // 
            this.CoID.DataPropertyName = "CodProd";
            this.CoID.HeaderText = "Codigo";
            this.CoID.Name = "CoID";
            this.CoID.ReadOnly = true;
            this.CoID.Width = 80;
            // 
            // CoNombre
            // 
            this.CoNombre.DataPropertyName = "Descrip";
            this.CoNombre.HeaderText = "Descripcion";
            this.CoNombre.Name = "CoNombre";
            this.CoNombre.ReadOnly = true;
            this.CoNombre.Width = 200;
            // 
            // Cant
            // 
            this.Cant.DataPropertyName = "Existen";
            this.Cant.HeaderText = "Cantidad";
            this.Cant.Name = "Cant";
            this.Cant.ReadOnly = true;
            this.Cant.Width = 50;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio1";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 80;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(60, 9);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(379, 25);
            this.txtBuscar.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Buscar:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // udCant
            // 
            this.udCant.Location = new System.Drawing.Point(81, 302);
            this.udCant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udCant.Name = "udCant";
            this.udCant.Size = new System.Drawing.Size(59, 25);
            this.udCant.TabIndex = 18;
            this.udCant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSel
            // 
            this.btnSel.Enabled = false;
            this.btnSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSel.Location = new System.Drawing.Point(309, 300);
            this.btnSel.Name = "btnSel";
            this.btnSel.Size = new System.Drawing.Size(130, 26);
            this.btnSel.TabIndex = 19;
            this.btnSel.Text = "Seleccionar";
            this.btnSel.UseVisualStyleBackColor = true;
            this.btnSel.Click += new System.EventHandler(this.btnSel_Click);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(451, 339);
            this.Controls.Add(this.btnSel);
            this.Controls.Add(this.udCant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown udCant;
        private System.Windows.Forms.Button btnSel;
    }
}