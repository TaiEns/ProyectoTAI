using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Entidades;
using Negocios;

namespace TainEns
{
    public partial class calis : System.Web.UI.Page
    {

        E_Usuario ObjEU = new E_Usuario();
        N_Usuario ObjNE = new N_Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            int IdUsuario = 2;
            ObjEU = ObjNE.BuscarUsuarioPorId(IdUsuario);
            List<E_UsuarioNegocios> LstUN = new N_UsuarioNegocios().LstUsuarioNegocio();
            List<E_Negocios> LstN = new List<E_Negocios>();
            foreach (E_UsuarioNegocios UN in LstUN)
            {
                if (UN.IdUsuario == IdUsuario)
                {
                    LstN.Add(new N_Negocio().BuscarNegocioPorId(UN.IdNegocios));
                }
            }

            GridView1.DataSource = LstN;
            GridView1.DataBind();
        }
        #region Internet
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IdNegocio = Convert.ToInt16(GridView1.SelectedDataKey["IdNegocios"]);
            LabelMensaje.Text = "Boton Seleccionar" + Convert.ToString(IdNegocio);
            LabelMensaje.Visible = true;
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //Obteniendo IdNegocios
            int IdNegocio = (int)GridView1.DataKeys[e.RowIndex].Value;
            LabelMensaje.Visible = true;
            LabelMensaje.Text = "Boton Borrar" + Convert.ToString(IdNegocio);
        }
        #endregion
        
    }
}