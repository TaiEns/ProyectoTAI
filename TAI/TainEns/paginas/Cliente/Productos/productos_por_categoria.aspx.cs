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
    public partial class productos_por_categoria : System.Web.UI.Page
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
            pProducto.Visible = false;
            string Categoria = Convert.ToString(Session["Categoria"]);
            List<E_Producto> LstP = new N_Producto().LstProductos();
            List<E_Producto> LstNT = new List<E_Producto>();

            foreach (E_Producto P in LstP)
            {
                if (P.CategoriaProducto == Categoria)
                {
                    LstNT.Add(new N_Producto().BuscarProductoPorCategoria(P.CategoriaProducto));
                }
            }

            grvProductos.DataSource = LstNT;
            grvProductos.DataBind();
        }

        #region Botones
        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            pProducto.Visible = true;
            //int IdNegocio = (int)grvProductos.DataKeys[e.RowIndex].Value;
            //System.Threading.Thread.Sleep(3000);
        }
        #endregion

        protected void grvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IdProducto = Convert.ToInt32(grvProductos.SelectedDataKey["IdProducto"]);
        }

        protected void grvProductos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string comando = e.CommandName;
            string str = e.CommandArgument.ToString();
            string IdProducto = grvProductos.Rows[Convert.ToInt16(str)].Cells[0].Text;
            //ObjEP = ObjNP.
            msnCalis.Text = IdProducto;
        }
    }
}