namespace CapaPresentacion
{
    partial class FrmPuntoVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPuntoVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCantidad = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCargos = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnReportes = new Guna.UI2.WinForms.Guna2Button();
            this.btnCategorias = new Guna.UI2.WinForms.Guna2Button();
            this.btnProveedores = new Guna.UI2.WinForms.Guna2Button();
            this.btnVentas = new Guna.UI2.WinForms.Guna2Button();
            this.btnInventario = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboBuscarProducto = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFlecha = new Guna.UI2.WinForms.Guna2Button();
            this.pnlSugerencias = new Guna.UI2.WinForms.Guna2Panel();
            this.lstSugerencias = new System.Windows.Forms.ListBox();
            this.dgvCarrito = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelTotal = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalValor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCobrar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelarVenta = new Guna.UI2.WinForms.Guna2Button();
            this.pnlContenido = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlVentas = new Guna.UI2.WinForms.Guna2Panel();
            this.lblModo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblBuscarCaption = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.pnlSugerencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.panelTotal.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlVentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.Transparent;
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCantidad.Location = new System.Drawing.Point(374, 12);
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
            this.txtCantidad.TabIndex = 0;
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
            this.btnAgregar.Location = new System.Drawing.Point(480, 13);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 35);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Purple;
            this.guna2Panel1.Controls.Add(this.btnCargos);
            this.guna2Panel1.Controls.Add(this.guna2Button4);
            this.guna2Panel1.Controls.Add(this.guna2Button3);
            this.guna2Panel1.Controls.Add(this.btnReportes);
            this.guna2Panel1.Controls.Add(this.btnCategorias);
            this.guna2Panel1.Controls.Add(this.btnProveedores);
            this.guna2Panel1.Controls.Add(this.btnVentas);
            this.guna2Panel1.Controls.Add(this.btnInventario);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(180, 490);
            this.guna2Panel1.TabIndex = 2;
            // 
            // btnCargos
            // 
            this.btnCargos.BorderRadius = 3;
            this.btnCargos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCargos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCargos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCargos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCargos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCargos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCargos.ForeColor = System.Drawing.Color.White;
            this.btnCargos.Image = ((System.Drawing.Image)(resources.GetObject("btnCargos.Image")));
            this.btnCargos.Location = new System.Drawing.Point(12, 417);
            this.btnCargos.Name = "btnCargos";
            this.btnCargos.Size = new System.Drawing.Size(150, 38);
            this.btnCargos.TabIndex = 10;
            this.btnCargos.Text = "Cargos";
            this.btnCargos.Click += new System.EventHandler(this.btnCargos_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderRadius = 3;
            this.guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button4.Image")));
            this.guna2Button4.Location = new System.Drawing.Point(12, 368);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(150, 38);
            this.guna2Button4.TabIndex = 9;
            this.guna2Button4.Text = "Compras";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 3;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.Location = new System.Drawing.Point(12, 319);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(150, 38);
            this.guna2Button3.TabIndex = 8;
            this.guna2Button3.Text = "Usuarios";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BorderRadius = 3;
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReportes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReportes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReportes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReportes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.Location = new System.Drawing.Point(12, 266);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(150, 38);
            this.btnReportes.TabIndex = 7;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BorderRadius = 3;
            this.btnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategorias.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCategorias.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCategorias.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCategorias.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCategorias.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCategorias.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCategorias.ForeColor = System.Drawing.Color.White;
            this.btnCategorias.Image = ((System.Drawing.Image)(resources.GetObject("btnCategorias.Image")));
            this.btnCategorias.Location = new System.Drawing.Point(12, 212);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(150, 38);
            this.btnCategorias.TabIndex = 6;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BorderRadius = 3;
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProveedores.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProveedores.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProveedores.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProveedores.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnProveedores.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Image")));
            this.btnProveedores.Location = new System.Drawing.Point(12, 156);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(150, 38);
            this.btnProveedores.TabIndex = 4;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BorderRadius = 3;
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVentas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVentas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVentas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVentas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnVentas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.Location = new System.Drawing.Point(12, 100);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(150, 38);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.Indigo;
            this.btnInventario.BorderRadius = 3;
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInventario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInventario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInventario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInventario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnInventario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnInventario.Image")));
            this.btnInventario.Location = new System.Drawing.Point(12, 43);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(150, 38);
            this.btnInventario.TabIndex = 1;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(40, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(108, 15);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Sistema de Ventas";
            // 
            // cboBuscarProducto
            // 
            this.cboBuscarProducto.BorderRadius = 8;
            this.cboBuscarProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cboBuscarProducto.DefaultText = "";
            this.cboBuscarProducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cboBuscarProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cboBuscarProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cboBuscarProducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cboBuscarProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboBuscarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboBuscarProducto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboBuscarProducto.Location = new System.Drawing.Point(34, 13);
            this.cboBuscarProducto.Name = "cboBuscarProducto";
            this.cboBuscarProducto.PlaceholderText = "Buscar producto...";
            this.cboBuscarProducto.SelectedText = "";
            this.cboBuscarProducto.Size = new System.Drawing.Size(291, 36);
            this.cboBuscarProducto.TabIndex = 3;
            this.cboBuscarProducto.TextChanged += new System.EventHandler(this.cboBuscarProducto_TextChanged);
            this.cboBuscarProducto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboBuscarProducto_MouseClick);
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
            this.btnFlecha.Location = new System.Drawing.Point(325, 13);
            this.btnFlecha.Name = "btnFlecha";
            this.btnFlecha.Size = new System.Drawing.Size(30, 36);
            this.btnFlecha.TabIndex = 13;
            this.btnFlecha.Text = "x";
            this.btnFlecha.Click += new System.EventHandler(this.btnFlecha_Click);
            // 
            // pnlSugerencias
            // 
            this.pnlSugerencias.BackColor = System.Drawing.Color.White;
            this.pnlSugerencias.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.pnlSugerencias.BorderRadius = 6;
            this.pnlSugerencias.Controls.Add(this.lstSugerencias);
            this.pnlSugerencias.Location = new System.Drawing.Point(34, 55);
            this.pnlSugerencias.Name = "pnlSugerencias";
            this.pnlSugerencias.Size = new System.Drawing.Size(321, 170);
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
            this.lstSugerencias.Size = new System.Drawing.Size(321, 170);
            this.lstSugerencias.TabIndex = 0;
            this.lstSugerencias.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstSugerencias_MouseClick);
            this.lstSugerencias.DoubleClick += new System.EventHandler(this.lstSugerencias_DoubleClick);
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AllowUserToAddRows = false;
            this.dgvCarrito.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgvCarrito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCarrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCarrito.ColumnHeadersHeight = 30;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarrito.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCarrito.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgvCarrito.Location = new System.Drawing.Point(34, 86);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.ReadOnly = true;
            this.dgvCarrito.RowHeadersVisible = false;
            this.dgvCarrito.Size = new System.Drawing.Size(558, 260);
            this.dgvCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCarrito.TabIndex = 5;
            this.dgvCarrito.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.dgvCarrito.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgvCarrito.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgvCarrito.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.dgvCarrito.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCarrito.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvCarrito.ThemeStyle.ReadOnly = true;
            this.dgvCarrito.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.dgvCarrito.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCarrito.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCarrito.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.dgvCarrito.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCarrito.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrito_CellDoubleClick);
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelTotal.BorderRadius = 8;
            this.panelTotal.Controls.Add(this.lblTotalValor);
            this.panelTotal.Controls.Add(this.lblTotal);
            this.panelTotal.Location = new System.Drawing.Point(34, 360);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(180, 60);
            this.panelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelTotal.TabIndex = 6;
            // 
            // lblTotalValor
            // 
            this.lblTotalValor.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValor.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotalValor.Location = new System.Drawing.Point(10, 28);
            this.lblTotalValor.Name = "lblTotalValor";
            this.lblTotalValor.Size = new System.Drawing.Size(35, 20);
            this.lblTotalValor.TabIndex = 1;
            this.lblTotalValor.Text = "0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotal.Location = new System.Drawing.Point(10, 8);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 18);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total";
            // 
            // btnCobrar
            // 
            this.btnCobrar.BorderRadius = 8;
            this.btnCobrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCobrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCobrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCobrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCobrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCobrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.btnCobrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.Location = new System.Drawing.Point(232, 360);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(170, 60);
            this.btnCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCobrar.TabIndex = 7;
            this.btnCobrar.Text = "COBRAR";
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelarVenta.BorderRadius = 8;
            this.btnCancelarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarVenta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelarVenta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelarVenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelarVenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelarVenta.FillColor = System.Drawing.Color.Transparent;
            this.btnCancelarVenta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelarVenta.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarVenta.Location = new System.Drawing.Point(423, 360);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(170, 60);
            this.btnCancelarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelarVenta.TabIndex = 8;
            this.btnCancelarVenta.Text = "CANCELAR";
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.White;
            this.pnlContenido.Controls.Add(this.pnlVentas);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(180, 0);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(620, 490);
            this.pnlContenido.TabIndex = 9;
            // 
            // pnlVentas
            // 
            this.pnlVentas.BackColor = System.Drawing.Color.White;
            this.pnlVentas.Controls.Add(this.btnCancelarVenta);
            this.pnlVentas.Controls.Add(this.btnCobrar);
            this.pnlVentas.Controls.Add(this.panelTotal);
            this.pnlVentas.Controls.Add(this.dgvCarrito);
            this.pnlVentas.Controls.Add(this.lblModo);
            this.pnlVentas.Controls.Add(this.lblBuscarCaption);
            this.pnlVentas.Controls.Add(this.cboBuscarProducto);
            this.pnlVentas.Controls.Add(this.btnAgregar);
            this.pnlVentas.Controls.Add(this.txtCantidad);
            this.pnlVentas.Controls.Add(this.btnFlecha);
            this.pnlVentas.Controls.Add(this.pnlSugerencias);
            this.pnlVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVentas.Location = new System.Drawing.Point(0, 0);
            this.pnlVentas.Name = "pnlVentas";
            this.pnlVentas.Size = new System.Drawing.Size(620, 490);
            this.pnlVentas.TabIndex = 10;
            // 
            // lblModo
            // 
            this.lblModo.BackColor = System.Drawing.Color.Transparent;
            this.lblModo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblModo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.lblModo.Location = new System.Drawing.Point(34, 60);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(41, 17);
            this.lblModo.TabIndex = 4;
            this.lblModo.Text = "Carrito";
            // 
            // lblBuscarCaption
            // 
            this.lblBuscarCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblBuscarCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblBuscarCaption.Location = new System.Drawing.Point(26, 46);
            this.lblBuscarCaption.Name = "lblBuscarCaption";
            this.lblBuscarCaption.Size = new System.Drawing.Size(90, 15);
            this.lblBuscarCaption.TabIndex = 11;
            this.lblBuscarCaption.Text = "Buscar producto:";
            // 
            // FrmPuntoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "FrmPuntoVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Ventas - Punto de Venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPuntoVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.pnlSugerencias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.pnlContenido.ResumeLayout(false);
            this.pnlVentas.ResumeLayout(false);
            this.pnlVentas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2NumericUpDown txtCantidad;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnVentas;
        private Guna.UI2.WinForms.Guna2Button btnInventario;
        private Guna.UI2.WinForms.Guna2Button btnCategorias;
        private Guna.UI2.WinForms.Guna2Button btnProveedores;
        private Guna.UI2.WinForms.Guna2TextBox cboBuscarProducto;
        private Guna.UI2.WinForms.Guna2Button btnFlecha;
        private Guna.UI2.WinForms.Guna2Panel pnlSugerencias;
        private System.Windows.Forms.ListBox lstSugerencias;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblModo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBuscarCaption;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCarrito;
        private Guna.UI2.WinForms.Guna2Panel panelTotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalValor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotal;
        private Guna.UI2.WinForms.Guna2Button btnCobrar;
        private Guna.UI2.WinForms.Guna2Button btnCancelarVenta;
        private Guna.UI2.WinForms.Guna2Button btnReportes;
        private Guna.UI2.WinForms.Guna2Panel pnlContenido;
        private Guna.UI2.WinForms.Guna2Panel pnlVentas;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button btnCargos;
    }
}
