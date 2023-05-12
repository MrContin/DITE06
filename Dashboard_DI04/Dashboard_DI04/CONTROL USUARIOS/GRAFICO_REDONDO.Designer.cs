namespace Dashboard_DI04.CONTROL_USUARIOS
{
    partial class GRAFICO_REDONDO
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
            this.chart_Categorias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_rpt_categorias = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Categorias)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_Categorias
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Categorias.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Categorias.Legends.Add(legend1);
            this.chart_Categorias.Location = new System.Drawing.Point(3, 3);
            this.chart_Categorias.Name = "chart_Categorias";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_Categorias.Series.Add(series1);
            this.chart_Categorias.Size = new System.Drawing.Size(696, 527);
            this.chart_Categorias.TabIndex = 0;
            this.chart_Categorias.Text = "chart1";
            // 
            // btn_rpt_categorias
            // 
            this.btn_rpt_categorias.Location = new System.Drawing.Point(575, 253);
            this.btn_rpt_categorias.Name = "btn_rpt_categorias";
            this.btn_rpt_categorias.Size = new System.Drawing.Size(124, 40);
            this.btn_rpt_categorias.TabIndex = 1;
            this.btn_rpt_categorias.Text = "Reporte";
            this.btn_rpt_categorias.UseVisualStyleBackColor = true;
            this.btn_rpt_categorias.Click += new System.EventHandler(this.btn_rpt_categorias_Click);
            // 
            // GRAFICO_REDONDO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_rpt_categorias);
            this.Controls.Add(this.chart_Categorias);
            this.Name = "GRAFICO_REDONDO";
            this.Size = new System.Drawing.Size(734, 590);
            this.Load += new System.EventHandler(this.GRAFICO_REDONDO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Categorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Categorias;
        private System.Windows.Forms.Button btn_rpt_categorias;
    }
}
