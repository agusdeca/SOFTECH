namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labeluserinfo = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.menubotones2 = new System.Windows.Forms.MenuStrip();
            this.menubotones1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            this.btnIngreso = new FontAwesome.Sharp.IconMenuItem();
            this.btnVenta = new FontAwesome.Sharp.IconMenuItem();
            this.btnStock = new FontAwesome.Sharp.IconMenuItem();
            this.btnGanancias = new FontAwesome.Sharp.IconMenuItem();
            this.btnAdmin = new FontAwesome.Sharp.IconMenuItem();
            this.btnCategoria = new FontAwesome.Sharp.IconMenuItem();
            this.btnProducto = new FontAwesome.Sharp.IconMenuItem();
            this.btnClientes = new FontAwesome.Sharp.IconMenuItem();
            this.btnNegocio = new FontAwesome.Sharp.IconMenuItem();
            this.btnUsers = new FontAwesome.Sharp.IconMenuItem();
            this.backGanancias = new FontAwesome.Sharp.IconButton();
            this.menubotones2.SuspendLayout();
            this.menubotones1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(336, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "SOFTECH";
            // 
            // labeluserinfo
            // 
            this.labeluserinfo.AutoSize = true;
            this.labeluserinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.labeluserinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeluserinfo.ForeColor = System.Drawing.Color.White;
            this.labeluserinfo.Location = new System.Drawing.Point(12, 25);
            this.labeluserinfo.Name = "labeluserinfo";
            this.labeluserinfo.Size = new System.Drawing.Size(72, 20);
            this.labeluserinfo.TabIndex = 3;
            this.labeluserinfo.Text = "Usuario: ";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.White;
            this.lblusuario.Location = new System.Drawing.Point(75, 25);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(76, 20);
            this.lblusuario.TabIndex = 4;
            this.lblusuario.Text = "lblusuario";
            // 
            // menubotones2
            // 
            this.menubotones2.AutoSize = false;
            this.menubotones2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.menubotones2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGanancias,
            this.btnAdmin,
            this.btnUsers});
            this.menubotones2.Location = new System.Drawing.Point(0, 269);
            this.menubotones2.Name = "menubotones2";
            this.menubotones2.Size = new System.Drawing.Size(851, 166);
            this.menubotones2.TabIndex = 18;
            this.menubotones2.Text = "menuStrip1";
            // 
            // menubotones1
            // 
            this.menubotones1.AutoSize = false;
            this.menubotones1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.menubotones1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIngreso,
            this.btnVenta,
            this.btnStock});
            this.menubotones1.Location = new System.Drawing.Point(0, 102);
            this.menubotones1.Name = "menubotones1";
            this.menubotones1.Size = new System.Drawing.Size(851, 167);
            this.menubotones1.TabIndex = 19;
            this.menubotones1.Text = "menuStrip1";
            this.menubotones1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(851, 102);
            this.menuStrip2.TabIndex = 20;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            // 
            // iconDropDownButton1
            // 
            this.iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconDropDownButton1.IconColor = System.Drawing.Color.Black;
            this.iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDropDownButton1.Name = "iconDropDownButton1";
            this.iconDropDownButton1.Size = new System.Drawing.Size(23, 23);
            this.iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // btnIngreso
            // 
            this.btnIngreso.AutoSize = false;
            this.btnIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.btnIngreso.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnIngreso.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleDown;
            this.btnIngreso.IconColor = System.Drawing.Color.Black;
            this.btnIngreso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIngreso.IconSize = 55;
            this.btnIngreso.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnIngreso.Margin = new System.Windows.Forms.Padding(130, 0, 0, 0);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(180, 129);
            this.btnIngreso.Text = "Ingreso Productos";
            this.btnIngreso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIngreso.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.AutoSize = false;
            this.btnVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.btnVenta.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnVenta.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnVenta.IconColor = System.Drawing.Color.Black;
            this.btnVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVenta.IconSize = 55;
            this.btnVenta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVenta.Margin = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(180, 129);
            this.btnVenta.Text = "Realizar venta";
            this.btnVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click_1);
            // 
            // btnStock
            // 
            this.btnStock.AutoSize = false;
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.btnStock.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnStock.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.btnStock.IconColor = System.Drawing.Color.Black;
            this.btnStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnStock.Margin = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(180, 129);
            this.btnStock.Text = "Stock";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click_1);
            // 
            // btnGanancias
            // 
            this.btnGanancias.AutoSize = false;
            this.btnGanancias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.btnGanancias.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnGanancias.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            this.btnGanancias.IconColor = System.Drawing.Color.Black;
            this.btnGanancias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGanancias.IconSize = 55;
            this.btnGanancias.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGanancias.Margin = new System.Windows.Forms.Padding(130, 0, 0, 0);
            this.btnGanancias.Name = "btnGanancias";
            this.btnGanancias.Size = new System.Drawing.Size(180, 129);
            this.btnGanancias.Text = "Ganancias";
            this.btnGanancias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGanancias.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnGanancias.Click += new System.EventHandler(this.btnGanancias_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.AutoSize = false;
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.btnAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCategoria,
            this.btnProducto,
            this.btnClientes,
            this.btnNegocio});
            this.btnAdmin.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnAdmin.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnAdmin.IconColor = System.Drawing.Color.Black;
            this.btnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmin.IconSize = 55;
            this.btnAdmin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(180, 129);
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // btnCategoria
            // 
            this.btnCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCategoria.IconColor = System.Drawing.Color.Black;
            this.btnCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(180, 28);
            this.btnCategoria.Text = "Categoria";
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click_1);
            // 
            // btnProducto
            // 
            this.btnProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnProducto.IconColor = System.Drawing.Color.Black;
            this.btnProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(180, 28);
            this.btnProducto.Text = "Producto";
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click_1);
            // 
            // btnClientes
            // 
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClientes.IconColor = System.Drawing.Color.Black;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(180, 28);
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click_1);
            // 
            // btnNegocio
            // 
            this.btnNegocio.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNegocio.IconColor = System.Drawing.Color.Black;
            this.btnNegocio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNegocio.Name = "btnNegocio";
            this.btnNegocio.Size = new System.Drawing.Size(180, 28);
            this.btnNegocio.Text = "Negocio";
            this.btnNegocio.Click += new System.EventHandler(this.btnNegocio_Click_1);
            // 
            // btnUsers
            // 
            this.btnUsers.AutoSize = false;
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(234)))));
            this.btnUsers.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnUsers.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnUsers.IconColor = System.Drawing.Color.Black;
            this.btnUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsers.IconSize = 55;
            this.btnUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUsers.Margin = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(180, 129);
            this.btnUsers.Text = "Usuarios";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // backGanancias
            // 
            this.backGanancias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.backGanancias.FlatAppearance.BorderSize = 0;
            this.backGanancias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backGanancias.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.backGanancias.IconColor = System.Drawing.Color.White;
            this.backGanancias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.backGanancias.IconSize = 40;
            this.backGanancias.Location = new System.Drawing.Point(791, 12);
            this.backGanancias.Name = "backGanancias";
            this.backGanancias.Size = new System.Drawing.Size(48, 41);
            this.backGanancias.TabIndex = 21;
            this.backGanancias.UseVisualStyleBackColor = false;
            this.backGanancias.Click += new System.EventHandler(this.backGanancias_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(851, 455);
            this.Controls.Add(this.backGanancias);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.labeluserinfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menubotones2);
            this.Controls.Add(this.menubotones1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menubotones2;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menubotones2.ResumeLayout(false);
            this.menubotones2.PerformLayout();
            this.menubotones1.ResumeLayout(false);
            this.menubotones1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeluserinfo;
        private System.Windows.Forms.Label lblusuario;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private System.Windows.Forms.MenuStrip menubotones2;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private System.Windows.Forms.MenuStrip menubotones1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private FontAwesome.Sharp.IconMenuItem btnIngreso;
        private FontAwesome.Sharp.IconMenuItem btnVenta;
        private FontAwesome.Sharp.IconMenuItem btnStock;
        private FontAwesome.Sharp.IconMenuItem btnGanancias;
        private FontAwesome.Sharp.IconMenuItem btnAdmin;
        private FontAwesome.Sharp.IconMenuItem btnCategoria;
        private FontAwesome.Sharp.IconMenuItem btnProducto;
        private FontAwesome.Sharp.IconMenuItem btnClientes;
        private FontAwesome.Sharp.IconMenuItem btnNegocio;
        private FontAwesome.Sharp.IconMenuItem btnUsers;
        private FontAwesome.Sharp.IconButton backGanancias;
    }
}

