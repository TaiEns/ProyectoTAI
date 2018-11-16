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
    public partial class productos : System.Web.UI.Page
    {
        List<E_ProductoNegocios> LstPN = new N_ProductoNegocios().LstNegocios();
        //List<E_Producto> LstPp = new List<E_Producto>();
        E_ProductoNegocios ObjEPN = new E_ProductoNegocios();
        N_ProductoNegocios ObjNPN = new N_ProductoNegocios();
        E_Producto ObjEP = new E_Producto();
        N_Producto ObjNP = new N_Producto();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ApagarComponentes();
                List<E_Producto> LstPp = Iniciar();
                grvProductosAceptados.DataSource = LstPp;
                grvProductosAceptados.DataBind();
            }
        }

        protected void ApagarComponentes()
        {
            pELiminar.Visible = false;
        }

        protected List<E_Producto> Iniciar()
        {
            List<E_Producto> LstP = new List<E_Producto>();
            int IdNegocio = Convert.ToInt16(Session["IdNegocio"]);
            //Label1.Text = "negocio " + IdNegocio;
            //int IdUsuario = 3;
            foreach (E_ProductoNegocios PN in LstPN)
            {
                if (PN.IdNegocios == IdNegocio)
                {
                    //E_ProductoNegocios pnaux = new N_ProductoNegocios().BuscarProductoNegociosPorIdNegocio(IdNegocio);
                    E_Producto producto = new N_Producto().BuscarProductoPorId(PN.IdProducto);
                    //producto.PrecioProducto = PN.Precios;
                    LstP.Add(producto);
                }
            }
            //Label2.Text = "cantidad de elementos " + LstP.Count;
            return LstP;
        }

        protected void grvProductosAceptados_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string comando = e.CommandName;
            string str = e.CommandArgument.ToString();
            List<E_Producto> LstP = Iniciar();

            E_Producto pro = LstP[Convert.ToInt16(str)];

            switch (comando)
            {
                case "editar":
                    {
                        Session["IdProducto"] = pro.IdProducto;
                        //Label2.Text = "editando producto " + pro.IdProducto;
                        Response.Redirect("modificar_producto.aspx");
                        break;
                    };

                case "eliminar":
                    {
                        //Label2.Text = "eliminando producto " + pro.IdProducto;
                        Session["IdProducto"] = pro.IdProducto;
                        pELiminar.Visible = true;
                        break;
                    };
                default:
                    {
                        //Label2.Text = "comando no encontrado " + pro.IdProducto;
                        break;
                    };
            }
        }

        protected void btnSi_Click(object sender, EventArgs e)
        {
            int IdProducto = Convert.ToInt16(Session["IdProducto"]);
            int IdNegocio = Convert.ToInt16(Session["IdNegocio"]);
            List<E_ProductoNegocios> LstPN = new N_ProductoNegocios().LstNegocios();

            foreach (E_ProductoNegocios PN in LstPN)
            {
                if (PN.IdNegocios == IdNegocio && PN.IdProducto == IdProducto)
                {
                    ObjEP = ObjNP.BuscarProductoPorId(IdProducto);
                    ObjEPN = PN;
                }
            }
            string msnBPN = ObjNPN.BorraProductoNegocios(ObjEPN.IdProductoNegocio);
            grvProductosAceptados.DataBind();
            ApagarComponentes();
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            ApagarComponentes();
        }
    }
}