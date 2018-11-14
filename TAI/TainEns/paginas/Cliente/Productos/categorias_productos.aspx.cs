using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TainEns.paginas.Cliente.Productos
{
    public partial class categorias_productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCarnes_Click(object sender, EventArgs e)
        {
            Session["Categoria"] = "Carnes";
            Response.Redirect("productos_por_categoria.aspx");
        }

        protected void btnBebidas_Click(object sender, EventArgs e)
        {
            Session["Categoria"] = "Bebidas";
            Response.Redirect("productos_por_categoria.aspx");
        }

        protected void btnHigiene_Click(object sender, EventArgs e)
        {
            Session["Categoria"] = "Higiene";
            Response.Redirect("productos_por_categoria.aspx");
        }

        protected void btnFruta_Click(object sender, EventArgs e)
        {
            Session["Categoria"] = "Fruta";
            Response.Redirect("productos_por_categoria.aspx");
        }

        protected void btnLacteos_Click(object sender, EventArgs e)
        {
            Session["Categoria"] = "Lacteos";
            Response.Redirect("productos_por_categoria.aspx");
        }

        protected void btnSnacks_Click(object sender, EventArgs e)
        {
            Session["Categoria"] = "Snacks";
            Response.Redirect("productos_por_categoria.aspx");
        }

        protected void btnPanaderia_Click(object sender, EventArgs e)
        {
            Session["Categoria"] = "Panaderia";
            Response.Redirect("productos_por_categoria.aspx");
        }

        protected void btnEspecias_Click(object sender, EventArgs e)
        {
            Session["Categoria"] = "Especias";
            Response.Redirect("productos_por_categoria.aspx");
        }

        protected void btnCereales_Click(object sender, EventArgs e)
        {
            Session["Categoria"] = "Cereales";
            Response.Redirect("productos_por_categoria.aspx");
        }
    }
}