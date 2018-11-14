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
    }
}