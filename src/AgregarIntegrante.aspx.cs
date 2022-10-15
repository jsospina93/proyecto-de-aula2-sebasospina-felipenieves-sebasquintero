using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using emprendimientor4rivisual.Models;

namespace emprendimientor4rivisual
{
    public partial class AgregarIntegrante : System.Web.UI.Page
    {
        public static List<Idea> ideas = AgregarIdea.ideas;
        public bool contEntro = false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAgregarInt_Click(object sender, EventArgs e)
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

                else if (TxtApeint.Text == "")
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
                            Integrante integrante = new Integrante(TxtIdInt.Text, TxtNomInt.Text, TxtApeint.Text,
                                TxtRolInt.Text, TxtCorreoInt.Text);
                            idea.Integrantes.Add(integrante);
                            LblAgregarInt.Text="El integrante ha sido agregado con éxito";
                            limpiarCamposInt();
                        }
                    }
                    if (contEntro == false)
                    {
                        LblAgregarInt.Text ="El código ingresado no se encuentra registrado en el sistema ";
                    }
                }
            }
            catch (FormatException ex)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + ex.Message + "');", true);
            }


        }
        protected void Button1_Click(object sender, EventArgs e)
        {
           Response.Redirect("Menu.aspx");
        }
        private void limpiarCamposInt()
        {
                    TxtNomInt.Text = "";
                    TxtApeint.Text = "";
                    TxtIdInt.Text = "";
                    TxtCorreoInt.Text = "";
                    TxtRolInt.Text = "";
        }
    }
}