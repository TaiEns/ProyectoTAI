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
    public partial class buscar_negocio : System.Web.UI.Page
    {
        E_Negocios ObjEN = new E_Negocios();
        N_Negocio ObjNN = new N_Negocio();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Botones
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            ObjEN = ObjNN.BuscarUsuarioPorNombre(tbBuscarNegocio.Text);
            if (ObjEN != null)
            {
                Session["Negocio"] = ObjEN.NombreNegocio;
                Response.Redirect("negocios_encontrados.aspx");
            }
            else
            {
                tbBuscarNegocio.Attributes.Add("class", "form-control mr-sm-2 is-invalid");
                lblNegocioNoEncontrado.Text = "Producto no registrado en el sistema";
            }
        }
        #endregion
    }
}