using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Entidades;
using Negocios;

namespace TainEns.paginas.Administrador.Solicitudes
{
    public partial class aprobar_producto : System.Web.UI.Page
    {
        E_Producto ObjEP = new E_Producto();
        N_Producto ObjNP = new N_Producto();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Iniciar();
            }
        }

        protected void Apagartb()
        {
            Nombre.Enabled = false;
            Categoria.Enabled = false;
            Marca.Enabled = false;
        }

        protected void AgregarAtributos()
        {
            Nombre.Attributes.Add("class", "form-control");
            Categoria.Attributes.Add("class", "form-control");
            Marca.Attributes.Add("class", "form-control");
        }

        protected void Iniciar()
        {
            //Apagartb();
            int IdProducto = Convert.ToInt16(Session["IdProducto"]);
            ObjEP = ObjNP.BuscarProductoPorId(IdProducto);

            Nombre.Text = ObjEP.NombreProducto;
            Categoria.Text = ObjEP.CategoriaProducto;
            Marca.Text = ObjEP.Marca;
            AgregarAtributos();
        }

        protected void Aprobar_Click(object sender, EventArgs e)
        {
            int IdProducto = Convert.ToInt16(Session["IdProducto"]);
            ObjEP = ObjNP.BuscarProductoPorId(IdProducto);
            ObjEP.EstadoProducto = "3";
            string msn = ObjNP.ModoficaProducto(ObjEP);
            Response.Redirect("solicitud_productos.aspx");
        }
    }
}