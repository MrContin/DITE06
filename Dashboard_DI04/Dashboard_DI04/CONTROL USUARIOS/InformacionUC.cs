using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTILIDADES.VO;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Web.UI.WebControls;
using Dashboard_DI04.FORMULARIOS;

namespace Dashboard_DI04.CONTROL_USUARIOS
{
    public partial class InformacionUC : UserControl
    {
        List<InforClienteVO> facturacion = new List<InforClienteVO>();
        public InformacionUC()
        {
            InitializeComponent();
            
        }

        //Creamos un data grid view para mostrar los datos generales del cliente que ha seleccionado
        public void crear_GridView(string nombreClienteSeleccionado)
        {
            DGV_client.ClearSelection();
            //Lista para recoger los datos
            facturacion = GESTOR_BLL.Gestor_BD_BLL.Informacion_Particular_Cliente(nombreClienteSeleccionado);
            DGV_client.DataSource = facturacion;
        }

        private void DGV_client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_generar_reporte_Click(object sender, EventArgs e)
        {

            
            //Formularios f = new Formularios();
            //rpt_viewer.lbl_cliente_report.Text = f.lbl_cliente.Text;// de esta manera paso el dato que contiene en label, Pero antes hay que modificar la propiedad modifer a Public
            this.Hide();
            //control.Show();

        }

        private void InformacionUC_Load(object sender, EventArgs e)
        {
            ToolTip ttMensaje = new ToolTip();

            ttMensaje.SetToolTip(this.btn_generar_reporte, "GENERAR INFORMACION CLIENTE");

        }

        private void DGV_client_DoubleClick(object sender, EventArgs e)
        {
        }
    }
}
