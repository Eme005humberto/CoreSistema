namespace CapaPresentacion
{
    partial class FrmCompras
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblProveedorCaption = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtProveedor = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFlechaProveedor = new Guna.UI2.WinForms.Guna2Button();
            this.lblBuscarCaption = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFlecha = new Guna.UI2.WinForms.Guna2Button();
            this.txtCantidad = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.lblModo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvCompras = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelTotal = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalValor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnComprar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlProveedores = new Guna.UI2.WinForms.Guna2Panel();
            this.lstProveedores = new System.Windows.Forms.ListBox();
            this.pnlSugerencias = new Guna.UI2.WinForms.Guna2Panel();
            this.lstSugerencias = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.panelTotal.SuspendLayout();
            this.pnlProveedores.SuspendLayout();
            this.pnlSugerencias.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProveedorCaption
            // 
            this.lblProveedorCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblProveedorCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblProveedorCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblProveedorCaption.Location = new System.Drawing.Point(26, 14);
            this.lblProveedorCaption.Name = "lblProveedorCaption";
            this.lblProveedorCaption.Size = new System.Drawing.Size(58, 15);
            this.lblProveedorCaption.TabIndex = 0;
            this.lblProveedorCaption.Text = "Proveedor:";
            // 
            // txtProveedor
            // 
            this.txtProveedor.BorderRadius = 8;
            this.txtProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProveedor.DefaultText = "";
            this.txtProveedor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProveedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProveedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProveedor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProveedor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProveedor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProveedor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProveedor.Location = new System.Drawing.Point(34, 32);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.PlaceholderText = "Seleccione un proveedor...";
            this.txtProveedor.SelectedText = "";
            this.txtProveedor.Size = new System.Drawing.Size(291, 36);
            this.txtProveedor.TabIndex = 1;
            this.txtProveedor.TextChanged += new System.EventHandler(this.txtProveedor_TextChanged);
            this.txtProveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProveedor_KeyDown);
            this.txtProveedor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtProveedor_MouseClick);
            // 
            // btnFlechaProveedor
            // 
            this.btnFlechaProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlechaProveedor.FillColor = System.Drawing.Color.White;
            this.btnFlechaProveedor.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.btnFlechaProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnFlechaProveedor.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnFlechaProveedor.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnFlechaProveedor.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnFlechaProveedor.Location = new System.Drawing.Point(325, 32);
            this.btnFlechaProveedor.Name = "btnFlechaProveedor";
            this.btnFlechaProveedor.Size = new System.Drawing.Size(30, 36);
            this.btnFlechaProveedor.TabIndex = 2;
            this.btnFlechaProveedor.Text = "x";
            this.btnFlechaProveedor.Click += new System.EventHandler(this.btnFlechaProveedor_Click);
            // 
            // lblBuscarCaption
            // 
            this.lblBuscarCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblBuscarCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblBuscarCaption.Location = new System.Drawing.Point(26, 92);
            this.lblBuscarCaption.Name = "lblBuscarCaption";
            this.lblBuscarCaption.Size = new System.Drawing.Size(90, 15);
            this.lblBuscarCaption.TabIndex = 3;
            this.lblBuscarCaption.Text = "Buscar producto:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderRadius = 8;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.DefaultText = "";
            this.txtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.Location = new System.Drawing.Point(34, 110);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PlaceholderText = "Buscar producto...";
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.Size = new System.Drawing.Size(291, 36);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            this.txtBuscar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBuscar_MouseClick);
            // 
            // btnFlecha
            // 
            this.btnFlecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlecha.FillColor = System.Drawing.Color.White;
            this.btnFlecha.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.btnFlecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnFlecha.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnFlecha.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnFlecha.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnFlecha.Location = new System.Drawing.Point(325, 110);
            this.btnFlecha.Name = "btnFlecha";
            this.btnFlecha.Size = new System.Drawing.Size(30, 36);
            this.btnFlecha.TabIndex = 5;
            this.btnFlecha.Text = "x";
            this.btnFlecha.Click += new System.EventHandler(this.btnFlecha_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCantidad.BorderRadius = 8;
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCantidad.Location = new System.Drawing.Point(374, 110);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtCantidad.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 36);
            this.txtCantidad.TabIndex = 6;
            this.txtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.FillColor = System.Drawing.Color.Purple;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(480, 110);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 35);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblModo
            // 
            this.lblModo.BackColor = System.Drawing.Color.Transparent;
            this.lblModo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblModo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.lblModo.Location = new System.Drawing.Point(34, 158);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(59, 17);
            this.lblModo.TabIndex = 8;
            this.lblModo.Text = "Carrito (0)";
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompras.ColumnHeadersHeight = 34;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompras.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCompras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dgvCompras.Location = new System.Drawing.Point(34, 182);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.RowHeadersVisible = false;
            this.dgvCompras.Size = new System.Drawing.Size(558, 226);
            this.dgvCompras.TabIndex = 9;
            this.dgvCompras.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dgvCompras.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dgvCompras.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvCompras.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCompras.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvCompras.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCompras.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompras_CellDoubleClick);
            this.dgvCompras.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompras_CellEndEdit);
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelTotal.Controls.Add(this.lblTotalValor);
            this.panelTotal.Controls.Add(this.lblTotal);
            this.panelTotal.Location = new System.Drawing.Point(34, 420);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(180, 56);
            this.panelTotal.TabIndex = 10;
            // 
            // lblTotalValor
            // 
            this.lblTotalValor.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.lblTotalValor.Location = new System.Drawing.Point(10, 26);
            this.lblTotalValor.Name = "lblTotalValor";
            this.lblTotalValor.Size = new System.Drawing.Size(34, 23);
            this.lblTotalValor.TabIndex = 0;
            this.lblTotalValor.Text = "0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblTotal.Location = new System.Drawing.Point(10, 8);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(29, 17);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total";
            // 
            // btnComprar
            // 
            this.btnComprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnComprar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnComprar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnComprar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnComprar.FillColor = System.Drawing.Color.Purple;
            this.btnComprar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnComprar.ForeColor = System.Drawing.Color.White;
            this.btnComprar.Location = new System.Drawing.Point(231, 420);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(170, 56);
            this.btnComprar.TabIndex = 11;
            this.btnComprar.Text = "COMPRAR";
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(422, 420);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(170, 56);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlProveedores
            // 
            this.pnlProveedores.BackColor = System.Drawing.Color.White;
            this.pnlProveedores.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.pnlProveedores.BorderRadius = 6;
            this.pnlProveedores.Controls.Add(this.lstProveedores);
            this.pnlProveedores.Location = new System.Drawing.Point(34, 72);
            this.pnlProveedores.Name = "pnlProveedores";
            this.pnlProveedores.Size = new System.Drawing.Size(321, 110);
            this.pnlProveedores.TabIndex = 13;
            this.pnlProveedores.Visible = false;
            // 
            // lstProveedores
            // 
            this.lstProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstProveedores.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstProveedores.FormattingEnabled = true;
            this.lstProveedores.ItemHeight = 15;
            this.lstProveedores.Location = new System.Drawing.Point(0, 0);
            this.lstProveedores.Name = "lstProveedores";
            this.lstProveedores.Size = new System.Drawing.Size(321, 110);
            this.lstProveedores.TabIndex = 0;
            this.lstProveedores.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstProveedores_MouseClick);
            this.lstProveedores.DoubleClick += new System.EventHandler(this.lstProveedores_DoubleClick);
            // 
            // pnlSugerencias
            // 
            this.pnlSugerencias.BackColor = System.Drawing.Color.White;
            this.pnlSugerencias.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.pnlSugerencias.BorderRadius = 6;
            this.pnlSugerencias.Controls.Add(this.lstSugerencias);
            this.pnlSugerencias.Location = new System.Drawing.Point(34, 150);
            this.pnlSugerencias.Name = "pnlSugerencias";
            this.pnlSugerencias.Size = new System.Drawing.Size(321, 150);
            this.pnlSugerencias.TabIndex = 14;
            this.pnlSugerencias.Visible = false;
            // 
            // lstSugerencias
            // 
            this.lstSugerencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSugerencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSugerencias.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstSugerencias.FormattingEnabled = true;
            this.lstSugerencias.ItemHeight = 15;
            this.lstSugerencias.Location = new System.Drawing.Point(0, 0);
            this.lstSugerencias.Name = "lstSugerencias";
            this.lstSugerencias.Size = new System.Drawing.Size(321, 150);
            this.lstSugerencias.TabIndex = 0;
            this.lstSugerencias.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstSugerencias_MouseClick);
            this.lstSugerencias.DoubleClick += new System.EventHandler(this.lstSugerencias_DoubleClick);
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(620, 490);
            this.Controls.Add(this.lblProveedorCaption);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.btnFlechaProveedor);
            this.Controls.Add(this.lblBuscarCaption);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnFlecha);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblModo);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.panelTotal);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlProveedores);
            this.Controls.Add(this.pnlSugerencias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCompras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.pnlProveedores.ResumeLayout(false);
            this.pnlSugerencias.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Guna.UI2.WinForms.Guna2HtmlLabel lblProveedorCaption;
        private Guna.UI2.WinForms.Guna2TextBox txtProveedor;
        private Guna.UI2.WinForms.Guna2Button btnFlechaProveedor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBuscarCaption;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private Guna.UI2.WinForms.Guna2Button btnFlecha;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtCantidad;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblModo;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCompras;
        private Guna.UI2.WinForms.Guna2Panel panelTotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalValor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotal;
        private Guna.UI2.WinForms.Guna2Button btnComprar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Panel pnlProveedores;
        private System.Windows.Forms.ListBox lstProveedores;
        private Guna.UI2.WinForms.Guna2Panel pnlSugerencias;
        private System.Windows.Forms.ListBox lstSugerencias;
    }
}