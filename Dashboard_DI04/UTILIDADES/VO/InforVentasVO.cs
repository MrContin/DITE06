using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTILIDADES.VO
{
    public class InforVentasVO
    {
        #region Atributos
        private string pedido_id;
        private string cliente_id;
        private string empleado_id;
        private DateTime fecha_Pedido;
        private DateTime fecha_Entrega;
        private DateTime fecha_Envio;
        private int entrega_Transporte;
        private double precio;
        private string nombreCliente;
        private string dir;
        private string ciudad;
        private string region;
        private string codigo_Postal;
        private string pais;
        #endregion Atributos
        public InforVentasVO()
        {

        }
        public InforVentasVO(string pedido_id, string cliente_id, string empleado_id, DateTime fecha_Pedido, DateTime fecha_Entrega, DateTime fecha_Envio, int entrega_Transporte, double precio, string nombreCliente, string dir, string ciudad, string region, string codigo_Postal, string pais)
        {
            this.pedido_id = pedido_id;
            this.cliente_id = cliente_id;
            this.empleado_id = empleado_id;
            this.fecha_Pedido = fecha_Pedido;
            this.fecha_Entrega = fecha_Entrega;
            this.fecha_Envio = fecha_Envio;
            this.entrega_Transporte = entrega_Transporte;
            this.precio = precio;
            this.nombreCliente = nombreCliente;
            this.dir = dir;
            this.ciudad = ciudad;
            this.region = region;
            this.codigo_Postal = codigo_Postal;
            this.pais = pais;
        }

        public string Pedido_id { get => pedido_id; set => pedido_id = value; }
        public string Cliente_id { get => cliente_id; set => cliente_id = value; }
        public string Empleado_id { get => empleado_id; set => empleado_id = value; }
        public DateTime Fecha_Pedido { get => fecha_Pedido; set => fecha_Pedido = value; }
        public DateTime Fecha_Entrega { get => fecha_Entrega; set => fecha_Entrega = value; }
        public DateTime Fecha_Envio { get => fecha_Envio; set => fecha_Envio = value; }
        public int Entrega_Transporte { get => entrega_Transporte; set => entrega_Transporte = value; }
        public double Precio { get => precio; set => precio = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string Dir { get => dir; set => dir = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Region { get => region; set => region = value; }
        public string Codigo_Postal { get => codigo_Postal; set => codigo_Postal = value; }
        public string Pais { get => pais; set => pais = value; }

    }
}

