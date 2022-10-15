using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using emprendimientor4rivisual.Models;

namespace emprendimientor4rivisual
{
    public partial class AgregarParticipante : System.Web.UI.Page
    {
        public static List<Idea> ideas = AgregarIdea.ideas;
        public bool contEntro = false, contEntro2 = false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEliminarInt_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtIdInt.Text == "")
                {
                    throw new FormatException("El campo Id no puede estar vacio");
                }


                else if ((int.Parse(TxtCodIdea.Text) < 0 || TxtCodIdea.Text == ""))
                {
                    throw new FormatException("El campo Código idea no puede estar vacío y debe ser" +
                        "un número entero ");
                }

                else
                {
                    foreach (Idea idea in ideas)
                    {
                        if (idea.Codigo == int.Parse(TxtCodIdea.Text))
                        {
                            contEntro = true;
                            foreach (Integrante inte in idea.Integrantes)
                            {
                                if (inte.Id == TxtIdInt.Text)
                                {
                                    contEntro2 = true;
                                    idea.Integrantes.Remove(inte);
                                    LblEliminarInt.Text = "El integrante ha sido eliminado con éxito";
                                    LimpiarCampos();
                                    break;
                                }
                            }
                            if (contEntro2 == false)
                            {
                                LblEliminarInt.Text="El id ingresado no se encuentra registrado como integrante de la idea ";
                            }
                        }
                    }
                    if (contEntro == false)
                    {
                        LblEliminarInt.Text = "El código ingresado no se encuentra registrado en el sistema ";
                    }
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

        public void LimpiarCampos()
        {
            TxtCodIdea.Text = "";
            TxtIdInt.Text = "";
        }
    }
}