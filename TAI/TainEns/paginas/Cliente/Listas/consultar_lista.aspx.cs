using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Entidades;
using Negocios;

namespace TainEns.paginas.Cliente.Listas
{
    public partial class consultar_lista : System.Web.UI.Page
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
            int IdLista = Convert.ToInt16(Session["IdLista"]);
            List<E_ListaProducto> LstUN = new N_ListaProducto().LstUsuarios();
            List<E_Producto> LstN = new List<E_Producto>();
            foreach (E_ListaProducto UN in LstUN)
            {
                if (UN.IdLista == IdLista)
                {
                    ObjEP = ObjNP.BuscarProductoPorId(UN.IdProducto);
                    // LstN.Add(new N_Producto().BuscarListaProductoporlista(UN.IdLista));
                    if(ObjEP != null)
                    {
                        LstN.Add(ObjEP);
                    }
                }
            }

            grvProductos.DataSource = LstN;
            grvProductos.DataBind();
        }

        protected void grvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IdProducto = Convert.ToInt16(grvProductos.SelectedDataKey["IdProducto"]);
        }
    }
}