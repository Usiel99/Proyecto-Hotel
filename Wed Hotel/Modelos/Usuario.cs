using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Usuario
    {
        public string CodigoUsuario { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string Correo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Rol{ get; set; }
        public byte []? Foto { get; set; }
        public string EstasActivo{ get; set; }


        public Usuario() { }

        public Usuario(string codigoUsuario, string nombre, string contrasena, string correo, DateTime fechacreacion, string rol, byte[]? foto, string estasactivo)
        {
            CodigoUsuario = codigoUsuario;
            Nombre= nombre;
            Contrasena = contrasena;
            Correo=correo;
            FechaCreacion = fechacreacion;
            Rol= rol;
            Foto= foto;
            EstasActivo = estasactivo;
        }


    }

}
