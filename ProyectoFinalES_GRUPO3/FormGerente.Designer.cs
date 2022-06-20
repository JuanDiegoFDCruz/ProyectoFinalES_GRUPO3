namespace ProyectoFinalES_GRUPO3
{
    partial class FormGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerente));
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsuarioR = new System.Windows.Forms.TextBox();
            this.txtProductoR = new System.Windows.Forms.TextBox();
            this.txtPrecioR = new System.Windows.Forms.TextBox();
            this.txtPrioridadR = new System.Windows.Forms.TextBox();
            this.lstVentas = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.ForeColor = System.Drawing.Color.Red;
            this.btnRegister.Location = new System.Drawing.Point(463, 102);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(135, 23);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Registrar Venta";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.White;
            this.btnListar.ForeColor = System.Drawing.Color.Red;
            this.btnListar.Location = new System.Drawing.Point(463, 168);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(135, 23);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar Venta";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(183, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "SUPERIOR SPORTS PERÚ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(73, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(73, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(73, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Prioridad:";
            // 
            // txtUsuarioR
            // 
            this.txtUsuarioR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUsuarioR.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuarioR.ForeColor = System.Drawing.Color.Black;
            this.txtUsuarioR.Location = new System.Drawing.Point(186, 62);
            this.txtUsuarioR.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuarioR.Name = "txtUsuarioR";
            this.txtUsuarioR.Size = new System.Drawing.Size(146, 24);
            this.txtUsuarioR.TabIndex = 8;
            // 
            // txtProductoR
            // 
            this.txtProductoR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtProductoR.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductoR.ForeColor = System.Drawing.Color.Black;
            this.txtProductoR.Location = new System.Drawing.Point(186, 104);
            this.txtProductoR.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductoR.Name = "txtProductoR";
            this.txtProductoR.Size = new System.Drawing.Size(229, 24);
            this.txtProductoR.TabIndex = 9;
            // 
            // txtPrecioR
            // 
            this.txtPrecioR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPrecioR.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecioR.ForeColor = System.Drawing.Color.Black;
            this.txtPrecioR.Location = new System.Drawing.Point(186, 145);
            this.txtPrecioR.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioR.Name = "txtPrecioR";
            this.txtPrecioR.Size = new System.Drawing.Size(71, 24);
            this.txtPrecioR.TabIndex = 10;
            // 
            // txtPrioridadR
            // 
            this.txtPrioridadR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPrioridadR.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrioridadR.ForeColor = System.Drawing.Color.Black;
            this.txtPrioridadR.Location = new System.Drawing.Point(186, 187);
            this.txtPrioridadR.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrioridadR.Name = "txtPrioridadR";
            this.txtPrioridadR.Size = new System.Drawing.Size(109, 24);
            this.txtPrioridadR.TabIndex = 11;
            // 
            // lstVentas
            // 
            this.lstVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lstVentas.ForeColor = System.Drawing.Color.Black;
            this.lstVentas.FormattingEnabled = true;
            this.lstVentas.ItemHeight = 17;
            this.lstVentas.Location = new System.Drawing.Point(73, 232);
            this.lstVentas.Margin = new System.Windows.Forms.Padding(2);
            this.lstVentas.Name = "lstVentas";
            this.lstVentas.Size = new System.Drawing.Size(497, 123);
            this.lstVentas.TabIndex = 12;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(507, 379);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(158, 41);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(663, 420);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lstVentas);
            this.Controls.Add(this.txtPrioridadR);
            this.Controls.Add(this.txtPrecioR);
            this.Controls.Add(this.txtProductoR);
            this.Controls.Add(this.txtUsuarioR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnRegister);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegister;
        private Button btnListar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUsuarioR;
        private TextBox txtProductoR;
        private TextBox txtPrecioR;
        private TextBox txtPrioridadR;
        private ListBox lstVentas;
        private Button btnSalir;
    }
}