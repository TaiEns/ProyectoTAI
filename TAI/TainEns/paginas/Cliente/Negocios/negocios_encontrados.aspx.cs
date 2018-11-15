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
        E_HorarioNegocios ObjEHN = new E_HorarioNegocios();
        N_HorarioNegocios ObjNHN = new N_HorarioNegocios();
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
            int IdNegocio = Convert.ToInt16(grvNegocios.SelectedDataKey["IdNegocios"]);
            pProducto.Visible = true;
            ObjEN = ObjNN.BuscarNegocioPorId(IdNegocio);
            ObjEHN = ObjNHN.BuscarHorarioNegociosPorIdNegocio(IdNegocio);

            lblCardTitle.Text = ObjEN.NombreNegocio;
            lblTipo.Text = ObjEN.TipoNegocio;
            lblTelefono.Text = ObjEN.TelefonoNegocio;
            lblUbicacion.Text = ObjEN.CalleNegocio + " " + ObjEN.ColoniaNegocio + " " + ObjEN.CodigoPostal + " " + ObjEN.NumeroCalle;
            lblLunes.Text = "Lunes " + Convert.ToString(ObjEHN.LE) + "a.m a " + Convert.ToString(ObjEHN.LS);
            lblMartes.Text = "Martes " + Convert.ToString(ObjEHN.ME) + "a.m a " + Convert.ToString(ObjEHN.MS);
            lblMiercoles.Text = "Miercoles " + Convert.ToString(ObjEHN.MIE) + "a.m a " + Convert.ToString(ObjEHN.MIS);
            lblJueves.Text = "Jueves " + Convert.ToString(ObjEHN.JE) + "a.m a " + Convert.ToString(ObjEHN.JS);
            lblViernes.Text = "Viernes " + Convert.ToString(ObjEHN.VE) + "a.m a " + Convert.ToString(ObjEHN.VS);
            lblSabado.Text = "Sabado " + Convert.ToString(ObjEHN.SE) + "a.m a " + Convert.ToString(ObjEHN.SS);
            lblDomingo.Text = "Domingo " + Convert.ToString(ObjEHN.DE) + "a.m a " + Convert.ToString(ObjEHN.DS);

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