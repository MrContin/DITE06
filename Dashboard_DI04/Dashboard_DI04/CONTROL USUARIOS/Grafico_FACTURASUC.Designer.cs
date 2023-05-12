namespace Dashboard_DI04.CONTROL_USUARIOS
{
    partial class Grafico_FACTURASUC
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_Pedidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Pedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_Pedidos
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Pedidos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Pedidos.Legends.Add(legend1);
            this.chart_Pedidos.Location = new System.Drawing.Point(0, 0);
            this.chart_Pedidos.Name = "chart_Pedidos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "FACTURACION";
            this.chart_Pedidos.Series.Add(series1);
            this.chart_Pedidos.Size = new System.Drawing.Size(615, 520);
            this.chart_Pedidos.TabIndex = 0;
            this.chart_Pedidos.Text = "chart1";
            // 
            // Grafico_FACTURASUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart_Pedidos);
            this.Name = "Grafico_FACTURASUC";
            this.Size = new System.Drawing.Size(615, 566);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Pedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Pedidos;
    }
}
