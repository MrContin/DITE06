using GESTOR_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTILIDADES.VO;

namespace GESTOR_BLL
{
    public class Gestor_BD_BLL
    {
        /// <summary>
        /// </summary>
        //[STAThread]
        static void Main()
        {
        }

        //Metodo para sacar la informacion de todos los clientes
        //Devuelve una lista de InfoClienteVO
        public static List<InforClienteVO> Informacion_Cliente()
            {
                List<InforClienteVO> info_Clientes = GESTOR_DAL.Gestor_Dal.Realizar_Consulta_Clientes();
                return info_Clientes;

            }
            public static List<string> Informacion_Productos_Comprados(string nombre_Cliente)
            {
                List<string> info_Productos = GESTOR_DAL.Gestor_Dal.Realizar_Consulta_Productos_Comprados(nombre_Cliente);
                return info_Productos;

            }


        //Metodo para obtener el id de un cliente
        //Devuelve un string con el id
        public static string InformacionIdCliente(string nombre_Cliente)
        {
            string idCliente = Gestor_Dal.Realizar_Consulta_Id(nombre_Cliente);
            return idCliente;

        }

        public static List<InforCantidadProductoVO> Informacion_Categorias(string nombre_Cliente)
        {
            List<InforCantidadProductoVO> info_Categorias = GESTOR_DAL.Gestor_Dal.Realizar_Consulta_Categoria_Productos(nombre_Cliente);
            return info_Categorias;

        }

        //Metodo para obtener la informacion general de los productos comprador por un cliente
        //Devuelve una lista de string
        public static List<string> InformacionProductosComprados(string nombre_Cliente)
        {
            List<string> info_Productos = Gestor_Dal.Realizar_Consulta_Productos_Comprados(nombre_Cliente);
            return info_Productos;

        }

        //Metodo para obtener la informacion general de un cliente
        //Devuelve una lista de InfoCliente.
        public static List<InforClienteVO> Informacion_Particular_Cliente(string nombre_Cliente)
        {
            List<InforClienteVO> info_Cliente = GESTOR_DAL.Gestor_Dal.Realizar_Consulta_Informacion_Cliente(nombre_Cliente);
            return info_Cliente;

        }

        //Metodo para obtener la informacion general de la facturacion de un cliente a lo largo de los años
        //Devuelve una lista
        public static List<InfoFacturacionFechaVO> Informacion_Compras_Cliente(string id_Cliente)
        {
            List<InfoFacturacionFechaVO> infoVentasCliente = GESTOR_DAL.Gestor_Dal.Realizar_Consulta_Ventas_Cliente(id_Cliente);
            return infoVentasCliente;

        }
    }
}
