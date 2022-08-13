using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Usuario
    {
        // Propiedades
        public string usuario  { get; set; }
        public string clave { get; set; }
        public string nombre { get; set; }

        public Usuario() { }

        public Usuario(string usuario, string clave, string nombre)
        {
            this.usuario = usuario;
            this.clave = clave;
            this.nombre = nombre;
        }

        public Usuario(string usuario, string clave)
        {
            this.usuario = usuario;
            this.clave = clave;
        }
    }
}
