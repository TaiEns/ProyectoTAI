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

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Agregar_Click(object sender, EventArgs e)
        {
            if(Nombre.Text != "" && RFC.Text != "" && Calle.Text != "" && ColFrac.Text != "" && CP.Text != "" && Numero.Text != "" && Telefono.Text != "")
            {
                ObjEN.NombreNegocio = Nombre.Text;
                ObjEN.DireccionNegocio = Calle.Text + " " + ColFrac.Text + " " + CP.Text + " " + Numero.Text;
                ObjEN.TelefonoNegocio = Telefono.Text;
                ObjEN.EstadoNegocio = "2";
                ObjEN.TipoNegocio = Tipo.Text;
                //ObjEN.DiasLaborales = DLaborales.Text;
                string msnN = ObjNN.InsertarNegocio(ObjEN);

                ObjEN = ObjNN.BuscarUsuarioPorNombre(ObjEN.NombreNegocio);
                ObjEUN.IdUsuario = Convert.ToInt16(Session["IdUsuario"]);
                ObjEUN.IdNegocios = ObjEN.IdNegocios;
                string msnUN = ObjNUN.InsertarUsuarioNegocios(ObjEUN);
                //System.Threading.Thread.Sleep(3000);
                //System.Threading.Thread.Sleep(3000);
                Response.Redirect("mis_negocios.aspx");
            }
        }
    }
}