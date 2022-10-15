using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace emprendimientor4rivisual.Models
{
    public class Departamento
    {
        private string codigo;
        private string nombre;

        public Departamento(string codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}