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
                     LstN.Add(new N_ListaUsuario().BuscarListaUsuarioporUsuario(UN.IdUsuario));

                }
            }

            grvListas.DataSource = LstN;
            grvListas.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string comando = e.CommandName;
            string str = e.CommandArgument.ToString();
            string nombrenegocio = grvListas.Rows[Convert.ToInt16(str)].Cells[0].Text;
            int IdLista = (new N_ListaUsuario().BuscarListaUsuarioporNombre(nombrenegocio)).IdLista;
            Session["IdLista"] = IdLista;
            switch (comando)
            {
                case "productos":
                    {
                        Response.Redirect("productos.aspx");
                        break;
                    };
                case "modificar":
                    {
                        Response.Redirect("modificar_negocio.aspx");
                        break;
                    };

                case "eliminar":
                    {
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