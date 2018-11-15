using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Entidades;
using Negocios;

namespace TainEns.paginas.Cliente.Productos
{
    public partial class busqueda_producto : System.Web.UI.Page
    {
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
            ApagarComponentes();
            string Producto = Convert.ToString(Session["Producto"]);
            List<E_Producto> LstP = new N_Producto().LstProductos();
            List<E_Producto> LstNT = new List<E_Producto>();

            foreach (E_Producto P in LstP)
            {
                if (P.NombreProducto == Producto)
                {
                    LstNT.Add(new N_Producto().BuscarProductoPorNombre(P.NombreProducto));
                }
            }

            grvProductos.DataSource = LstNT;
            grvProductos.DataBind();
        }

        #region Metodos
        protected void ApagarComponentes()
        {
            pProducto.Visible = false;
            ddlListasProductos.Visible = false;
        }
        #endregion

        #region Botones
        protected void grvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApagarComponentes();
            int IdProducto = Convert.ToInt16(grvProductos.SelectedDataKey["IdProducto"]);
            pProducto.Visible = true;
            ObjEP = ObjNP.BuscarProductoPorId(IdProducto);

            lblCardTitle.Text = ObjEP.NombreProducto;
            lblMarca.Text = ObjEP.Marca;
            lblCantidad.Text = Convert.ToString(ObjEP.CantidadProducto);
            lblMedida.Text = ObjEP.MedidaProducto;

        }

        protected void btnAgregaraLista_Click(object sender, EventArgs e)
        {
            ddlListasProductos.Visible = true;
        }

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            ApagarComponentes();
        }
        #endregion
    }
}