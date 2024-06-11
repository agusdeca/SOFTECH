namespace CapaPresentacion
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.aceptarboton = new FontAwesome.Sharp.IconButton();
            this.cancelarboton = new FontAwesome.Sharp.IconButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡Bienvenido!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(147, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Por favor inicie sesion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(211, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(195, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña:";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(162, 120);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(167, 20);
            this.txtusuario.TabIndex = 4;
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(162, 189);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(167, 20);
            this.txtclave.TabIndex = 5;
            // 
            // aceptarboton
            // 
            this.aceptarboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aceptarboton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.aceptarboton.IconColor = System.Drawing.Color.Black;
            this.aceptarboton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.aceptarboton.Location = new System.Drawing.Point(162, 229);
            this.aceptarboton.Name = "aceptarboton";
            this.aceptarboton.Size = new System.Drawing.Size(75, 23);
            this.aceptarboton.TabIndex = 6;
            this.aceptarboton.Text = "Aceptar";
            this.aceptarboton.UseVisualStyleBackColor = true;
            this.aceptarboton.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // cancelarboton
            // 
            this.cancelarboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarboton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.cancelarboton.IconColor = System.Drawing.Color.Black;
            this.cancelarboton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cancelarboton.Location = new System.Drawing.Point(254, 229);
            this.cancelarboton.Name = "cancelarboton";
            this.cancelarboton.Size = new System.Drawing.Size(75, 23);
            this.cancelarboton.TabIndex = 7;
            this.cancelarboton.Text = "Cancelar";
            this.cancelarboton.UseVisualStyleBackColor = true;
            this.cancelarboton.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(486, 274);
            this.Controls.Add(this.cancelarboton);
            this.Controls.Add(this.aceptarboton);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtclave;
        private FontAwesome.Sharp.IconButton aceptarboton;
        private FontAwesome.Sharp.IconButton cancelarboton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}