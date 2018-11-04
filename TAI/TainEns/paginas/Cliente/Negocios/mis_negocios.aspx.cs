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
            ObjEU = ObjNE.BuscarUsuarioPorId(IdUsuario);
            List<E_UsuarioNegocios>  LstUN = new N_UsuarioNegocios().LstUsuarioNegocio();
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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IdNegocio = Convert.ToInt16(GridView1.SelectedDataKey["IdNegocios"]);
            bandera.Text = GridView1.SelectedRow.ToString();


        }

        protected void eliminarrr()
        {
            bandera.Text = "holaaaa";
        }
            
            

    }
}