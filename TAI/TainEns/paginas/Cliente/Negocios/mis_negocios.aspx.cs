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
    public partial class mis_negocios : System.Web.UI.Page
    {
        E_Usuario ObjEU = new E_Usuario();
        N_Usuario ObjNE = new N_Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Iniciar();
            }
        }

        protected void Iniciar()
        {
            int IdUsuario = Convert.ToInt16(Session["IdUsuario"]);
            //int IdUsuario = 3;
            ObjEU = ObjNE.BuscarUsuarioPorId(IdUsuario);
            List<E_UsuarioNegocios> LstUN = new N_UsuarioNegocios().LstUsuarioNegocio();
            List<E_Negocios> LstN = new List<E_Negocios>();
            E_Negocios Neg = new E_Negocios();
            N_Negocio NNeg = new N_Negocio();
            foreach (E_UsuarioNegocios UN in LstUN)
            {
                if (UN.IdUsuario == IdUsuario)
                {
                    Neg = NNeg.BuscarNegocioPorId(UN.IdNegocios);
                    if( Neg.EstadoNegocio == "3")
                    {
                        LstN.Add(new N_Negocio().BuscarNegocioPorId(UN.IdNegocios));
                    }
                    
                }
            }

            GridView1.DataSource = LstN;
            GridView1.DataBind();


        }

        #region Metodos
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["IdNegocio"] = Convert.ToInt16(GridView1.SelectedDataKey["IdNegocios"]);
            Response.Redirect("modificar_negocio.aspx");
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int IdNegocio = (int)GridView1.DataKeys[e.RowIndex].Value;
            Session["IdNegocios"] = IdNegocio;
            Response.Redirect("productos.aspx");
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int rowIndex = Convert.ToInt32(((LinkButton)sender).Attributes["ROW_INDEX"].ToString());
            int id = Convert.ToInt32(GridView1.DataKeys[rowIndex].Value);
        }
        #endregion

        protected void btnBorrar_OnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow row = btn.NamingContainer as GridViewRow;
            string pk = GridView1.DataKeys[row.RowIndex].Values[0].ToString();
        }


    }
}