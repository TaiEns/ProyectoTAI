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
            MiTabla();
            DataTable dt = new DataTable();

            dt.Columns.Add("ID", System.Type.GetType("System.String"));
            dt.Columns.Add("Nombre", System.Type.GetType("System.String"));

            dt.Rows.Add("A001", "Jose Jose");
            dt.Rows.Add("B001", "Maria Azucena");
            dt.Rows.Add("C001", "Marcos Hoss");

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void MiTabla()
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

           // GridView2.DataSource = LstN;
           // GridView2.DataBind();
        }
        #region Internet
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            LabelMensaje.Text = "Boton Seleccionar";
            LabelMensaje.Visible = true;
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            LabelMensaje.Visible = true;
            LabelMensaje.Text = "Boton Borrar";
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            LabelMensaje.Visible = true;
            LabelMensaje.Text = "Boton Editar";
        }
        #endregion


        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

            LabelMensaje.Text = "Boton Seleccionar";
            LabelMensaje.Visible = true;
        }

        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            LabelMensaje.Visible = true;
            LabelMensaje.Text = "Boton Borrar";
        }

        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            LabelMensaje.Visible = true;
            LabelMensaje.Text = "Boton Editar";
        }
    }
}