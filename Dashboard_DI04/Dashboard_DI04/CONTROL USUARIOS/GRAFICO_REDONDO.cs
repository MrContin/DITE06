using Dashboard_DI04.FORMULARIOS;
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

namespace Dashboard_DI04.CONTROL_USUARIOS
{
    public partial class GRAFICO_REDONDO : UserControl
    {
        public GRAFICO_REDONDO()
        {
            InitializeComponent();
        }

        //Metodo para crear un grafico con los datos de un cliente 
        //Se mostrara el año con la facturacion total
        public void crearGrafico(string clienteSeleccionado)
        {
            //ejes x e y 
            List<string> x1 = new List<string>();
            List<int> y1 = new List<int>();
            List<InforCantidadProductoVO> categoria = GESTOR_BLL.Gestor_BD_BLL.Informacion_Categorias(clienteSeleccionado);

            //Añadir la informacion a los ejes x e y 
            for (int i = 0; i < categoria.Count; i++)
            {
                y1.Add(categoria[i].Cantidad);
                x1.Add(categoria[i].Categoria);

            }
            chart_Categorias.Series["Series1"].Points.DataBindXY(x1, y1);

            chart_Categorias.Titles.Clear();
            chart_Categorias.Titles.Add("Categorias más consumidas");
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

    private void GRAFICO_REDONDO_Load(object sender, EventArgs e)
        {
            //Tooltips Mensajes
            ToolTip ttMensaje = new ToolTip();
            ttMensaje.SetToolTip(this.btn_rpt_categorias, "GENERA INFORME DE LAS CATEGORIAS");
        }

        private void btn_rpt_categorias_Click(object sender, EventArgs e)
        {
            Reporte_Categorias rpt = new Reporte_Categorias();
            rpt.Show();
        }
    }
}
