using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using emprendimientor4rivisual.Models;

namespace emprendimientor4rivisual
{
    public partial class AgregarIdea : System.Web.UI.Page
    {
        
        public static List<Idea> ideas = new List<Idea>();
        public static List<Departamento> departamentos = new List<Departamento>();
        public static List<Integrante> integrantes = new List<Integrante>();
        public static List<String> herramientas = new List<String>();
        public int codigo;
        public double rentabilidad;


        public List<Integrante> LimpiarReferenciaInt()
        {
            List<Integrante> Auxiliar = integrantes;
            integrantes = new List<Integrante>();

            return Auxiliar;
        }
        public List<Departamento> LimpiarReferenciaDep()
        {
            List<Departamento> Auxiliar = departamentos;
            departamentos = new List<Departamento>();

            return Auxiliar;
        }
        public List<String> LimpiarReferenciaHer()
        {
            List<String> Auxiliar = herramientas;
            herramientas = new List<String>();

            return Auxiliar;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void BtnAgregarDep_Click(object sender, EventArgs e) //agrego departamentos
        {
            try
            {
                if (TxtNomDep.Text == "")
                {
                    throw new FormatException("El campo Nombre departamento no puede estar vacío");

                }

                else if (TxtCodDep.Text == "")
                {
                    throw new FormatException("El campo código departamento no puede estar vacío");
                }
                else
                {
                    CrearDepartamento(TxtCodDep.Text, TxtNomDep.Text);
                }
            }
            catch (FormatException ex)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + ex.Message + "');", true);
            }
        }


        protected void BtnAgregarInt_Click(object sender, EventArgs e) //Agregar integrantes
        {
            try
            {
                if (TxtNomInt.Text == "")
                {
                    throw new FormatException("El campo Nombre no puede estar vacío");

                }

                else if (TxtIdInt.Text == "")
                {
                    throw new FormatException("El campo Id no puede estar vacío");
                }

                else if (TxtApeInt.Text == "")
                {
                    throw new FormatException("El campo Apellido no puede estar vacío");
                }

                else if (TxtRolInt.Text == "")
                {
                    throw new FormatException("El campo Rol no puede estar vacío");
                }

                else if (TxtCorreoInt.Text == "")
                {
                    throw new FormatException("El campo Correo no puede estar vacío");
                }

                else
                {
                    CrearIntegrante(TxtIdInt.Text, TxtNomInt.Text,
                        TxtApeInt.Text, TxtRolInt.Text, TxtCorreoInt.Text);
                    

                }
            }
            catch (FormatException ex)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + ex.Message + "');", true);
            }


        }

        protected void BtnHerramienta_Click(object sender, EventArgs e) //Agregar herramientas
        {
            try
            {
                if (TxtHerramienta.Text == "")
                {
                    throw new FormatException("El campo Herramienta no puede estar vacío");
                }

                else
                {
                    herramientas.Add(TxtHerramienta.Text.ToLower());
                    LblHerramienta.Text = "La herramienta ha sido agregada con éxito";
                    limpiarCamposHerramienta();
                }
            }
            catch (FormatException ex)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + ex.Message + "');", true);
            }

        }

        protected void Button4_Click(object sender, EventArgs e) //Crear y agregar idea
        {
            try
            {
                if (TxtNombreIdea.Text == "")
                {
                    throw new FormatException("El campo Nombre idea no puede estar vacío");

                }

                else if (Txtimpacto.Text == "")
                {
                    throw new FormatException("El campo Impacto no puede estar vacío");
                }


                else if ((double.Parse(TxtValInv.Text) < 0 || TxtValInv.Text == ""))
                {
                    throw new FormatException("Ingrese una inversion válida");
                }

                else if ((double.Parse(TxtTotalIngresos.Text) < 0 || TxtTotalIngresos.Text == ""))
                {
                    throw new FormatException("Ingrese un total de ingresos válidos");
                }
                else
                {
                    codigo = (ideas.Count()) + 1;

                    rentabilidad = (double.Parse(TxtTotalIngresos.Text) / double.Parse(TxtValInv.Text)) * 100;
                    CrearIdea(codigo, TxtNombreIdea.Text, Txtimpacto.Text, LimpiarReferenciaDep(),
                        LimpiarReferenciaInt(), double.Parse(TxtValInv.Text), double.Parse(TxtTotalIngresos.Text),
                        LimpiarReferenciaHer(), rentabilidad);

                }

            }
            catch (FormatException ex)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + ex.Message + "');", true);
            }
        }

        protected void BtnMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        private void limpiarCamposInt()
        {
            TxtNomInt.Text = "";
            TxtApeInt.Text = "";
            TxtIdInt.Text = "";
            TxtCorreoInt.Text = "";
            TxtRolInt.Text = "";
        }
        private void limpiarCamposDep()
        {
            TxtNomDep.Text = "";
            TxtCodDep.Text = "";
        }
        private void limpiarCamposIdea()
        {
            TxtNombreIdea.Text = "";
            Txtimpacto.Text = "";
            TxtValInv.Text = "";
            TxtTotalIngresos.Text = "";
            LblAgregarDep.Text = "";
            LblAgregarInt.Text = "";
            LblHerramienta.Text = "";
        }
        private void limpiarCamposHerramienta()
        {
            TxtHerramienta.Text = "";
        }
        private void CrearIdea(int codigo, string nombre, string impacto, List<Departamento> departamentos, List<Integrante>
            integrantes, double valorinversion, double totalingresos, List<String> herramientas, double rentabilidad)
        {
            Idea idea = new Idea(codigo, nombre, impacto, departamentos, integrantes, valorinversion, 
                totalingresos, herramientas, rentabilidad);

            ideas.Add(idea);
            LblAgregarIdea.Text = ("La idea ha sido agregada con éxito su código es: " + codigo);
            limpiarCamposIdea();
        }
        private void CrearIntegrante(string id, string nombre, string apellido, string rol, string correo)
        {
            Integrante integrante = new Integrante(id, nombre, apellido, rol, correo);
            integrantes.Add(integrante);
            LblAgregarInt.Text = "El integrante ha sido agregado con éxito";
            limpiarCamposInt();
        }
        private void CrearDepartamento(string codigo, string nombre)
        {
            Departamento departamento = new Departamento(codigo, nombre);
            departamentos.Add(departamento);
            LblAgregarDep.Text = "El departamento ha sido agregado con éxito";
            limpiarCamposDep();
        }
    }
}