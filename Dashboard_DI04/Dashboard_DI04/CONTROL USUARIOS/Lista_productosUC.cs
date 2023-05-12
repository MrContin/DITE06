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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dashboard_DI04.CONTROL_USUARIOS
{
    public partial class Lista_productosUC : UserControl
    {
        public Lista_productosUC()
        {
            InitializeComponent();
        }
        //Metodo para crear un data grid view 
        public void crear_Lista_Productos(string nombreClienteSeleccionado)
        {
            listView_Produc_cantidad.Items.Clear();

            //Lista para gestionar los datos de los productos comprados por un cliente
            List<string> productos = GESTOR_BLL.Gestor_BD_BLL.InformacionProductosComprados(nombreClienteSeleccionado);

            //Este atributo nos permite agrupar el nombre de los productos para que no se repitan y
            //suma las veces que se repiten, para asi conocer la cantidad de veces que se han obtenido
            var Z = productos.GroupBy(x => x).Select(g => new { Value = g.Key, Count = g.Count() }).OrderByDescending(x => x.Count);


            //Añade los datos al listView
            foreach (var x in Z)
            {
                var item1 = new ListViewItem(new[] { x.Value, x.Count.ToString() });
                listView_Produc_cantidad.Items.Add(item1);
                Console.WriteLine("Value: " + x.Value + " Count: " + x.Count);
            }


        }

        private void listView_Produc_cantidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_report_product_Click(object sender, EventArgs e)
        {
            Reporte_Product rpt = new Reporte_Product();
            rpt.Show();
        }
    }
}
