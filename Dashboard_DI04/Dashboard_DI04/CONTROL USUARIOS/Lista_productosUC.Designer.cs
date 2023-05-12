namespace Dashboard_DI04.CONTROL_USUARIOS
{
    partial class Lista_productosUC
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
            this.listView_Produc_cantidad = new System.Windows.Forms.ListView();
            this.PRODUCTOS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CANTIDAD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView_Produc_cantidad
            // 
            this.listView_Produc_cantidad.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PRODUCTOS,
            this.CANTIDAD});
            this.listView_Produc_cantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Produc_cantidad.HideSelection = false;
            this.listView_Produc_cantidad.Location = new System.Drawing.Point(0, 0);
            this.listView_Produc_cantidad.Name = "listView_Produc_cantidad";
            this.listView_Produc_cantidad.Size = new System.Drawing.Size(633, 558);
            this.listView_Produc_cantidad.TabIndex = 0;
            this.listView_Produc_cantidad.UseCompatibleStateImageBehavior = false;
            this.listView_Produc_cantidad.View = System.Windows.Forms.View.Details;
            this.listView_Produc_cantidad.SelectedIndexChanged += new System.EventHandler(this.listView_Produc_cantidad_SelectedIndexChanged);
            // 
            // PRODUCTOS
            // 
            this.PRODUCTOS.Tag = "PRODUCTOS";
            this.PRODUCTOS.Text = "PRODUCTOS";
            this.PRODUCTOS.Width = 245;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.Tag = "CANTIDAD";
            this.CANTIDAD.Text = "CANTIDAD";
            this.CANTIDAD.Width = 224;
            // 
            // Lista_productosUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView_Produc_cantidad);
            this.Name = "Lista_productosUC";
            this.Size = new System.Drawing.Size(633, 558);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Produc_cantidad;
        private System.Windows.Forms.ColumnHeader PRODUCTOS;
        private System.Windows.Forms.ColumnHeader CANTIDAD;
    }
}
