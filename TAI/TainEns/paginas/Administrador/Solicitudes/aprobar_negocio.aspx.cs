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
        protected void Page_Load(object sender, EventArgs e)
        {
            int IdNegocio = Convert.ToInt16(Session["IdNegocio"]);

            ObjEN = ObjNN.BuscarNegocioPorId(IdNegocio);
            lblmsn.Text = ObjEN.NombreNegocio;

        }
    }
}