using Dashboard_DI04.CONTROL_USUARIOS;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

namespace Dashboard_DI04.FORMULARIOS
{
    public partial class Formularios : Form
    {
        private Lista_productosUC productos;
        private GRAFICO_REDONDO categoria;
        private TableLayoutPanel tlpt;
        private Grafico_FACTURASUC graficoFact;
        private InformacionUC informacion;
        public string clientefiltro;
        public Formularios()
        {
            InitializeComponent();
            InicioComboBox();
            desactivarCheck();
            tlpt = tlp_mostrar_infor;
            productos = new Lista_productosUC();
            categoria= new GRAFICO_REDONDO();
            informacion = new InformacionUC();
            graficoFact = new Grafico_FACTURASUC();
            btn_generar.Enabled = false;

            //Tooltips Mensajes
            ToolTip ttMensaje = new ToolTip();

            ttMensaje.SetToolTip(this.tlp_mostrar_infor, "DIFERENTE INFORMACION DE LOS CLIENTES");
            ttMensaje.SetToolTip(this.cmb_Cliente, "TODOS LOS CLIENTES DISPONIBLES");
            ttMensaje.SetToolTip(this.cmb_Pais, "PAISES DE LOS CLIENTES");
            ttMensaje.SetToolTip(this.checkBox_Categorias, "CATEGORIAS DEL CLIENTE");
            ttMensaje.SetToolTip(this.checkBox_Productos, "INFORME PRODUCTOS DEL CLIENTE");
            ttMensaje.SetToolTip(this.checkBox_Informacion, "INFORME DEL CLIENTE");
            ttMensaje.SetToolTip(this.checkBox_Facturas, "GRAFICO FACTURAS CLIENTE");
            ttMensaje.SetToolTip(this.btn_generar, "GENERAR EL INFORME DE PRODUCTOS");


        }
        //En el inicio del proyecto los checkbox junto con los tabletlayout en los que estan situados apareceran desabilitados 
        private void desactivarCheck()
        {
            checkBox_Categorias.Checked = false;    
            checkBox_Facturas.Checked = false;
            checkBox_Informacion.Checked = false;
            checkBox_Productos.Checked = false;
            tlp_cate_prod.Enabled = false;
            tlp_info_fac.Enabled = false;
            lbl_id_cliente.Enabled = false;
        }
        //Carga de los comboBox, estos primero deben de cargarse con los clientes y paises de la BD
        private void InicioComboBox()
        {
            List<InforClienteVO> clientes = GESTOR_BLL.Gestor_BD_BLL.Informacion_Cliente();
            List<string> paises = new List<string>();
            foreach (InforClienteVO cliente in clientes)
            {
                cmb_Cliente.Items.Add(cliente.Nombre_Empresa);
                paises.Add(cliente.Pais);
                
            }
            List<string> paises_Sin_Repetirse = paises.Distinct().ToList();
            cmb_Pais.Items.Add("Todos");
            foreach (string pais in paises_Sin_Repetirse)
            {
                cmb_Pais.Items.Add(pais);
            }
        }

        private void Formularios_Load(object sender, EventArgs e)
        {

        }

        private void cmb_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            desactivarCheck();
            activarCheck();
            tlp_mostrar_infor.Controls.Clear();
        }

        private void activarCheck()
        {
            tlp_mostrar_infor.Enabled = true;
            tlp_cate_prod.Enabled = true;
            tlp_info_fac.Enabled = true;
            lbl_id_cliente.Enabled = true;
            
        }

        private void checkBox_Categorias_CheckedChanged(object sender, EventArgs e)
        {
            tlp_mostrar_infor.Controls.Clear();
            clientefiltro = cmb_Cliente.SelectedItem.ToString();
            string clienteSeleccionado = cmb_Cliente.SelectedItem.ToString();
            categoria.crearGrafico(clienteSeleccionado);
            tlp_mostrar_infor.Controls.Add(categoria, 1, 0);
            lbl_Titulo.Text = "AREA DE CATEGORIAS";
            lbl_cliente.Text = nombreCliente().ToString();

        }

