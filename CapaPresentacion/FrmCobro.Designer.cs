namespace CapaPresentacion
{
    partial class FrmCobro
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalCaption = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblRecibidoCaption = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.numRecibido = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblCambioCaption = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCambio = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCobrar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRecibido)).BeginInit();
            this.SuspendLayout();
            //
            // guna2HtmlLabel1
            //
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(20, 15);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(63, 23);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Cobro";
            //
            // lblTotalCaption
            //
            this.lblTotalCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalCaption.Location = new System.Drawing.Point(20, 60);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(34, 17);
            this.lblTotalCaption.TabIndex = 1;
            this.lblTotalCaption.Text = "Total";
            //
            // lblTotal
            //
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotal.Location = new System.Drawing.Point(110, 58);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 19);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "0.00";
            //
            // lblRecibidoCaption
            //
            this.lblRecibidoCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblRecibidoCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRecibidoCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRecibidoCaption.Location = new System.Drawing.Point(20, 100);
            this.lblRecibidoCaption.Name = "lblRecibidoCaption";
            this.lblRecibidoCaption.Size = new System.Drawing.Size(55, 17);
            this.lblRecibidoCaption.TabIndex = 3;
            this.lblRecibidoCaption.Text = "Recibido";
            //
            // numRecibido
            //
            this.numRecibido.BackColor = System.Drawing.Color.Transparent;
            this.numRecibido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numRecibido.DecimalPlaces = 2;
            this.numRecibido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numRecibido.Location = new System.Drawing.Point(110, 95);
            this.numRecibido.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.numRecibido.Name = "numRecibido";
            this.numRecibido.Size = new System.Drawing.Size(150, 32);
            this.numRecibido.TabIndex = 4;
            this.numRecibido.ThousandsSeparator = true;
            this.numRecibido.ValueChanged += new System.EventHandler(this.numRecibido_ValueChanged);
            //
            // lblCambioCaption
            //
            this.lblCambioCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblCambioCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCambioCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCambioCaption.Location = new System.Drawing.Point(20, 140);
            this.lblCambioCaption.Name = "lblCambioCaption";
            this.lblCambioCaption.Size = new System.Drawing.Size(39, 17);
            this.lblCambioCaption.TabIndex = 5;
            this.lblCambioCaption.Text = "Cambio";
            //
            // lblCambio
            //
            this.lblCambio.BackColor = System.Drawing.Color.Transparent;
            this.lblCambio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCambio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCambio.Location = new System.Drawing.Point(110, 138);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(60, 19);
            this.lblCambio.TabIndex = 6;
            this.lblCambio.Text = "0.00";
            //
            // btnCobrar
            //
            this.btnCobrar.BorderRadius = 5;
            this.btnCobrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCobrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCobrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCobrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCobrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCobrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(153)))), ((int)(((byte)(34)))));
            this.btnCobrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.Location = new System.Drawing.Point(110, 180);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(120, 40);
            this.btnCobrar.TabIndex = 7;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            //
            // btnCancelar
            //
            this.btnCancelar.BorderRadius = 5;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(250, 180);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            //
            // FrmCobro
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(390, 240);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.lblCambioCaption);
            this.Controls.Add(this.numRecibido);
            this.Controls.Add(this.lblRecibidoCaption);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalCaption);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cobro";
            ((System.ComponentModel.ISupportInitialize)(this.numRecibido)).EndInit();
            this.ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalCaption;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRecibidoCaption;
        private Guna.UI2.WinForms.Guna2NumericUpDown numRecibido;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCambioCaption;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCambio;
        private Guna.UI2.WinForms.Guna2Button btnCobrar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
    }
}
