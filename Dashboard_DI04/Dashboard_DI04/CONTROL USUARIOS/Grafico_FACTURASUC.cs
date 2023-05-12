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
    public partial class Grafico_FACTURASUC : UserControl
    {
        public Grafico_FACTURASUC()
        {
            InitializeComponent();
        }

        //Metodo para crear un grafico con los datos de un client
        //Se mostrara el año con la facturacion total del mismo
        public void crear_Grafico_Fact(string clienteSeleccionado)
        {

            //Listas para recoger los datos del eje x e y      
            List<double> y1 = new List<double>();
            List<int> x1 = new List<int>();

            //Recoge el id del cliente del que queremos la infromacion
            string idCliente = GESTOR_BLL.Gestor_BD_BLL.InformacionIdCliente(clienteSeleccionado);

            //Lista que recoge los datos de la facturacion
            List<InfoFacturacionFechaVO> facturacion = GESTOR_BLL.Gestor_BD_BLL.Informacion_Compras_Cliente(idCliente);

            //Bucle for para introducir los datos en x e y
            for (int i = 0; i < facturacion.Count; i++)
            {

                x1.Add(facturacion[i].Fecha_pedido);
                y1.Add(facturacion[i].Precio);

            }

            //Se introducen los datos guardados en chart_Pedidos para que se puedan mostrar en el grafico
            chart_Pedidos.Series["FACTURACION"].Points.DataBindXY(x1.ToArray(), y1.ToArray());

            chart_Pedidos.ChartAreas[0].AxisX.Title = "Fecha Pedido";
            chart_Pedidos.ChartAreas[0].AxisY.Title = "Precio";
            chart_Pedidos.Titles.Clear();
            chart_Pedidos.Titles.Add("Facturación por años");
        }

    }
}
