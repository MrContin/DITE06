using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTILIDADES.VO
{
    public class InforClienteVO
    {
        private string id_Cliente;
        private string nombre_Empresa;
        private string nombreContacto;
        private string categoria_Contacto;
        private string dir;
        private string ciudad;
        private string region;
        private string codigo_Postal;
        private string pais;
        private string telefono;
        private string fax;

        public InforClienteVO()
        {
            
        }
        public InforClienteVO(string id_Cliente, string nombre_Empresa, string nombreContacto, string categoria_Contacto, string dir, string ciudad, string region, string codigo_Postal, string pais, string telefono, string fax)
        {
            this.id_Cliente = id_Cliente;
            this.nombre_Empresa = nombre_Empresa;
            this.nombreContacto = nombreContacto;
            this.categoria_Contacto = categoria_Contacto;
            this.dir = dir;
            this.ciudad = ciudad;
            this.region = region;
            this.codigo_Postal = codigo_Postal;
            this.pais = pais;
            this.telefono = telefono;
            this.fax = fax;
        }

        public string Id_Cliente { get => id_Cliente; set => id_Cliente = value; }
        public string Nombre_Empresa { get => nombre_Empresa; set => nombre_Empresa = value; }
        public string NombreContacto { get => nombreContacto; set => nombreContacto = value; }
        public string Categoria_Contacto { get => categoria_Contacto; set => categoria_Contacto = value; }
        public string Dir { get => dir; set => dir = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Region { get => region; set => region = value; }
        public string Codigo_Postal { get => codigo_Postal; set => codigo_Postal = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Fax { get => fax; set => fax = value; }
    }
}
