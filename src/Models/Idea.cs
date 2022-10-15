using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace emprendimientor4rivisual.Models
{
    public class Idea
    {
        private int codigo;
        private string nombre;
        private string impacto;
        private List<Departamento> departamentos;
        private List<Integrante> integrantes;
        private double valorinversion;
        private double totalingresos;
        private List<String> herramientas;
        private double rentabilidad;

        public Idea(int codigo, string nombre, string impacto,
            List<Departamento> departamentos, List<Integrante> integrantes,
            double valorinversion, double totalingresos, List<String> herramientas, double rentabilidad)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.impacto = impacto;
            this.departamentos = departamentos;
            this.integrantes = integrantes;
            this.valorinversion = valorinversion;
            this.totalingresos = totalingresos;
            this.herramientas = herramientas;
            this.rentabilidad = rentabilidad;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Impacto { get => impacto; set => impacto = value; }
        public double Valorinversion { get => valorinversion; set => valorinversion = value; }
        public double Totalingresos { get => totalingresos; set => totalingresos = value; }
        public double Rentabilidad { get => rentabilidad; set => rentabilidad = value; }
        internal List<Departamento> Departamentos { get => departamentos; set => departamentos = value; }
        internal List<Integrante> Integrantes { get => integrantes; set => integrantes = value; }
        internal List<String> Herramientas { get => herramientas; set => herramientas = value; }
    }
}
