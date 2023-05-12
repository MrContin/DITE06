using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTILIDADES.VO
{
    public class InfoFacturacionFechaVO
    {
        private int fecha_pedido;
        private double precio;

        public InfoFacturacionFechaVO()
        {

        }
        public InfoFacturacionFechaVO(int fecha_pedido, double precio)
        {
            this.fecha_pedido = fecha_pedido;
            this.precio = precio;
        }

        public int Fecha_pedido { get => fecha_pedido; set => fecha_pedido = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}
