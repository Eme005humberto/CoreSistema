namespace CapaPresentacion
{
    partial class FrmReportes
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
            this.btnReporteVentas = new Guna.UI2.WinForms.Guna2Button();
            this.btnReporteCompras = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(20, 20);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(90, 26);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Reportes";
            // 
            // btnReporteVentas
            // 
            this.btnReporteVentas.BorderRadius = 6;
            this.btnReporteVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteVentas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReporteVentas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReporteVentas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReporteVentas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReporteVentas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.btnReporteVentas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReporteVentas.ForeColor = System.Drawing.Color.White;
            this.btnReporteVentas.Location = new System.Drawing.Point(200, 130);
            this.btnReporteVentas.Name = "btnReporteVentas";
            this.btnReporteVentas.Size = new System.Drawing.Size(220, 60);
            this.btnReporteVentas.TabIndex = 1;
            this.btnReporteVentas.Text = "Reporte de Ventas";
            this.btnReporteVentas.Click += new System.EventHandler(this.btnReporteVentas_Click);
            // 
            // btnReporteCompras
            // 
            this.btnReporteCompras.BorderRadius = 6;
            this.btnReporteCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteCompras.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReporteCompras.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReporteCompras.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReporteCompras.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReporteCompras.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.btnReporteCompras.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReporteCompras.ForeColor = System.Drawing.Color.White;
            this.btnReporteCompras.Location = new System.Drawing.Point(200, 210);
            this.btnReporteCompras.Name = "btnReporteCompras";
            this.btnReporteCompras.Size = new System.Drawing.Size(220, 60);
            this.btnReporteCompras.TabIndex = 2;
            this.btnReporteCompras.Text = "Reporte de Compras";
            this.btnReporteCompras.Click += new System.EventHandler(this.btnReporteCompras_Click);
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(620, 430);
            this.Controls.Add(this.btnReporteCompras);
            this.Controls.Add(this.btnReporteVentas);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportes";
            this.Text = "Reportes";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnReporteVentas;
        private Guna.UI2.WinForms.Guna2Button btnReporteCompras;
    }
}
