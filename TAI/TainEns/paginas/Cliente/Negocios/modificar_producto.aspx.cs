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
    public partial class modificar_producto : System.Web.UI.Page
    {
        E_ProductoNegocios ObjEPN = new E_ProductoNegocios();
        N_ProductoNegocios ObjNPN = new N_ProductoNegocios();
        E_Producto ObjEP = new E_Producto();
        N_Producto ObjNP = new N_Producto();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Iniciar();
            }
        }

        protected void Iniciar()
        {
            int IdProducto = Convert.ToInt16(Session["IdProducto"]);
            int IdNegocio = Convert.ToInt16(Session["IdNegocio"]);
            List<E_ProductoNegocios> LstPN = new N_ProductoNegocios().LstNegocios();

            foreach(E_ProductoNegocios PN in LstPN)
            {
                if (PN.IdNegocios == IdNegocio && PN.IdProducto == IdProducto)
                {
                    ObjEP = ObjNP.BuscarProductoPorId(IdProducto);
                    ObjEPN = PN;
                }
            }
            ddlCategoria.Text = ObjEP.CategoriaProducto;
            ddlNombre.Text = ObjEP.NombreProducto;
            Precio.Text = Convert.ToString(ObjEPN.Precios);
            Session["PN"] = ObjEPN;
        }

        #region Botones
        protected void Modificar_Click(object sender, EventArgs e)
        {
            ObjEPN = (E_ProductoNegocios)Session["PN"];
            ObjEPN.Precios = Convert.ToInt16(Precio.Text);

            string msnPN = ObjNPN.ModoficaProductoNegocios(ObjEPN);
            Response.Redirect("productos.aspx");
        }
        #endregion
    }
}