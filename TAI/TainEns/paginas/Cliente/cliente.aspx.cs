using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Entidades;
using Negocios;

namespace TainEns.paginas.Cliente
{
    public partial class cliente : System.Web.UI.Page
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

            lblNombre.Text = ObjEU.NombreUsuario;
        }
    }
}