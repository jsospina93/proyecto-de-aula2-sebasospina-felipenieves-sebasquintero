using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using emprendimientor4rivisual.Models;

namespace emprendimientor4rivisual
{
    public partial class ModificarIngresos : System.Web.UI.Page
    {
        public static List<Idea> ideas = AgregarIdea.ideas;
        public bool contEntro = false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGuardarInv_Click(object sender, EventArgs e)
        {
            try
            {
                if ((double.Parse(TxtValInv.Text) < 0 || TxtValInv.Text == ""))
                {
                    throw new FormatException("El campo valor inversión no puede estar vacío y debe ser un valor válido");

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
                        if (idea.Codigo == int.Parse(TxtCodIdea.Text)) ;
                        {
                            contEntro = true;
                            idea.Valorinversion = double.Parse(TxtValInv.Text);
                            LblModificarInv.Text = "El valor de la inversión ha sido modificado con éxito";
                            LimpiarCampos();
                        }
                    }
                    if (contEntro == false)
                    {
                        LblModificarInv.Text = "El código ingresado no se encuentra registrado en el sistema ";
                    }
                }
            }
            catch (FormatException ex)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + ex.Message + "');", true);
            }
        }
        public void LimpiarCampos()
        {
            TxtCodIdea.Text = "";
            TxtValInv.Text = "";
        }

        protected void BtnMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }
    }
}