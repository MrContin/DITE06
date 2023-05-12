using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Dashboard_DI04.FORMULARIOS
{
    public partial class Reporte_Product : Form
    {
        private Formularios FORMULARIOS;
        public Reporte_Product()
        {
            InitializeComponent();
            FORMULARIOS= new Formularios();
            
        }

        private void cargarReporte()
        {

            //ReportDocument cryRpt = new ReportDocument();
            CrystalDecisions.CrystalReports.Engine.ReportDocument crs = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            string path = Path.GetFullPath("C:..\\..\\Report_Product.rpt");
            crs.Load(path);
            //crs.Load("C:\\Users\\manur\\Documents\\DAM\\DDI\\UD 5\\Dashboard_DI04\\Dashboard_DI04\\Report_Product.rpt");
            crs.SetParameterValue("@FiltroCustomer", lbl_cliente_report.Text);
            crv_productos.ReportSource = crs;
            crv_productos.Refresh();
        }
        private void Reporte_Product_Load(object sender, EventArgs e)
        {
            cargarReporte();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            Formularios form = new Formularios();
            this.Visible = false;
            form.ShowDialog();
            

        }

      
    }
}
