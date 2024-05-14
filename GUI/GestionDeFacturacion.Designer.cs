namespace GUI
{
    partial class GestionDeFacturacion
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
            this.CrearFactura = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TbValorUnitario = new System.Windows.Forms.TextBox();
            this.TbReferencia = new System.Windows.Forms.TextBox();
            this.TbCantidad = new System.Windows.Forms.TextBox();
            this.TbNombreProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtNuevaFactura = new System.Windows.Forms.Button();
            this.BTGuardarFactura = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ConsultaFacturas = new System.Windows.Forms.TabPage();
            this.DgvFactura = new System.Windows.Forms.DataGridView();
            this.BtVolverMenuPrincipal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtSalir = new System.Windows.Forms.Button();
            this.DetalleFacturas = new System.Windows.Forms.TabPage();
            this.DgvDetalleFactura = new System.Windows.Forms.DataGridView();
            this.TbTotalPago = new System.Windows.Forms.TextBox();
            this.DtFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.IdFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDetalleFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReferenciaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.CrearFactura.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.ConsultaFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFactura)).BeginInit();
            this.DetalleFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.BtVolverMenuPrincipal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 636);
            this.panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CrearFactura);
            this.tabControl1.Controls.Add(this.ConsultaFacturas);
            this.tabControl1.Controls.Add(this.DetalleFacturas);
            this.tabControl1.Location = new System.Drawing.Point(3, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(918, 584);
            this.tabControl1.TabIndex = 3;
            // 
            // CrearFactura
            // 
            this.CrearFactura.Controls.Add(this.panel2);
            this.CrearFactura.Location = new System.Drawing.Point(4, 25);
            this.CrearFactura.Name = "CrearFactura";
            this.CrearFactura.Padding = new System.Windows.Forms.Padding(3);
            this.CrearFactura.Size = new System.Drawing.Size(910, 555);
            this.CrearFactura.TabIndex = 0;
            this.CrearFactura.Text = "Facturacion de productos";
            this.CrearFactura.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DtFechaFactura);
            this.panel2.Controls.Add(this.TbTotalPago);
            this.panel2.Controls.Add(this.TbValorUnitario);
            this.panel2.Controls.Add(this.TbReferencia);
            this.panel2.Controls.Add(this.TbCantidad);
            this.panel2.Controls.Add(this.TbNombreProducto);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(7, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 543);
            this.panel2.TabIndex = 0;
            // 
            // TbValorUnitario
            // 
            this.TbValorUnitario.Location = new System.Drawing.Point(241, 303);
            this.TbValorUnitario.Multiline = true;
            this.TbValorUnitario.Name = "TbValorUnitario";
            this.TbValorUnitario.Size = new System.Drawing.Size(126, 27);
            this.TbValorUnitario.TabIndex = 19;
            // 
            // TbReferencia
            // 
            this.TbReferencia.Location = new System.Drawing.Point(241, 120);
            this.TbReferencia.Multiline = true;
            this.TbReferencia.Name = "TbReferencia";
            this.TbReferencia.Size = new System.Drawing.Size(65, 27);
            this.TbReferencia.TabIndex = 18;
            // 
            // TbCantidad
            // 
            this.TbCantidad.Location = new System.Drawing.Point(241, 181);
            this.TbCantidad.Multiline = true;
            this.TbCantidad.Name = "TbCantidad";
            this.TbCantidad.Size = new System.Drawing.Size(65, 27);
            this.TbCantidad.TabIndex = 17;
            // 
            // TbNombreProducto
            // 
            this.TbNombreProducto.Location = new System.Drawing.Point(241, 242);
            this.TbNombreProducto.Multiline = true;
            this.TbNombreProducto.Name = "TbNombreProducto";
            this.TbNombreProducto.Size = new System.Drawing.Size(193, 27);
            this.TbNombreProducto.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(96, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Valor Unitario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nombre Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Referencia del producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fecha de la Factura";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BtNuevaFactura);
            this.panel5.Controls.Add(this.BTGuardarFactura);
            this.panel5.Location = new System.Drawing.Point(598, 111);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(272, 309);
            this.panel5.TabIndex = 9;
            // 
            // BtNuevaFactura
            // 
            this.BtNuevaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtNuevaFactura.Location = new System.Drawing.Point(20, 91);
            this.BtNuevaFactura.Name = "BtNuevaFactura";
            this.BtNuevaFactura.Size = new System.Drawing.Size(234, 52);
            this.BtNuevaFactura.TabIndex = 5;
            this.BtNuevaFactura.Text = "Nueva Factura";
            this.BtNuevaFactura.UseVisualStyleBackColor = true;
            // 
            // BTGuardarFactura
            // 
            this.BTGuardarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTGuardarFactura.Location = new System.Drawing.Point(20, 15);
            this.BTGuardarFactura.Name = "BTGuardarFactura";
            this.BTGuardarFactura.Size = new System.Drawing.Size(234, 52);
            this.BTGuardarFactura.TabIndex = 0;
            this.BTGuardarFactura.Text = "Guardar Factura";
            this.BTGuardarFactura.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total a pagar";
            // 
            // ConsultaFacturas
            // 
            this.ConsultaFacturas.Controls.Add(this.DgvFactura);
            this.ConsultaFacturas.Location = new System.Drawing.Point(4, 25);
            this.ConsultaFacturas.Name = "ConsultaFacturas";
            this.ConsultaFacturas.Padding = new System.Windows.Forms.Padding(3);
            this.ConsultaFacturas.Size = new System.Drawing.Size(910, 555);
            this.ConsultaFacturas.TabIndex = 1;
            this.ConsultaFacturas.Text = "Consulta de Facturas";
            this.ConsultaFacturas.UseVisualStyleBackColor = true;
            // 
            // DgvFactura
            // 
            this.DgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFactura,
            this.FechaFactura,
            this.ValorTotal});
            this.DgvFactura.Location = new System.Drawing.Point(4, 7);
            this.DgvFactura.Name = "DgvFactura";
            this.DgvFactura.RowHeadersWidth = 51;
            this.DgvFactura.RowTemplate.Height = 24;
            this.DgvFactura.Size = new System.Drawing.Size(901, 536);
            this.DgvFactura.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(317, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu Gestion de Facturacion";
            // 
            // BtSalir
            // 
            this.BtSalir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSalir.Location = new System.Drawing.Point(901, 6);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(24, 27);
            this.BtSalir.TabIndex = 10;
            this.BtSalir.Text = "X";
            this.BtSalir.UseVisualStyleBackColor = false;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // DetalleFacturas
            // 
            this.DetalleFacturas.Controls.Add(this.DgvDetalleFactura);
            this.DetalleFacturas.Location = new System.Drawing.Point(4, 25);
            this.DetalleFacturas.Name = "DetalleFacturas";
            this.DetalleFacturas.Size = new System.Drawing.Size(910, 555);
            this.DetalleFacturas.TabIndex = 2;
            this.DetalleFacturas.Text = "Detalle de factura";
            this.DetalleFacturas.UseVisualStyleBackColor = true;
            // 
            // DgvDetalleFactura
            // 
            this.DgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalleFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDetalleFactura,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.ReferenciaProducto,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.ValorItem});
            this.DgvDetalleFactura.Location = new System.Drawing.Point(5, 9);
            this.DgvDetalleFactura.Name = "DgvDetalleFactura";
            this.DgvDetalleFactura.RowHeadersWidth = 51;
            this.DgvDetalleFactura.RowTemplate.Height = 24;
            this.DgvDetalleFactura.Size = new System.Drawing.Size(901, 536);
            this.DgvDetalleFactura.TabIndex = 1;
            // 
            // TbTotalPago
            // 
            this.TbTotalPago.Location = new System.Drawing.Point(241, 364);
            this.TbTotalPago.Multiline = true;
            this.TbTotalPago.Name = "TbTotalPago";
            this.TbTotalPago.Size = new System.Drawing.Size(126, 27);
            this.TbTotalPago.TabIndex = 20;
            // 
            // DtFechaFactura
            // 
            this.DtFechaFactura.Location = new System.Drawing.Point(241, 61);
            this.DtFechaFactura.Name = "DtFechaFactura";
            this.DtFechaFactura.Size = new System.Drawing.Size(243, 22);
            this.DtFechaFactura.TabIndex = 11;
            // 
            // IdFactura
            // 
            this.IdFactura.HeaderText = "Id Factura";
            this.IdFactura.MinimumWidth = 6;
            this.IdFactura.Name = "IdFactura";
            this.IdFactura.Width = 125;
            // 
            // FechaFactura
            // 
            this.FechaFactura.HeaderText = "Fecha de la Factura";
            this.FechaFactura.MinimumWidth = 6;
            this.FechaFactura.Name = "FechaFactura";
            this.FechaFactura.Width = 125;
            // 
            // ValorTotal
            // 
            this.ValorTotal.HeaderText = "Valor Total Facturado";
            this.ValorTotal.MinimumWidth = 6;
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.Width = 125;
            // 
            // IdDetalleFactura
            // 
            this.IdDetalleFactura.HeaderText = "Id de Detalle";
            this.IdDetalleFactura.MinimumWidth = 6;
            this.IdDetalleFactura.Name = "IdDetalleFactura";
            this.IdDetalleFactura.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id Factura";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha de Factura";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // ReferenciaProducto
            // 
            this.ReferenciaProducto.HeaderText = "Referencia del Producto";
            this.ReferenciaProducto.MinimumWidth = 6;
            this.ReferenciaProducto.Name = "ReferenciaProducto";
            this.ReferenciaProducto.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre del Producto";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio Unitario";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // ValorItem
            // 
            this.ValorItem.HeaderText = "Valor Ítem Vendido";
            this.ValorItem.MinimumWidth = 6;
            this.ValorItem.Name = "ValorItem";
            this.ValorItem.Width = 125;
            // 
            // GestionDeFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 681);
            this.Controls.Add(this.BtSalir);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionDeFacturacion";
            this.Text = "GestionDeFacturacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.CrearFactura.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ConsultaFacturas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFactura)).EndInit();
            this.DetalleFacturas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CrearFactura;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TbValorUnitario;
        private System.Windows.Forms.TextBox TbReferencia;
        private System.Windows.Forms.TextBox TbCantidad;
        private System.Windows.Forms.TextBox TbNombreProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtNuevaFactura;
        private System.Windows.Forms.Button BTGuardarFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage ConsultaFacturas;
        private System.Windows.Forms.DataGridView DgvFactura;
        private System.Windows.Forms.Button BtVolverMenuPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtSalir;
        private System.Windows.Forms.TabPage DetalleFacturas;
        private System.Windows.Forms.DataGridView DgvDetalleFactura;
        private System.Windows.Forms.DateTimePicker DtFechaFactura;
        private System.Windows.Forms.TextBox TbTotalPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDetalleFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReferenciaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorItem;
    }
}