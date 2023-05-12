namespace Dashboard_DI04.FORMULARIOS
{
    partial class Reporte_Product
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
            this.lbl_cliente_report = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.crv_productos = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Report_Product1 = new Dashboard_DI04.Report_Product();
            this.btn_generar = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // lbl_cliente_report
            // 
            this.lbl_cliente_report.AutoSize = true;
            this.lbl_cliente_report.Location = new System.Drawing.Point(190, 29);
            this.lbl_cliente_report.Name = "lbl_cliente_report";
            this.lbl_cliente_report.Size = new System.Drawing.Size(0, 16);
            this.lbl_cliente_report.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(47, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente ID";
            // 
            // crv_productos
            // 
            this.crv_productos.ActiveViewIndex = -1;
            this.crv_productos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crv_productos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_productos.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_productos.Location = new System.Drawing.Point(-8, 114);
            this.crv_productos.Name = "crv_productos";
            this.crv_productos.ReportSource = this.Report_Product1;
            this.crv_productos.Size = new System.Drawing.Size(1615, 776);
            this.crv_productos.TabIndex = 2;
            // 
            // btn_generar
            // 
            this.helpProvider1.SetHelpKeyword(this.btn_generar, "");
            this.helpProvider1.SetHelpString(this.btn_generar, "CLICK PARA VOLVER AL INICIO");
            this.btn_generar.Location = new System.Drawing.Point(1403, 33);
            this.btn_generar.Name = "btn_generar";
            this.helpProvider1.SetShowHelp(this.btn_generar, true);
            this.btn_generar.Size = new System.Drawing.Size(96, 23);
            this.btn_generar.TabIndex = 3;
            this.btn_generar.Text = "VOLVER";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // Reporte_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1606, 887);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.crv_productos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_cliente_report);
            this.HelpButton = true;
            this.helpProvider1.SetHelpKeyword(this, "");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reporte_Product";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Reporte_Product";
            this.Load += new System.EventHandler(this.Reporte_Product_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_cliente_report;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_productos;
        private Report_Product Report_Product1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        public System.Windows.Forms.Button btn_generar;
    }
}