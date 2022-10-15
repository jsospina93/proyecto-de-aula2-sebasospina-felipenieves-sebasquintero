using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using emprendimientor4rivisual.Models;

namespace emprendimientor4rivisual
{
    public partial class menu : System.Web.UI.Page
    {
        public static List<Idea> ideas = AgregarIdea.ideas;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnIngresarIdea_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarIdea.aspx");
        }

        protected void BtnAgregarIntegrante_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarIntegrante.aspx");
        }

        protected void BtnEliminirIntegrante_Click(object sender, EventArgs e)
        {
            Response.Redirect("EliminarIntegrante.aspx");
        }

        protected void BtnModificarInversion_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificarInversion.aspx");
        }

        protected void BtnModificarIngresos_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificarIngresos.aspx");
        }

        protected void Btnestadisticas_Click(object sender, EventArgs e)
        {
            mayorImpacto(ideas);
            mayorRentabilidad(ideas);
            masDeTresDepartamentos(ideas);
            sumIngresos(ideas);
            sumInversion(ideas);
            mayorCantidadHerramientas(ideas);
            numIntArt(ideas);
            Txtestadisticas.Visible = true;

        }
        public void imprimirIntegrantes(Idea idea)
        {
            Txtestadisticas.Text+= "\nLos integrantes de la idea son: ";
            foreach (Integrante integrante in idea.Integrantes)
            {

                Txtestadisticas.Text += "\n "+integrante.Nombre;
            }

        }
        public void mayorImpacto(List<Idea>ideas)
        {
            var orderDsc = ideas.OrderByDescending(x => x.Totalingresos).ToList();
            double mayorDep = 0;
            int ideaganadora = 0;
            foreach (Idea idea in orderDsc)
            {
                if ((idea.Departamentos.Count()) > mayorDep)
                {
                    mayorDep = idea.Departamentos.Count();
                    ideaganadora = idea.Codigo;
                }
            }
            foreach (Idea idea in orderDsc)
            {
                if (idea.Codigo == ideaganadora)
                {
                    Txtestadisticas.Text += ("\nLa idea que impacta a más departamentos y tiene mayor total de ingresos " +
                        "en los primeros tres años" + " es" + idea.Nombre +
                        " \n con un numero de departamentos impactados de" + idea.Departamentos.Count() +
                        " \n un total de ingresos en los primeros tres años de" + idea.Totalingresos + " \n" +
                    " un valor de inversión de" + idea.Valorinversion + " \n codigo " + idea.Codigo);
                    imprimirIntegrantes(idea);
                }
            }
        }

        public void mayorRentabilidad(List<Idea> ideas)
        {
            if (ideas.Count() > 3)
            {
                var orderDsc = ideas.OrderByDescending(x => x.Rentabilidad).ToList();
                Txtestadisticas.Text += "\n Las 3 ideas con mayor rentabilidad son: ";
                for (int i = 0; i < 3; i++)
                {
                    Txtestadisticas.Text += "\n "+orderDsc[i].Nombre;
                }
            }
            else
            {
                Txtestadisticas.Text += " No se encuentran registradas más de tres ideas";
            }
            
        }

        public void masDeTresDepartamentos(List<Idea> ideas)
        {
            bool bandera=false;
            Txtestadisticas.Text += "\nLas ideas que impactan a más de tres departamentos son: ";
            foreach (Idea idea in ideas)
            {
                if (idea.Departamentos.Count() > 3)
                {
                    Txtestadisticas.Text += idea.Nombre+ " ";
                    bandera = true;
                }
            }
        }

        public void sumIngresos(List<Idea> ideas)
        {
            Txtestadisticas.Text += "\nLa suma total de los ingresos de todas las ideas de negocio es: ";
            double acumIngresos = 0;
            foreach (Idea idea in ideas)
            {
                acumIngresos += idea.Totalingresos;
            }
            Txtestadisticas.Text += acumIngresos;
        }

        public void sumInversion(List<Idea> ideas)
        {
            Txtestadisticas.Text += ("\nLa suma total de las inversiones de todas las ideas de negocio es: ");
            double acumInversiones = 0;
            foreach (Idea idea in ideas)
            {
                acumInversiones += idea.Valorinversion;
            }
            Txtestadisticas.Text += acumInversiones;

        }
        public void mayorCantidadHerramientas(List<Idea> ideas)
        {
            var orderDsc = ideas.OrderByDescending(x => x.Herramientas.Count());
            var primero = orderDsc.First();
            Txtestadisticas.Text += "\nEl nombre de la idea de negocio que tiene mayor cantidad de herramientas 4RI es: " + primero.Nombre;
            imprimirIntegrantes(primero);
        }

        public void numIntArt(List<Idea> ideas)
        {
            string buscado = "inteligencia artificial";
            int contIA = 0;
            foreach (Idea idea in ideas)
            {
                for (int i = 0; i < idea.Herramientas.Count; i++)
                {
                    if (idea.Herramientas[i] == buscado)
                    {
                        contIA+=1;
                    }
                }
            }
            Txtestadisticas.Text += "\nEl total de ideas que tienen Inteligencia Artificial son: " + contIA;
        }
    }
}
