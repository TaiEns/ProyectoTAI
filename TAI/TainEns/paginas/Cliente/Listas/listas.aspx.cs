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
    public partial class listas : System.Web.UI.Page
    {
        E_Usuario ObjEU = new E_Usuario();
        N_Usuario ObjNE = new N_Usuario();
        E_ListaUsuario ObjELU = new E_ListaUsuario();
        N_ListaUsuario ObjNLU = new N_ListaUsuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Iniciar();
            }
        }

        protected void Iniciar()
        {
            int IdUsuario = Convert.ToInt16(Session["IdUsuario"]);
            //int IdUsuario = 3;
            ObjEU = ObjNE.BuscarUsuarioPorId(IdUsuario);
            List<E_ListaUsuario> LstUN = new N_ListaUsuario().LstUsuarios();
            List<E_ListaUsuario> LstN = new List<E_ListaUsuario>();
            foreach (E_ListaUsuario UN in LstUN)
            {
                if (UN.IdUsuario == IdUsuario)
                {
                     LstN.Add(UN);

                }
            }

            grvListas.DataSource = LstN;
            grvListas.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int IdUsuario = Convert.ToInt16(Session["IdUsuario"]);
            string comando = e.CommandName;
            string str = e.CommandArgument.ToString();
            string nombrelista = grvListas.Rows[Convert.ToInt16(str)].Cells[0].Text;
            //int lista;
            List<E_ListaUsuario> lstLU = new N_ListaUsuario().LstUsuarios();
            foreach(E_ListaUsuario ls in lstLU)
            {
                if (ls.NombreLista==nombrelista && ls.IdUsuario == IdUsuario)
                {
                    Session["idlista"] = ls.IdLista;
                }
            }
            //int IdLista = (new N_ListaUsuario().BuscarListaUsuarioporNombre(nombrenegocio)).IdLista;
            //int IdLista = (new N_ListaUsuario().BuscarListaUsuarioporLista(lista)).IdLista;
            //Session["IdLista"] = IdLista;
            switch (comando)
            {
                case "colsultar":
                    {
                        Response.Redirect("consultar_lista.aspx");
                        break;
                    };
                case "modificar":
                    {
                        Response.Redirect("modificar_negocio.aspx");
                        break;
                    };

                case "eliminar":
                    {
                        //string msnB = ObjNLU.BorraListaUsuario(IdLista);

                        //eliminando elementos de listaproducto
                        N_ListaProducto NLP = new N_ListaProducto();
                        List<E_ListaProducto> lstLP = new N_ListaProducto().LstUsuarios();
                        foreach(E_ListaProducto LP in lstLP)
                        {
                            if(LP.IdLista == Convert.ToInt16(Session["idlista"]))
                            {
                                NLP.BorraListaProducto(Convert.ToInt16(Session["idlista"]));
                            }
                        }

                        // Eliminando lista
                        N_ListaUsuario LU = new N_ListaUsuario();
                        LU.BorraListaUsuario(Convert.ToInt16(Session["idlista"]));
                        //grvListas.DataBind();
                        Iniciar();
                        break;
                    };
                default:
                    {
                        break;
                    };
            }
            // Response.Redirect("productos.aspx");
        }
    }
}