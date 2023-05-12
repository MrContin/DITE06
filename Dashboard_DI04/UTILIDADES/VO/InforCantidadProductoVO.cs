using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTILIDADES.VO
{
    public class InforCantidadProductoVO
    {
        private string categoria;
        private int cantidad;

        public InforCantidadProductoVO()
        {

        }
        public InforCantidadProductoVO(string categoria, int cantidad)
        {
            this.categoria = categoria;
            this.cantidad = cantidad;
        }

        public string Categoria { get => categoria; set => categoria = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
