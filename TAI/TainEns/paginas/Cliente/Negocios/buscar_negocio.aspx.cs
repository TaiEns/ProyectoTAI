using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
            if (!IsPostBack)
            {
                Iniciar();
            }
        }

        protected void Iniciar()
        {
            regresar.Visible = false;
            List<E_Negocios> lstN = new N_Negocio().LstNegocios();
            foreach(E_Negocios E in lstN)
            {
                E.CalleNegocio = "Calle "+E.CalleNegocio + " #" + E.NumeroCalle + " Colonia " + E.ColoniaNegocio + " CP: " + E.CodigoPostal;
            }
            gridnegocios.DataSource = lstN;
            gridnegocios.DataBind();
        }

        #region Botones
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            List<E_Negocios> lstN = new N_Negocio().LstNegocios();
            List<E_Negocios> lista2 = new List<E_Negocios>();
            string pattern = tbBuscarNegocio.Text;
            foreach(E_Negocios en in lstN)
            {
                if (Regex.IsMatch(en.NombreNegocio.ToUpper(),pattern.ToUpper()))
                {
                    lista2.Add(en);
                }
            }
            if (lista2.Count!=0)
            {
                gridnegocios.DataSource = lista2;
                gridnegocios.DataBind();
                regresar.Visible = true;
            }
            else
            {
                tbBuscarNegocio.Attributes.Add("class", "form-control mr-sm-2 is-invalid");
                lblNegocioNoEncontrado.Text = "Negocio no registrado en el sistema";
            }
        }
        #endregion

        protected void regresar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }
    }
}