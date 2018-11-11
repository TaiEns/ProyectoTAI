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
    public partial class solicitud_productos : System.Web.UI.Page
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
            List<E_Producto> LstP = new N_Producto().LstProductos();
            List<E_Producto> LstPT = new List<E_Producto>();

            foreach (E_Producto P in LstP)
            {
                if (P.EstadoProducto == "2")
                {
                    LstPT.Add(new N_Producto().BuscarProductoPorId(P.IdProducto));
                }
            }

            grvSolicitudesProd.DataSource = LstPT;
            grvSolicitudesProd.DataBind();
        }

        protected void grvSolicitudesNeg_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IdProducto = Convert.ToInt16(grvSolicitudesProd.SelectedDataKey["IdProducto"]);
            Session["IdProducto"] = IdProducto;
            Response.Redirect("aprobar_producto.aspx");
        }
    }
}