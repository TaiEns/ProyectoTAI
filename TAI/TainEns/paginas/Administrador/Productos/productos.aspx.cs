using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Entidades;
using Negocios;

namespace TainEns.paginas.Administrador.Productos
{
    public partial class productos : System.Web.UI.Page
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

        protected void Iniciar()
        {
            List<E_Producto> LstEP = new N_Producto().LstProductos();
            List<E_Producto> LstNP = new List<E_Producto>();
            
            foreach (E_Producto N in LstEP)
            {
                if (N.EstadoProducto == "3")
                {
                    LstNP.Add(new N_Producto().BuscarProductoPorId(N.IdProducto));
                }
            }

            grvProductosAceptados.DataSource = LstNP;
            grvProductosAceptados.DataBind();
        }
    }
}