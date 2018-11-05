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
    public partial class solicitud_negocios : System.Web.UI.Page
    {
        E_Negocios ObjEN = new E_Negocios();
        N_Negocio ObjNN = new N_Negocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Iniciar();
            }
        }

        protected void Iniciar()
        {
            List<E_Negocios> LstN = new N_Negocio().LstNegocios();
            List<E_Negocios> LstNT = new List<E_Negocios>();

            foreach(E_Negocios N in LstN)
            {
                if(N.EstadoNegocio == "2")
                {
                    LstNT.Add(new N_Negocio().BuscarNegocioPorId(N.IdNegocios));
                }
            }

            grvSolicitudesNeg.DataSource = LstNT;
            grvSolicitudesNeg.DataBind();
        }

        protected void grvSolicitudesNeg_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IdNegocio = Convert.ToInt16(grvSolicitudesNeg.SelectedDataKey["IdNegocios"]);
            Session["IdNegocio"] = IdNegocio;
            Response.Redirect("aprobar_negocio.aspx");
        }
    }
}