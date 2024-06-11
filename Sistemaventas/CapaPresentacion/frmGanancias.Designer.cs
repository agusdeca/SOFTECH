namespace CapaPresentacion
{
    partial class frmGanancias
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
            this.backGanancias = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new FontAwesome.Sharp.IconButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtfechafin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // backGanancias
            // 
            this.backGanancias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.backGanancias.FlatAppearance.BorderSize = 0;
            this.backGanancias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backGanancias.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.backGanancias.IconColor = System.Drawing.Color.White;
            this.backGanancias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.backGanancias.IconSize = 40;
            this.backGanancias.Location = new System.Drawing.Point(12, 12);
            this.backGanancias.Name = "backGanancias";
            this.backGanancias.Size = new System.Drawing.Size(48, 41);
            this.backGanancias.TabIndex = 1;
            this.backGanancias.UseVisualStyleBackColor = false;
            this.backGanancias.Click += new System.EventHandler(this.backGanancias_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(66, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(267, 34);
            this.label11.TabIndex = 78;
            this.label11.Text = "Reporte Ganancias:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label.Location = new System.Drawing.Point(68, 81);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(74, 17);
            this.label.TabIndex = 79;
            this.label.Text = "Filtrar Por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(152, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 81;
            this.label2.Text = "Fecha Inicio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(350, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 83;
            this.label1.Text = "Fecha fin:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnFiltrar.IconColor = System.Drawing.Color.Black;
            this.btnFiltrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFiltrar.IconSize = 20;
            this.btnFiltrar.Location = new System.Drawing.Point(535, 81);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(69, 21);
            this.btnFiltrar.TabIndex = 84;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaRegistro,
            this.TipoDocumento,
            this.NumeroDocumento,
            this.MontoTotal,
            this.UsuarioRegistro,
            this.DocumentoCliente,
            this.NombreCliente,
            this.CodigoProducto,
            this.NombreProducto,
            this.Categoria,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal});
            this.dgvData.Location = new System.Drawing.Point(24, 123);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(816, 298);
            this.dgvData.TabIndex = 236;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.HeaderText = "Numero Documento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            // 
            // UsuarioRegistro
            // 
            this.UsuarioRegistro.HeaderText = "Usuario Registro";
            this.UsuarioRegistro.Name = "UsuarioRegistro";
            this.UsuarioRegistro.ReadOnly = true;
            // 
            // DocumentoCliente
            // 
            this.DocumentoCliente.HeaderText = "Documento Cliente";
            this.DocumentoCliente.Name = "DocumentoCliente";
            this.DocumentoCliente.ReadOnly = true;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Codigo Producto";
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaInicio.Location = new System.Drawing.Point(235, 80);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(98, 20);
            this.txtFechaInicio.TabIndex = 0;
            // 
            // txtfechafin
            // 
            this.txtfechafin.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.txtfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechafin.Location = new System.Drawing.Point(420, 81);
            this.txtfechafin.Name = "txtfechafin";
            this.txtfechafin.Size = new System.Drawing.Size(99, 20);
            this.txtfechafin.TabIndex = 86;
            // 
            // frmGanancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.txtfechafin);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.backGanancias);
            this.Name = "frmGanancias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGanancias";
            this.Load += new System.EventHandler(this.frmGanancias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton backGanancias;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnFiltrar;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DateTimePicker txtFechaInicio;
        private System.Windows.Forms.DateTimePicker txtfechafin;
    }
}