using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Entidades;
using Negocios;

namespace TainEns.paginas.Cliente
{
    public partial class calificar : System.Web.UI.Page
    {
        E_Criticas ObjEC = new E_Criticas();
        N_Critica ObjNC = new N_Critica();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFeliz_Click(object sender, ImageClickEventArgs e)
        {
            Session["Voto"] = 1;
        }

        protected void btnTriste_Click(object sender, ImageClickEventArgs e)
        {
            Session["Voto"] = 0;
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            int IdUsurio = Convert.ToInt16(Session["IdUsuario"]);
            ObjEC.Comentario = tbComentario.Text;
            ObjEC.ValorCritica = Convert.ToInt16(Session["Voto"]);
            ObjEC.IdUsuario = IdUsurio;
            string msn = ObjNC.InsertarCriticas(ObjEC);

        }
    }
}