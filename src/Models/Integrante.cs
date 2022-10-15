using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace emprendimientor4rivisual.Models
{
    public class Integrante
    {
        private string id;
        private string nombre;
        private string apellido;
        private string rol;
        private string correo;

        public Integrante(string id, string nombre, string apellido, string rol, string correo)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.rol = rol;
            this.correo = correo;
        }

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Rol { get => rol; set => rol = value; }
        public string Correo { get => correo; set => correo = value; }
    }
}
