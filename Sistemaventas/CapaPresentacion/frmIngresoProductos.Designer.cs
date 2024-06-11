namespace CapaPresentacion
{
    partial class frmIngresoProductos
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
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTipodocumento = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCompra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.txtIdproducto = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRegistrarCompra = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.backIngresoProducto = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.label1.Location = new System.Drawing.Point(88, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(685, 352);
            this.label1.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(85, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(254, 34);
            this.label11.TabIndex = 57;
            this.label11.Text = "Detalle de Ingreso:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboTipodocumento);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Location = new System.Drawing.Point(97, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 83);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo documento:";
            // 
            // cboTipodocumento
            // 
            this.cboTipodocumento.FormattingEnabled = true;
            this.cboTipodocumento.Location = new System.Drawing.Point(124, 39);
            this.cboTipodocumento.Name = "cboTipodocumento";
            this.cboTipodocumento.Size = new System.Drawing.Size(118, 21);
            this.cboTipodocumento.TabIndex = 2;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(9, 40);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(6, 20);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(51, 17);
            this.label.TabIndex = 0;
            this.label.Text = "Fecha:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.groupBox2.Controls.Add(this.txtNombreProveedor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(357, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 83);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Proveedor";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(24, 40);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProveedor.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.groupBox3.Controls.Add(this.txtCantidad);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtVenta);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtCompra);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtProducto);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnBuscarProducto);
            this.groupBox3.Controls.Add(this.txtIdproducto);
            this.groupBox3.Controls.Add(this.txtCodigo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(97, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(602, 72);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion del Producto";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(505, 39);
            this.txtCantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(88, 20);
            this.txtCantidad.TabIndex = 72;
            this.txtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(502, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 71;
            this.label8.Text = "Cantidad:";
            // 
            // txtVenta
            // 
            this.txtVenta.Location = new System.Drawing.Point(395, 39);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(100, 20);
            this.txtVenta.TabIndex = 70;
            this.txtVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVenta_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(392, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 69;
            this.label7.Text = "Precio venta:";
            // 
            // txtCompra
            // 
            this.txtCompra.Location = new System.Drawing.Point(284, 39);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Size = new System.Drawing.Size(100, 20);
            this.txtCompra.TabIndex = 68;
            this.txtCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCompra_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(281, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 67;
            this.label6.Text = "Precio compra:";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(155, 39);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(118, 20);
            this.txtProducto.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 65;
            this.label5.Text = "Producto:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnBuscarProducto.IconColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProducto.IconSize = 20;
            this.btnBuscarProducto.Location = new System.Drawing.Point(115, 39);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(30, 21);
            this.btnBuscarProducto.TabIndex = 64;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtIdproducto
            // 
            this.txtIdproducto.Location = new System.Drawing.Point(89, 16);
            this.txtIdproducto.Name = "txtIdproducto";
            this.txtIdproducto.Size = new System.Drawing.Size(20, 20);
            this.txtIdproducto.TabIndex = 63;
            this.txtIdproducto.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(9, 39);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Codigo:";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.Subtotal,
            this.btnEliminar});
            this.dgvData.Location = new System.Drawing.Point(97, 229);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(553, 169);
            this.dgvData.TabIndex = 61;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvData_CellPainting);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            this.IdProducto.Width = 160;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 160;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Width = 50;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(660, 353);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(105, 20);
            this.txtTotalPagar.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(657, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 73;
            this.label9.Text = "Pago Total:";
            // 
            // btnRegistrarCompra
            // 
            this.btnRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.Microchip;
            this.btnRegistrarCompra.IconColor = System.Drawing.Color.Black;
            this.btnRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarCompra.IconSize = 20;
            this.btnRegistrarCompra.Location = new System.Drawing.Point(660, 379);
            this.btnRegistrarCompra.Name = "btnRegistrarCompra";
            this.btnRegistrarCompra.Size = new System.Drawing.Size(105, 20);
            this.btnRegistrarCompra.TabIndex = 75;
            this.btnRegistrarCompra.Text = "Registrar";
            this.btnRegistrarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRegistrarCompra.UseVisualStyleBackColor = true;
            this.btnRegistrarCompra.Click += new System.EventHandler(this.btnRegistrarCompra_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 20;
            this.btnAgregar.Location = new System.Drawing.Point(705, 168);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(60, 55);
            this.btnAgregar.TabIndex = 73;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // backIngresoProducto
            // 
            this.backIngresoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.backIngresoProducto.FlatAppearance.BorderSize = 0;
            this.backIngresoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backIngresoProducto.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.backIngresoProducto.IconColor = System.Drawing.Color.White;
            this.backIngresoProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.backIngresoProducto.IconSize = 40;
            this.backIngresoProducto.Location = new System.Drawing.Point(12, 12);
            this.backIngresoProducto.Name = "backIngresoProducto";
            this.backIngresoProducto.Size = new System.Drawing.Size(48, 41);
            this.backIngresoProducto.TabIndex = 1;
            this.backIngresoProducto.UseVisualStyleBackColor = false;
            this.backIngresoProducto.Click += new System.EventHandler(this.backIngresoProducto_Click);
            // 
            // frmIngresoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.btnRegistrarCompra);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backIngresoProducto);
            this.Name = "frmIngresoProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIngresoProductos";
            this.Load += new System.EventHandler(this.frmIngresoProductos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton backIngresoProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTipodocumento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private System.Windows.Forms.TextBox txtIdproducto;
        private System.Windows.Forms.TextBox txtVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.DataGridView dgvData;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnRegistrarCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}