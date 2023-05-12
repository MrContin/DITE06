namespace Dashboard_DI04.CONTROL_USUARIOS
{
    partial class InformacionUC
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_client = new System.Windows.Forms.DataGridView();
            this.btn_generar_reporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_client)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_client
            // 
            this.DGV_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_client.Location = new System.Drawing.Point(3, 0);
            this.DGV_client.Name = "DGV_client";
            this.DGV_client.RowHeadersWidth = 51;
            this.DGV_client.RowTemplate.Height = 24;
            this.DGV_client.Size = new System.Drawing.Size(525, 436);
            this.DGV_client.TabIndex = 0;
            this.DGV_client.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_client_CellContentClick);
            this.DGV_client.DoubleClick += new System.EventHandler(this.DGV_client_DoubleClick);
            // 
            // btn_generar_reporte
            // 
            this.btn_generar_reporte.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar_reporte.Location = new System.Drawing.Point(545, 127);
            this.btn_generar_reporte.Name = "btn_generar_reporte";
            this.btn_generar_reporte.Size = new System.Drawing.Size(157, 75);
            this.btn_generar_reporte.TabIndex = 1;
            this.btn_generar_reporte.Text = "GENERAR PDF";
            this.btn_generar_reporte.UseVisualStyleBackColor = true;
            this.btn_generar_reporte.Click += new System.EventHandler(this.btn_generar_reporte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(579, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // InformacionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_generar_reporte);
            this.Controls.Add(this.DGV_client);
            this.Name = "InformacionUC";
            this.Size = new System.Drawing.Size(718, 436);
            this.Load += new System.EventHandler(this.InformacionUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_client)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_client;
        private System.Windows.Forms.Button btn_generar_reporte;
        public System.Windows.Forms.Label label1;
    }
}