        private void checkBox_Productos_CheckedChanged(object sender, EventArgs e)
        {
            tlp_mostrar_infor.Controls.Clear();
            clientefiltro = cmb_Cliente.SelectedItem.ToString();
            string clienteSeleccionado = cmb_Cliente.SelectedItem.ToString();
            productos.crear_Lista_Productos(clienteSeleccionado);
            tlp_mostrar_infor.Controls.Add(productos, 1, 0);
            lbl_Titulo.Text = "AREA DE PRODUCTOS MÁS CONSUMIDOS";
            
            lbl_cliente.Text = nombreCliente().ToString();
            btn_generar.Enabled = true;


            
        }

        private void checkBox_Informacion_CheckedChanged(object sender, EventArgs e)
        {
            tlp_mostrar_infor.Controls.Clear();
            clientefiltro = cmb_Cliente.SelectedItem.ToString();
            string clienteSeleccionado = cmb_Cliente.SelectedItem.ToString();
            informacion.crear_GridView(clienteSeleccionado);
            tlp_mostrar_infor.Controls.Add(informacion, 1, 0);

            lbl_Titulo.Text = "AREA DE INFORMACIÓN CLIENTE";
            lbl_cliente.Text = nombreCliente().ToString();

            Reporte_infoCliente_viewer rpt = new Reporte_infoCliente_viewer();

            rpt.lbl_cliente_report.Text = lbl_cliente.Text;// de esta manera paso el dato que contiene en label, Pero antes hay que modificar la propiedad modifer a Public

            this.Hide();
            rpt.ShowDialog();
        }

        private void checkBox_Facturas_CheckedChanged(object sender, EventArgs e)
        {
            tlp_mostrar_infor.Controls.Clear();
            string clienteSeleccionado = cmb_Cliente.SelectedItem.ToString();
            graficoFact.crear_Grafico_Fact(clienteSeleccionado);
            tlp_mostrar_infor.Controls.Add(graficoFact, 1, 0);
            lbl_Titulo.Text = "AREA DE FACTURACIÓN ANUAL";
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            Reporte_Product rpt = new Reporte_Product();
            rpt.lbl_cliente_report.Text = lbl_cliente.Text;// de esta manera paso el dato que contiene en label, Pero antes hay que modificar la propiedad modifer a Public
            this.Hide();
            rpt.ShowDialog();
        }
        public string nombreCliente( )
        {
            String nombre = GESTOR_BLL.Gestor_BD_BLL.InformacionIdCliente(clientefiltro);
            return nombre;
        }

        //Metodo que permite filtrar lo que aparece en el cmb_Cliente
        //por la selección del país que hagamos en el cmb_Pais
        private void cmb_Pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            desactivarCheck();
            string pais = cmb_Pais.SelectedItem.ToString();
            cmb_Cliente.Items.Clear();
            List<InforClienteVO> clientes = GESTOR_BLL.Gestor_BD_BLL.Informacion_Cliente();
            foreach (InforClienteVO cliente in clientes)
            {
                if (cliente.Pais == pais)
                {
                    cmb_Cliente.Items.Add(cliente.Nombre_Empresa);
                }
                else if (pais == "Todos")
                {
                    cmb_Cliente.Items.Add(cliente.Nombre_Empresa);
                }
            }
        }

        private void lbl_id_cliente_Click(object sender, EventArgs e)
        {

        }

        private void aYUDAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manualUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:\\Users\\manur\\Documents\\DAM\\DDI\\UD 6\\Dashboard_DI04\\Dashboard_DI04\\Resources\\Manual_Dashboard.chm");// dos parametros, uno que sera el formulario y otro el fichero chm que hemos creado
        }
    }
}
