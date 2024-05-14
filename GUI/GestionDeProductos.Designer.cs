namespace GUI
{
    partial class GestionDeProductos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CrearProducto = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtEliminarProducto = new System.Windows.Forms.Button();
            this.BtBuscarProducto = new System.Windows.Forms.Button();
            this.BTGuardar = new System.Windows.Forms.Button();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConsultaProductos = new System.Windows.Forms.TabPage();
            this.BtVolverMenuPrincipal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtSalir = new System.Windows.Forms.Button();
            this.BtActualizarProducto = new System.Windows.Forms.Button();
            this.BtNuevoProducto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TbReferenciaProducto = new System.Windows.Forms.TextBox();
            this.TbNombreProducto = new System.Windows.Forms.TextBox();
            this.TbCantidadProducto = new System.Windows.Forms.TextBox();
            this.TbStockMinimo = new System.Windows.Forms.TextBox();
            this.TbValorUnitario = new System.Windows.Forms.TextBox();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.ReferenciaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.CrearProducto.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.ConsultaProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.BtVolverMenuPrincipal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 636);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CrearProducto);
            this.tabControl1.Controls.Add(this.ConsultaProductos);
            this.tabControl1.Location = new System.Drawing.Point(3, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(918, 584);
            this.tabControl1.TabIndex = 3;
            // 
            // CrearProducto
            // 
            this.CrearProducto.Controls.Add(this.panel2);
            this.CrearProducto.Location = new System.Drawing.Point(4, 25);
            this.CrearProducto.Name = "CrearProducto";
            this.CrearProducto.Padding = new System.Windows.Forms.Padding(3);
            this.CrearProducto.Size = new System.Drawing.Size(910, 555);
            this.CrearProducto.TabIndex = 0;
            this.CrearProducto.Text = "Registro de Producto";
            this.CrearProducto.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TbValorUnitario);
            this.panel2.Controls.Add(this.TbStockMinimo);
            this.panel2.Controls.Add(this.TbCantidadProducto);
            this.panel2.Controls.Add(this.TbNombreProducto);
            this.panel2.Controls.Add(this.TbReferenciaProducto);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.CbEstado);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(7, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 543);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BtNuevoProducto);
            this.panel5.Controls.Add(this.BtActualizarProducto);
            this.panel5.Controls.Add(this.BtEliminarProducto);
            this.panel5.Controls.Add(this.BtBuscarProducto);
            this.panel5.Controls.Add(this.BTGuardar);
            this.panel5.Location = new System.Drawing.Point(598, 111);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(272, 309);
            this.panel5.TabIndex = 9;
            // 
            // BtEliminarProducto
            // 
            this.BtEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEliminarProducto.Location = new System.Drawing.Point(20, 171);
            this.BtEliminarProducto.Name = "BtEliminarProducto";
            this.BtEliminarProducto.Size = new System.Drawing.Size(234, 52);
            this.BtEliminarProducto.TabIndex = 3;
            this.BtEliminarProducto.Text = "Eliminar Producto";
            this.BtEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // BtBuscarProducto
            // 
            this.BtBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBuscarProducto.Location = new System.Drawing.Point(20, 67);
            this.BtBuscarProducto.Name = "BtBuscarProducto";
            this.BtBuscarProducto.Size = new System.Drawing.Size(234, 52);
            this.BtBuscarProducto.TabIndex = 1;
            this.BtBuscarProducto.Text = "Buscar Producto";
            this.BtBuscarProducto.UseVisualStyleBackColor = true;
            this.BtBuscarProducto.Click += new System.EventHandler(this.BtBuscarProducto_Click);
            // 
            // BTGuardar
            // 
            this.BTGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTGuardar.Location = new System.Drawing.Point(20, 15);
            this.BTGuardar.Name = "BTGuardar";
            this.BTGuardar.Size = new System.Drawing.Size(234, 52);
            this.BTGuardar.TabIndex = 0;
            this.BTGuardar.Text = "Guardar Producto";
            this.BTGuardar.UseVisualStyleBackColor = true;
            this.BTGuardar.Click += new System.EventHandler(this.BTGuardar_Click);
            // 
            // CbEstado
            // 
            this.CbEstado.FormattingEnabled = true;
            this.CbEstado.Items.AddRange(new object[] {
            "Escoja la opcion",
            "",
            "Activo",
            "Inactivo"});
            this.CbEstado.Location = new System.Drawing.Point(260, 369);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(141, 24);
            this.CbEstado.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Estado";
            // 
            // ConsultaProductos
            // 
            this.ConsultaProductos.Controls.Add(this.DgvProductos);
            this.ConsultaProductos.Location = new System.Drawing.Point(4, 25);
            this.ConsultaProductos.Name = "ConsultaProductos";
            this.ConsultaProductos.Padding = new System.Windows.Forms.Padding(3);
            this.ConsultaProductos.Size = new System.Drawing.Size(910, 555);
            this.ConsultaProductos.TabIndex = 1;
            this.ConsultaProductos.Text = "Consulta de productos en inventario";
            this.ConsultaProductos.UseVisualStyleBackColor = true;
            // 
            // BtVolverMenuPrincipal
            // 
            this.BtVolverMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtVolverMenuPrincipal.Location = new System.Drawing.Point(3, 3);
            this.BtVolverMenuPrincipal.Name = "BtVolverMenuPrincipal";
            this.BtVolverMenuPrincipal.Size = new System.Drawing.Size(84, 26);
            this.BtVolverMenuPrincipal.TabIndex = 2;
            this.BtVolverMenuPrincipal.Text = "Volver";
            this.BtVolverMenuPrincipal.UseVisualStyleBackColor = true;
            this.BtVolverMenuPrincipal.Click += new System.EventHandler(this.BtVolverMenuPrincipal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu Gestion de producto";
            // 
            // BtSalir
            // 
            this.BtSalir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSalir.Location = new System.Drawing.Point(903, 4);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(24, 27);
            this.BtSalir.TabIndex = 9;
            this.BtSalir.Text = "X";
            this.BtSalir.UseVisualStyleBackColor = false;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // BtActualizarProducto
            // 
            this.BtActualizarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtActualizarProducto.Location = new System.Drawing.Point(20, 119);
            this.BtActualizarProducto.Name = "BtActualizarProducto";
            this.BtActualizarProducto.Size = new System.Drawing.Size(234, 52);
            this.BtActualizarProducto.TabIndex = 4;
            this.BtActualizarProducto.Text = "Actualizar Producto";
            this.BtActualizarProducto.UseVisualStyleBackColor = true;
            this.BtActualizarProducto.Click += new System.EventHandler(this.BtActualizarProducto_Click);
            // 
            // BtNuevoProducto
            // 
            this.BtNuevoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtNuevoProducto.Location = new System.Drawing.Point(20, 229);
            this.BtNuevoProducto.Name = "BtNuevoProducto";
            this.BtNuevoProducto.Size = new System.Drawing.Size(234, 52);
            this.BtNuevoProducto.TabIndex = 5;
            this.BtNuevoProducto.Text = "Nuevo Producto";
            this.BtNuevoProducto.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Referencia del Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre del Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(163, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(128, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Stock Minimo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(127, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Valor Unitario";
            // 
            // TbReferenciaProducto
            // 
            this.TbReferenciaProducto.Location = new System.Drawing.Point(260, 98);
            this.TbReferenciaProducto.Multiline = true;
            this.TbReferenciaProducto.Name = "TbReferenciaProducto";
            this.TbReferenciaProducto.Size = new System.Drawing.Size(108, 27);
            this.TbReferenciaProducto.TabIndex = 15;
            // 
            // TbNombreProducto
            // 
            this.TbNombreProducto.Location = new System.Drawing.Point(260, 152);
            this.TbNombreProducto.Multiline = true;
            this.TbNombreProducto.Name = "TbNombreProducto";
            this.TbNombreProducto.Size = new System.Drawing.Size(193, 27);
            this.TbNombreProducto.TabIndex = 16;
            // 
            // TbCantidadProducto
            // 
            this.TbCantidadProducto.Location = new System.Drawing.Point(260, 206);
            this.TbCantidadProducto.Multiline = true;
            this.TbCantidadProducto.Name = "TbCantidadProducto";
            this.TbCantidadProducto.Size = new System.Drawing.Size(65, 27);
            this.TbCantidadProducto.TabIndex = 17;
            // 
            // TbStockMinimo
            // 
            this.TbStockMinimo.Location = new System.Drawing.Point(260, 260);
            this.TbStockMinimo.Multiline = true;
            this.TbStockMinimo.Name = "TbStockMinimo";
            this.TbStockMinimo.Size = new System.Drawing.Size(65, 27);
            this.TbStockMinimo.TabIndex = 18;
            // 
            // TbValorUnitario
            // 
            this.TbValorUnitario.Location = new System.Drawing.Point(260, 314);
            this.TbValorUnitario.Multiline = true;
            this.TbValorUnitario.Name = "TbValorUnitario";
            this.TbValorUnitario.Size = new System.Drawing.Size(126, 27);
            this.TbValorUnitario.TabIndex = 19;
            // 
            // DgvProductos
            // 
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReferenciaProducto,
            this.NombreProducto,
            this.Cantidad,
            this.PrecioUnitario,
            this.StockMinimo,
            this.Estado});
            this.DgvProductos.Location = new System.Drawing.Point(4, 7);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.RowHeadersWidth = 51;
            this.DgvProductos.RowTemplate.Height = 24;
            this.DgvProductos.Size = new System.Drawing.Size(901, 536);
            this.DgvProductos.TabIndex = 0;
            // 
            // ReferenciaProducto
            // 
            this.ReferenciaProducto.HeaderText = "Referencia Producto";
            this.ReferenciaProducto.MinimumWidth = 6;
            this.ReferenciaProducto.Name = "ReferenciaProducto";
            this.ReferenciaProducto.Width = 125;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre del Producto";
            this.NombreProducto.MinimumWidth = 6;
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.MinimumWidth = 6;
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.Width = 125;
            // 
            // StockMinimo
            // 
            this.StockMinimo.HeaderText = "StockMinimo";
            this.StockMinimo.MinimumWidth = 6;
            this.StockMinimo.Name = "StockMinimo";
            this.StockMinimo.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 125;
            // 
            // GestionDeProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 681);
            this.Controls.Add(this.BtSalir);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionDeProductos";
            this.Text = "GestionDeProductos";
            this.Load += new System.EventHandler(this.GestionDeProductos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.CrearProducto.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ConsultaProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CrearProducto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtEliminarProducto;
        private System.Windows.Forms.Button BtBuscarProducto;
        private System.Windows.Forms.Button BTGuardar;
        private System.Windows.Forms.ComboBox CbEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage ConsultaProductos;
        private System.Windows.Forms.Button BtVolverMenuPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtSalir;
        private System.Windows.Forms.Button BtActualizarProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtNuevoProducto;
        private System.Windows.Forms.TextBox TbStockMinimo;
        private System.Windows.Forms.TextBox TbCantidadProducto;
        private System.Windows.Forms.TextBox TbNombreProducto;
        private System.Windows.Forms.TextBox TbReferenciaProducto;
        private System.Windows.Forms.TextBox TbValorUnitario;
        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReferenciaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}