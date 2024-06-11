namespace CapaPresentacion
{
    partial class frmRealizarVenta
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
            this.backRventa = new FontAwesome.Sharp.IconButton();
            this.btnRegistrarVenta = new FontAwesome.Sharp.IconButton();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.txtIdproducto = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.cboTipodocumento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPagacon = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backRventa
            // 
            this.backRventa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.backRventa.FlatAppearance.BorderSize = 0;
            this.backRventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backRventa.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.backRventa.IconColor = System.Drawing.Color.White;
            this.backRventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.backRventa.IconSize = 40;
            this.backRventa.Location = new System.Drawing.Point(12, 12);
            this.backRventa.Name = "backRventa";
            this.backRventa.Size = new System.Drawing.Size(48, 41);
            this.backRventa.TabIndex = 1;
            this.backRventa.UseVisualStyleBackColor = false;
            this.backRventa.Click += new System.EventHandler(this.backRventa_Click);
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.Microchip;
            this.btnRegistrarVenta.IconColor = System.Drawing.Color.Black;
            this.btnRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarVenta.IconSize = 20;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(631, 398);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(105, 20);
            this.btnRegistrarVenta.TabIndex = 85;
            this.btnRegistrarVenta.Text = "Hacer venta";
            this.btnRegistrarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(631, 372);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(105, 20);
            this.txtTotalPagar.TabIndex = 84;
            // 
            // btnAgregar
            // 
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 20;
            this.btnAgregar.Location = new System.Drawing.Point(687, 175);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(82, 69);
            this.btnAgregar.TabIndex = 82;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(628, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 83;
            this.label9.Text = "Pago Total:";
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
            this.Precio,
            this.Cantidad,
            this.Subtotal,
            this.btnEliminar});
            this.dgvData.Location = new System.Drawing.Point(68, 249);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(553, 169);
            this.dgvData.TabIndex = 81;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick_1);
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvData_CellPainting_1);
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
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.groupBox3.Controls.Add(this.txtStock);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtCantidad);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtPrecio);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtProducto);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnBuscarProducto);
            this.groupBox3.Controls.Add(this.txtIdproducto);
            this.groupBox3.Controls.Add(this.txtCodigo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(68, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(602, 83);
            this.groupBox3.TabIndex = 80;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion del Producto";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(395, 39);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(392, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 73;
            this.label7.Text = "Stock:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(508, 39);
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
            this.label8.Location = new System.Drawing.Point(505, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 71;
            this.label8.Text = "Cantidad:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(282, 39);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 68;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(279, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 67;
            this.label6.Text = "Precio:";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(151, 39);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(118, 20);
            this.txtProducto.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 20);
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
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click_1);
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.groupBox2.Controls.Add(this.txtApellidoCliente);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtNombreCliente);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.iconButton1);
            this.groupBox2.Controls.Add(this.txtDNI);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(328, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 83);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Cliente";
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(241, 40);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(87, 20);
            this.txtApellidoCliente.TabIndex = 77;
           
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(238, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 76;
            this.label12.Text = "Apellido:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(148, 40);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(87, 20);
            this.txtNombreCliente.TabIndex = 75;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(145, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 74;
            this.label10.Text = "Nombre:";
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(112, 38);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(30, 21);
            this.iconButton1.TabIndex = 73;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(6, 39);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "DNI:";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(56, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 34);
            this.label11.TabIndex = 77;
            this.label11.Text = "Realizar venta:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.label1.Location = new System.Drawing.Point(59, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(739, 352);
            this.label1.TabIndex = 76;
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
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(9, 40);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 1;
            // 
            // cboTipodocumento
            // 
            this.cboTipodocumento.FormattingEnabled = true;
            this.cboTipodocumento.Location = new System.Drawing.Point(124, 39);
            this.cboTipodocumento.Name = "cboTipodocumento";
            this.cboTipodocumento.Size = new System.Drawing.Size(118, 21);
            this.cboTipodocumento.TabIndex = 2;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboTipodocumento);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Location = new System.Drawing.Point(68, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 83);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(631, 332);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(105, 20);
            this.txtCambio.TabIndex = 87;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(628, 312);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 17);
            this.label13.TabIndex = 86;
            this.label13.Text = "Cambio:";
            // 
            // txtPagacon
            // 
            this.txtPagacon.Location = new System.Drawing.Point(631, 291);
            this.txtPagacon.Name = "txtPagacon";
            this.txtPagacon.Size = new System.Drawing.Size(105, 20);
            this.txtPagacon.TabIndex = 89;
            this.txtPagacon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPagacon_KeyDown);
            this.txtPagacon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagacon_KeyPress_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(628, 271);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 17);
            this.label14.TabIndex = 88;
            this.label14.Text = "Paga con:";
            // 
            // frmRealizarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.txtPagacon);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backRventa);
            this.Name = "frmRealizarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRealizarVenta";
            this.Load += new System.EventHandler(this.frmRealizarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton backRventa;
        private FontAwesome.Sharp.IconButton btnRegistrarVenta;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private System.Windows.Forms.TextBox txtIdproducto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.ComboBox cboTipodocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPagacon;
        private System.Windows.Forms.Label label14;
    }
}