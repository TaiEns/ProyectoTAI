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
            int IdLista = Convert.ToInt16(Session["idlista"]);
            nombrelista.Text = (new N_ListaUsuario().BuscarListaUsuarioporLista(IdLista)).NombreLista;
            List<E_ListaProducto> LstLP = new N_ListaProducto().LstUsuarios(); 
            List < E_Producto > LstP = new List<E_Producto>();

            LstP.Add((new N_Producto().BuscarProductoPorId(1)));
            LstP.Add((new N_Producto().BuscarProductoPorId(2)));
            //el id producto siempre es 0, no agarra bien ese parametro
            Label1.Text = "id producto "+LstLP[2].IdProducto+" id lista "+ LstLP[2].IdLista;
            grvProductos.DataSource = LstP;
            grvProductos.DataBind();
        }

        protected void grvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IdProducto = Convert.ToInt16(grvProductos.SelectedDataKey["IdProducto"]);
        }
    }
}