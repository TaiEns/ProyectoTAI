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
            foreach(E_ListaProducto LP in LstLP)
            {
                if(LP.IdLista == IdLista)
                {
                    LstP.Add(ObjNP.BuscarProductoPorId(LP.IdProducto));
                }
            }
            //el id producto siempre es 0, no agarra bien ese parametro
            //Label1.Text = "id producto "+LstLP[2].IdProducto+" id lista "+ LstLP[2].IdLista;
            grvProductos.DataSource = LstP;
            grvProductos.DataBind();
        }

        protected void grvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IdProducto = Convert.ToInt16(grvProductos.SelectedDataKey["IdProducto"]);
            int IdLista = Convert.ToInt16(Session["idlista"]);
            List<E_ListaProducto> LstLP = new N_ListaProducto().LstUsuarios();
            N_ListaProducto ObjNLP = new N_ListaProducto();

            foreach(E_ListaProducto LP in LstLP)
            {
                if(LP.IdLista == IdLista && LP.IdProducto == IdProducto)
                {
                    string msn = ObjNLP.BorraListaProducto(LP.IdListaProducto);
                    break;
                }
            }
            grvProductos.DataBind();
        }
    }
}