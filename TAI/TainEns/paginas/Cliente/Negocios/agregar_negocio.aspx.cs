using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Entidades;
using Negocios;

namespace TainEns.paginas.Cliente.Negocios
{
    public partial class agregar_negocio : System.Web.UI.Page
    {
        E_Negocios ObjEN = new E_Negocios();
        N_Negocio ObjNN = new N_Negocio();
        E_UsuarioNegocios ObjEUN = new E_UsuarioNegocios();
        N_UsuarioNegocios ObjNUN = new N_UsuarioNegocios();
        E_HorarioNegocios ObjEHN = new E_HorarioNegocios();
        N_HorarioNegocios ObjNHN = new N_HorarioNegocios();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Agregar_Click(object sender, EventArgs e)
        {
            if (Nombre.Text != ""  && Calle.Text != "" && ColFrac.Text != "" && CP.Text != "" && Numero.Text != "")
            {
                ObjEN.NombreNegocio = Nombre.Text;
                ObjEN.DireccionNegocio = Calle.Text + " " + ColFrac.Text + " " + CP.Text + " " + Numero.Text;
                ObjEN.CalleNegocio = Calle.Text;
                ObjEN.ColoniaNegocio = ColFrac.Text;
                ObjEN.CodigioPostal = Convert.ToInt16(CP.Text);
                ObjEN.NumeroCalle = Convert.ToInt16(Numero.Text);
                ObjEN.TelefonoNegocio = Telefono.Text;
                ObjEN.EstadoNegocio = "2";
                ObjEN.TipoNegocio = Tipo.Text;
                ObjEN.RFC = RFC.Text;
                ObjEN.DiasLaborales = "1";
                string msnN = ObjNN.InsertarNegocio(ObjEN);

                ObjEN = ObjNN.BuscarUsuarioPorNombre(ObjEN.NombreNegocio);
                ObjEUN.IdUsuario = Convert.ToInt16(Session["IdUsuario"]);
                ObjEUN.IdNegocios = ObjEN.IdNegocios;
                string msnUN = ObjNUN.InsertarUsuarioNegocios(ObjEUN);

                ObjEHN.IdNegocios = ObjEN.IdNegocios;
                ObjEHN.LE = Convert.ToInt16(EntradaL.Text);

                //lblTituloModal.Text = "Agregado";
               // lblMensajeModal.Text = "Se ha enviado la solicitud. \nEn cuanto sea aceptada tu negocio estara disponible.";
                Response.Redirect("mis_negocios.aspx");
            }
        }
    }
}