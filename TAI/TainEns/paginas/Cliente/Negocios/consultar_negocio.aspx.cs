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
    public partial class consultar_negocio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Iniciar();
            }
        }

        protected void Iniciar()
        {
            int idnegocio = Convert.ToInt16(Session["IdNegocio"]);
            E_Negocios neg = new N_Negocio().BuscarNegocioPorId(idnegocio);
            E_Producto prod = new E_Producto();
            lbnegocio.Text = neg.NombreNegocio;
            lbnombreneg.Text = neg.NombreNegocio;
            lbubicacionneg.Text = neg.CalleNegocio + " # " + neg.NumeroCalle + " " + neg.ColoniaNegocio + " " + neg.CodigoPostal;
            lbtiponeg.Text = neg.TipoNegocio;
            lbnumneg.Text = neg.TelefonoNegocio;
            E_HorarioNegocios ObjEHN = new N_HorarioNegocios().BuscarHorarioNegociosPorIdNegocio(neg.IdNegocios);
            if (ObjEHN != null)
            {
                lblL.Text = ObjEHN.LE + "--" + ObjEHN.LS;
                lblM.Text = ObjEHN.ME + "--" + ObjEHN.MS;
                lblMi.Text = ObjEHN.MIE + "--" + ObjEHN.MIS;
                lblJ.Text = ObjEHN.JE + "--" + ObjEHN.JS;
                lblV.Text = ObjEHN.VE + "--" + ObjEHN.VS;
                lblS.Text = ObjEHN.SE + "--" + ObjEHN.SS;
                lblD.Text = ObjEHN.DE + "--" + ObjEHN.DS;
            }
            List<E_ProductoNegocios> lstprodneg = new N_ProductoNegocios().LstNegocios();
            List<E_ProductoNegocios> lstprecio = new List<E_ProductoNegocios>();
            List<E_Producto> LEP = new List<E_Producto>();
            foreach(E_ProductoNegocios E in lstprodneg)
            {
                if (E.IdNegocios == idnegocio)
                {
                    lstprecio.Add(E);
                    prod = new N_Producto().BuscarProductoPorId(E.IdProducto);
                    prod.MedidaProducto = "$ "+E.Precios;
                    LEP.Add(prod);
                }
            }
            gridNombreP.DataSource = LEP;
            gridNombreP.DataBind();
        }
    }
}