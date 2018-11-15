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
    public partial class negocios_encontrados : System.Web.UI.Page
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
            ApagarComponentes();
            string Negocio = Convert.ToString(Session["Negocio"]);
            List<E_Negocios> LstN = new N_Negocio().LstNegocios();
            List<E_Negocios> LstNT = new List<E_Negocios>();

            foreach (E_Negocios N in LstN)
            {
                if (N.NombreNegocio == Negocio && N.EstadoNegocio == "3")
                {
                    LstNT.Add(new N_Negocio().BuscarUsuarioPorNombre(N.NombreNegocio));
                }
            }

            grvNegocios.DataSource = LstNT;
            grvNegocios.DataBind();
        }

        #region Metodos
        protected void ApagarComponentes()
        {
            pProducto.Visible = false;
            ddlListasProductos.Visible = false;
        }
        #endregion

        #region Botones
        protected void grvNegocios_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApagarComponentes();
            int IdProducto = Convert.ToInt16(grvNegocios.SelectedDataKey["IdNegocios"]);
            pProducto.Visible = true;
            ObjEN = ObjNN.BuscarNegocioPorId(IdProducto);

            lblCardTitle.Text = ObjEN.NombreNegocio;
            lblTipo.Text = ObjEN.TipoNegocio;
            lblTelefono.Text = ObjEN.TelefonoNegocio;
            lblUbicacion.Text = ObjEN.CalleNegocio + " " + ObjEN.ColoniaNegocio + " " + ObjEN.CodigoPostal + " " + ObjEN.NumeroCalle;


        }

        protected void btnAgregaraLista_Click(object sender, EventArgs e)
        {
            ddlListasProductos.Visible = true;
        }

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            ApagarComponentes();
        }
        #endregion
    }
}