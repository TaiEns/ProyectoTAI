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
    public partial class agregar_producto : System.Web.UI.Page
    {
        E_Producto ObjEP = new E_Producto();
        N_Producto ObjNP = new N_Producto();
        E_Negocios ObjEN = new E_Negocios();
        N_Negocio ObjNN = new N_Negocio();
        E_ProductoNegocios ObjEPN = new E_ProductoNegocios();
        N_ProductoNegocios ObjNPN = new N_ProductoNegocios();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Iniciar();
            }
        }

        protected void Iniciar()
        {
           /* List<E_Producto> LstUN = new N_Producto().LstProductos();
            List<E_Producto> LstN = new List<E_Producto>();
            int i = 0;
            foreach (E_Producto UN in LstUN)
            {
                if (UN.EstadoProducto == "3")
                {
                    LstN.Add(new N_Producto().BuscarProductoPorId(UN.IdProducto));
                    ddlNombre.DataTextField = LstN[i].NombreProducto;
                    ddlNombre.DataValueField = LstN[i].NombreProducto;
                    i++;
                }
            }

            ddlNombre.DataSource = LstN;
            ddlNombre.DataBind();*/
        }

        protected void Agregar_Click(object sender, EventArgs e)
        {
            int IdNegocio = Convert.ToInt16(Session["IdNegocio"]);
            ObjEN = ObjNN.BuscarNegocioPorId(IdNegocio);
            ObjEP = ObjNP.BuscarProductoPorNombre(ddlNombre.Text);

            ObjEPN.IdProducto = ObjEP.IdProducto;
            ObjEPN.IdNegocios = ObjEN.IdNegocios;
            ObjEPN.Precios = Convert.ToInt16(Precio.Text);

            string msnPN = ObjNPN.InsertarProductoNegocios(ObjEPN);
        }
    }
}