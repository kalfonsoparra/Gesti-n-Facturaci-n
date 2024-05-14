namespace GUI
{
    partial class MenuPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtSalir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtGestionProducto = new System.Windows.Forms.Button();
            this.BtFacturacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.BtSalir);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(114, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 641);
            this.panel1.TabIndex = 1;
            // 
            // BtSalir
            // 
            this.BtSalir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSalir.Location = new System.Drawing.Point(462, 0);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(24, 27);
            this.BtSalir.TabIndex = 7;
            this.BtSalir.Text = "X";
            this.BtSalir.UseVisualStyleBackColor = false;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtGestionProducto);
            this.panel2.Controls.Add(this.BtFacturacion);
            this.panel2.Location = new System.Drawing.Point(65, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 293);
            this.panel2.TabIndex = 6;
            // 
            // BtGestionProducto
            // 
            this.BtGestionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtGestionProducto.Location = new System.Drawing.Point(46, 48);
            this.BtGestionProducto.Name = "BtGestionProducto";
            this.BtGestionProducto.Size = new System.Drawing.Size(264, 70);
            this.BtGestionProducto.TabIndex = 6;
            this.BtGestionProducto.Text = "Gestion de Producto";
            this.BtGestionProducto.UseVisualStyleBackColor = true;
            this.BtGestionProducto.Click += new System.EventHandler(this.BtGestionProducto_Click);
            // 
            // BtFacturacion
            // 
            this.BtFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtFacturacion.Location = new System.Drawing.Point(46, 143);
            this.BtFacturacion.Name = "BtFacturacion";
            this.BtFacturacion.Size = new System.Drawing.Size(264, 70);
            this.BtFacturacion.TabIndex = 3;
            this.BtFacturacion.Text = "Facturacion";
            this.BtFacturacion.UseVisualStyleBackColor = true;
            this.BtFacturacion.Click += new System.EventHandler(this.BtFacturacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Facturacion de productos";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 645);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtGestionProducto;
        private System.Windows.Forms.Button BtFacturacion;
        private System.Windows.Forms.Label label1;
    }
}

