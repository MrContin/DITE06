using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTILIDADES.VO;

namespace GESTOR_DAL
{
    public class Gestor_Dal
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AbrirConexion();
        }
        //Metodo para comprobar la conexion a la BBDD
        public static void AbrirConexion()
        {
            SqlConnection conn = new SqlConnection(@"Data Source = localhost; Initial Catalog = Northwind; User ID= DI; Password = 1234");
            try
            {
                conn.Open();
                Console.WriteLine("Conexion abierta satisfactoriamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido establecer conexion");

                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }
        }
        //Metodo para recuperar la información de todos los clientes y guarda los datos en una lista InforClienteVO
        public static List<InforClienteVO> Realizar_Consulta_Clientes()
        {
            //conexion
            SqlConnection conn = new SqlConnection(@"Data Source = localhost; Initial Catalog = Northwind; User ID= DI; Password = 1234");
            SqlCommand command;

            string sql = "Select * from dbo.Customers";

            SqlDataReader datos;
            List<InforClienteVO> clientes = new List<InforClienteVO>();
            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                datos = command.ExecuteReader();


                //Recogida de los datos
                while (datos.Read())
                {
                    InforClienteVO cliente = new InforClienteVO();
                    cliente.Id_Cliente = datos.GetValue(0).ToString();
                    cliente.Nombre_Empresa = datos.GetValue(1).ToString();
                    cliente.NombreContacto = datos.GetValue(2).ToString();
                    cliente.Categoria_Contacto = datos.GetValue(3).ToString();
                    cliente.Dir = datos.GetValue(4).ToString();
                    cliente.Ciudad = datos.GetValue(5).ToString();
                    cliente.Region = datos.GetValue(6).ToString();
                    cliente.Codigo_Postal= datos.GetValue(7).ToString();
                    cliente.Pais = datos.GetValue(8).ToString();
                    cliente.Telefono = datos.GetValue(9).ToString();
                    cliente.Fax = datos.GetValue(10).ToString();
                    clientes.Add(cliente);
                    Console.WriteLine(datos.GetValue(0));
                }

                datos.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido establecer conexion");
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("Conexion cerrada");
            }
            //Se devuelve la lista con los datos
            return clientes;
        }

        //Metodo para recuperar la información de todas las ventas realizadas y guardar los datos en una lista InforVentasVO
        public static List<InforVentasVO> Realizar_Consulta_Ventas()
        {
            //conexion
            SqlConnection conn = new SqlConnection(@"Data Source = localhost; Initial Catalog = Northwind; User ID= DI; Password = 1234");
            SqlCommand command;

            string sql = "Select * from dbo.Orders";

            SqlDataReader datos;
            List<InforVentasVO> ventas = new List<InforVentasVO>();
            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                datos = command.ExecuteReader();

                //Recogida de los datos
                while (datos.Read())
                {
                    InforVentasVO venta = new InforVentasVO();
                    venta.Pedido_id = datos.GetValue(0).ToString();
                    venta.Cliente_id = datos.GetValue(1).ToString();
                    venta.Empleado_id = datos.GetValue(2).ToString();
                    venta.Fecha_Pedido = DateTime.Parse(datos.GetValue(3).ToString());
                    venta.Fecha_Entrega = DateTime.Parse(datos.GetValue(4).ToString());
                    venta.Fecha_Envio = DateTime.Parse(datos.GetValue(5).ToString());
                    venta.Entrega_Transporte = (int)Int64.Parse(datos.GetValue(6).ToString());
                    venta.Precio = (double)Double.Parse(datos.GetValue(7).ToString());
                    venta.NombreCliente = datos.GetValue(8).ToString();
                    venta.Dir = datos.GetValue(9).ToString();
                    venta.Ciudad = datos.GetValue(10).ToString();
                    venta.Region = datos.GetValue(11).ToString();
                    venta.Codigo_Postal = datos.GetValue(12).ToString();
                    venta.Pais = datos.GetValue(13).ToString();
                    ventas.Add(venta);
                    Console.WriteLine(datos.GetValue(0));
                }

                datos.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido establecer conexion");
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("Conexion cerrada");
            }
            //Se devuelve la lista con los datos
            return ventas;
        }

        public static List<String> Realizar_Consulta_Productos_Comprados(string nombreCliente)
        {
            //conexion
            SqlConnection conn = new SqlConnection(@"Data Source = localhost; Initial Catalog = Northwind; User ID= DI; Password = 1234");
            SqlCommand command;
            string nombre = ConsultaId(nombreCliente);

            //consulta sql para obtener el nombre de los productos comprados
            string sql = "Select productName from dbo.products " +
                "inner join dbo.[order Details] on dbo.products.productID = dbo.[Order Details].productID " +
                "inner join dbo.orders on dbo.[Order Details].orderId = dbo.orders.orderId " +
                "where dbo.orders.customerId = '" + nombre + "'";

            SqlDataReader datos;
            List<String> productos = new List<String>();
            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                datos = command.ExecuteReader();


                //Recogida de datos
                while (datos.Read())
                {
                    string nombreProducto = datos.GetValue(0).ToString();
                    productos.Add(nombreProducto);
                    Console.WriteLine(datos.GetValue(0));
                }

                datos.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido establecer conexion");
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("Conexion cerrada");
            }
            //Devuelve una lista con los datos recogidos
            return productos;
        }

        //Metodo para recuperar el id de un cliente guardar el dato en un string
        public static string ConsultaId(string nombreCliente)
        {
            // conexion
            SqlConnection conn = new SqlConnection(@"Data Source = localhost; Initial Catalog = Northwind; User ID= DI; Password = 1234");
            SqlCommand command;
            //remplaza nombres que contienen ' para que no den error al buscarlos
            nombreCliente = nombreCliente.Replace("'", "''");

            string sql = "Select CustomerID from dbo.Customers where CompanyName = '" + nombreCliente + "'";

            SqlDataReader datos;
            string idCliente = "";
            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                datos = command.ExecuteReader();

                while (datos.Read())
                {
                    idCliente = datos.GetValue(0).ToString();
                }              

                datos.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido establecer conexion");
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("Conexion cerrada");
            }
            //Devuelve string con el id
            return idCliente;
        }

        //Metodo para recuperar el id de un cliente y guardar el dato en un string
        public static string Realizar_Consulta_Id(string nombreCliente)
        {
            //conexion
            SqlConnection conn = new SqlConnection(@"Data Source = localhost; Initial Catalog = Northwind; User ID= DI; Password = 1234");
            SqlCommand command;
            //Remplaza los nombres que contienen ' para que no den error al buscarlos
            nombreCliente = nombreCliente.Replace("'", "''");

            string sql = "Select CustomerID from dbo.Customers where CompanyName = '" + nombreCliente + "'";

            SqlDataReader datos;
            string idCliente = "";
            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                datos = command.ExecuteReader();

                while (datos.Read())
                {
                    idCliente = datos.GetValue(0).ToString();
                }              

                datos.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido establecer conexion");
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("Conexion cerrada");
            }
            //Devuelve string con el id
            return idCliente;
        }

        public static List<InforCantidadProductoVO> Realizar_Consulta_Categoria_Productos(string nombreCliente)
        {
            //conexion
            SqlConnection conn = new SqlConnection(@"Data Source = localhost; Initial Catalog = Northwind; User ID= DI; Password = 1234");
            SqlCommand command;
            string nombre = Realizar_Consulta_Id(nombreCliente);

            //consulta sql que nos permite obtener el nombre de los productos comprados
            string sql = "SELECT categoryName, COUNT(categoryName) FROM dbo.categories " +
                         "inner join dbo.products on dbo.products.categoryID = dbo.categories.categoryID " +
                         "inner join dbo.[order Details] on northwind.dbo.products.productID = northwind.dbo.[Order Details].productID " +
                         "inner join dbo.orders on dbo.[Order Details].orderId = dbo.orders.orderId " +
                         "where dbo.orders.CustomerID = '" + nombre + "' " +
                         "GROUP BY categoryName";


            SqlDataReader datos;
            List<InforCantidadProductoVO> categorias = new List<InforCantidadProductoVO>();
            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                datos = command.ExecuteReader();


                //Recogida de datos
                while (datos.Read())
                {
                    InforCantidadProductoVO categoria = new InforCantidadProductoVO();
                    categoria.Categoria = datos.GetValue(0).ToString();
                    categoria.Cantidad = (int)Int64.Parse(datos.GetValue(1).ToString());
                    categorias.Add(categoria);
                    Console.WriteLine(datos.GetValue(0));
                }

                datos.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido establecer conexion");
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("Conexion cerrada");
            }
            //Devuelve una lista con los datos almacenados
            return categorias;
        }

        //Método que permite recuperar la información de un cliente. Guarda los datos en una lista InfoClienteVO
        public static List<InforClienteVO> Realizar_Consulta_Informacion_Cliente(string nombreCliente)
        {
            //conexion
            SqlConnection conn = new SqlConnection(@"Data Source = localhost; Initial Catalog = Northwind; User ID= DI; Password = 1234");
            SqlCommand command;
            //Remplaza los nombres que contienen ' para que no den error al buscarlos
            nombreCliente = nombreCliente.Replace("'", "''");
            string sql = "Select * from dbo.Customers where CompanyName = '" + nombreCliente + "'";

            SqlDataReader datos;
            List<InforClienteVO> clientes = new List<InforClienteVO>();
            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                datos = command.ExecuteReader();


                //Recogida de datos
                while (datos.Read())
                {
                    InforClienteVO cliente = new InforClienteVO();
                    cliente.Id_Cliente = datos.GetValue(0).ToString();
                    cliente.Nombre_Empresa = datos.GetValue(1).ToString();
                    cliente.NombreContacto = datos.GetValue(2).ToString();
                    cliente.Categoria_Contacto = datos.GetValue(3).ToString();
                    cliente.Dir = datos.GetValue(4).ToString();
                    cliente.Ciudad = datos.GetValue(5).ToString();
                    cliente.Region = datos.GetValue(6).ToString();
                    cliente.Codigo_Postal = datos.GetValue(7).ToString();
                    cliente.Pais = datos.GetValue(8).ToString();
                    cliente.Telefono = datos.GetValue(9).ToString();
                    cliente.Fax = datos.GetValue(10).ToString();
                    clientes.Add(cliente);
                    Console.WriteLine(datos.GetValue(0));
                }

                datos.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido establecer conexion");
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("Conexion cerrada");
            }
            //Devuelve la lista con los datos recogidos
            return clientes;
        }

        //Metodo para obtener la informacion de las ventas realizadas por un cliente y guardar los datos en una lista 
        public static List<InfoFacturacionFechaVO> Realizar_Consulta_Ventas_Cliente(string idCliente)
        {
            //conexion
            SqlConnection conn = new SqlConnection(@"Data Source = localhost; Initial Catalog = Northwind; User ID= DI; Password = 1234");
            SqlCommand command;

            //Consulta sql que nos permite concatenar las fechas en un año concreto y asi poder sumar su facturacion total
            string sql = "Select Year(OrderDate), sum(freight) from dbo.orders " +
                "where CustomerID = '" + idCliente + "' " +
                "group by Year(OrderDate)";

            SqlDataReader datos;
            List<InfoFacturacionFechaVO> ventas = new List<InfoFacturacionFechaVO>();

            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                datos = command.ExecuteReader();

                //Recogida de datos
                while (datos.Read())
                {
                    InfoFacturacionFechaVO venta = new InfoFacturacionFechaVO();
                    venta.Fecha_pedido = (int)int.Parse(datos.GetValue(0).ToString());
                    venta.Precio = (double)Double.Parse(datos.GetValue(1).ToString());
                    ventas.Add(venta);
                    Console.WriteLine(datos.GetValue(0));
                }

                datos.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido establecer conexion");
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("Conexion cerrada");
            }
            //Devuelve la lista con los datos recogidos
            return ventas;
        }

    }
    
}

