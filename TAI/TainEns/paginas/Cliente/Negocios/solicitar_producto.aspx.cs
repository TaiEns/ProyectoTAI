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
    public partial class solicitar_producto : System.Web.UI.Page
    {
        E_Producto ObjEP = new E_Producto();
        N_Producto ObjNP = new N_Producto();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Agregar_Click(object sender, EventArgs e)
        {
            if (Nombre.Text != "" && Cantidad.Text != "" && Presentacion.HasFile && ddlCategoria.Text != "Categoria" && ddlMedida.Text != "Medida" && Marca.Text != "")
            {
                ObjEP.NombreProducto = Nombre.Text;
                ObjEP.CantidadProducto = Convert.ToInt16(Cantidad.Text);
                ObjEP.Descripcion = Descripcion.Value;
                ObjEP.EstadoProducto = "2";
                ObjEP.Marca = Marca.Text;
                ObjEP.MedidaProducto = ddlMedida.Text;
                ObjEP.CategoriaProducto = ddlCategoria.Text;

                string msn = ObjNP.InsertarProducto(ObjEP);
                Response.Redirect("productos.aspx");
            }
        }
    }
}