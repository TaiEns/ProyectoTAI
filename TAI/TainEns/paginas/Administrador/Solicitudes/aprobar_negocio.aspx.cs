using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Entidades;
using Negocios;

namespace TainEns.paginas.Administrador.Solicitudes
{
    public partial class aprobar_negocio : System.Web.UI.Page
    {
        E_Negocios ObjEN = new E_Negocios();
        N_Negocio ObjNN = new N_Negocio();
        E_Usuario ObjEU = new E_Usuario();
        N_Usuario ObjNU = new N_Usuario();
        E_UsuarioNegocios ObjEUN = new E_UsuarioNegocios();
        N_UsuarioNegocios ObjNUN = new N_UsuarioNegocios();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Iniciar();
            }
        }

        protected void Apagartb()
        {
            Nombre.Enabled = false;
            Correo.Enabled = false;
            Calle.Enabled = false;
            Tipo.Enabled = false;
            Telefono.Enabled = false;
            DLaborales.Enabled = false;
        }

        protected void Iniciar()
        {
            Apagartb();
            int IdNegocio = Convert.ToInt16(Session["IdNegocio"]);

            ObjEN = ObjNN.BuscarNegocioPorId(IdNegocio);
            ObjEUN = ObjNUN.BuscarUsuarioNegocioPorNegocio(IdNegocio);
            ObjEU = ObjNU.BuscarUsuarioPorId(ObjEUN.IdUsuario);

            lblNombreNegocio.Text = ObjEN.NombreNegocio;
            Nombre.Text = ObjEU.NombreUsuario;
            Correo.Text = ObjEU.EmailUsuario;
            Calle.Text = ObjEN.DireccionNegocio;
            Tipo.Text = ObjEN.TelefonoNegocio;
            DLaborales.Text = ObjEN.DiasLaborales;
            Telefono.Text = ObjEN.TelefonoNegocio;
        }

        protected void Aprobar_Click(object sender, EventArgs e)
        {
            int IdNegocio = Convert.ToInt16(Session["IdNegocio"]);

            ObjEN = ObjNN.BuscarNegocioPorId(IdNegocio);
            ObjEN.EstadoNegocio = "3";
            string msn = ObjNN.ModoficaNegocio(ObjEN);
            Response.Redirect("solicitud_negocios.aspx");
        }
    }
}