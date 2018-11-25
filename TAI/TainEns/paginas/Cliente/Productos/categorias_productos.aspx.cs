using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;


using Entidades;
using Negocios;

namespace TainEns.paginas.Cliente.Productos
{
    public partial class categorias_productos : System.Web.UI.Page
    {
        E_Producto ObjEP = new E_Producto();
        N_Producto ObjNP = new N_Producto();
        E_ListaUsuario ObjELU = new E_ListaUsuario();
        N_ListaUsuario ObjNLU = new N_ListaUsuario();
        E_ListaProducto ObjELP = new E_ListaProducto();
        N_ListaProducto ObjNLP = new N_ListaProducto();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Iniciar();
            }
        }
        protected void Iniciar()
        {
            Panelbusqueda.Visible = false;
            Panelcategorias.Visible = true;
            pProducto.Visible = false;
            pListas.Visible = false;
        }
        #region Botones
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

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            List<E_Producto> lista = new N_Producto().LstProductos();
            List<E_Producto> lista2 = new List<E_Producto>();
            string pattern = tbBuscarProducto.Text;
            pattern = pattern.ToUpper();
            foreach(E_Producto producto in lista)
            {
                if(Regex.IsMatch(producto.NombreProducto.ToUpper(), pattern))
                {
                    lista2.Add(producto);
                }
            }
            //ObjEP = ObjNP.BuscarProductoPorNombre(tbBuscarProducto.Text);
            if(lista2.Count != 0)
            {
                //Session["ListaProductos"] = lista2;
                // Response.Redirect("busqueda_producto.aspx");
                Panelcategorias.Visible = false;
                gridbusqueda.DataSource = lista2;
                gridbusqueda.DataBind();
                Panelbusqueda.Visible = true;

            }
            else
            {
                tbBuscarProducto.Attributes.Add("class", "form-control mr-sm-2 is-invalid");
                lblProductoNoEncontrado.Text = "Producto no registrado en el sistema";
            }
        }
        #endregion

        #region Metodos
        protected void ApagarComponentes()
        {
            //pProducto.Visible = false;
           // ddlListasProductos.Visible = false;
        }
        #endregion

        #region Botones


        protected void btnAgregaraLista_Click(object sender, EventArgs e)
        {
            //ddlListasProductos.Visible = true;
            //grvListas.DataSource =;
            int IdUsuario = Convert.ToInt16(Session["IdUsuario"]);
            List<E_ListaUsuario> LstELU = new N_ListaUsuario().LstUsuarios();
            List<E_ListaUsuario> LstELN = new List<E_ListaUsuario>();
            foreach (E_ListaUsuario P in LstELU)
            {
                if (P.IdUsuario == IdUsuario)
                {
                    LstELN.Add(P);
                }
            }

            grvListas.DataSource = LstELN;
            grvListas.DataBind();
            pListas.Visible = true;
        }

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            //ApagarComponentes();
            pProducto.Visible = false;
        }
        #endregion

        protected void gridbusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Panelcategorias.Visible = true;
            int IdProducto = Convert.ToInt16(gridbusqueda.SelectedDataKey["IdProducto"]);
            Session["IdProducto"] = IdProducto;
            pProducto.Visible = true;
            ObjEP = ObjNP.BuscarProductoPorId(IdProducto);
            lblCardTitle.Text = ObjEP.NombreProducto;
            lblMarca.Text = ObjEP.Marca;
            lblCantidad.Text = Convert.ToString(ObjEP.CantidadProducto);
            lblMedida.Text = ObjEP.MedidaProducto;
        }

        protected void grvListas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IdProducto = Convert.ToInt16(Session["IdProducto"]);
            int IdLista = Convert.ToInt16(grvListas.SelectedDataKey["IdLista"]);
            E_ListaProducto ObjELP = new E_ListaProducto();
            ObjELP.IdProducto = IdProducto;
            ObjELP.IdLista = IdLista;

            string msn2 = ObjNLP.InsertarListaProductol(ObjELP);
            Iniciar();

        }

        protected void btnAgregarLista1_Click(object sender, EventArgs e)
        {
            pFormLista.Visible = true;
        }

        protected void btnListo_Click(object sender, EventArgs e)
        {
            
            int IdUsuario = Convert.ToInt16(Session["IdUsuario"]);
            ObjELU.IdUsuario = IdUsuario;
            ObjELU.NombreLista = tbNombreLista.Text;
            string msn = ObjNLU.InsertarListaUsuario(ObjELU);
            //grvListas.DataBind();
            int IdProducto = Convert.ToInt16(Session["IdProducto"]);
            //int IdLista;
            //faltaba descomentar funcion buscar lista por nombre de lista
            List<E_ListaUsuario> lstU = new N_ListaUsuario().LstUsuarios();
            foreach (E_ListaUsuario lista in lstU)
            {
                if (lista.IdUsuario == IdUsuario && lista.NombreLista == tbNombreLista.Text)
                {
                    ObjELP.IdLista = lista.IdLista;
                }
            }
            //int IdLista = (new N_ListaUsuario().BuscarListaUsuarioporNombre(tbNombreLista.Text)).IdLista;
            ObjELP.IdProducto = IdProducto;
            //ObjELP.IdLista = Idlista;
            pFormLista.Visible = false;
            string msn2 = ObjNLP.InsertarListaProductol(ObjELP);
            Iniciar();
        }

        protected void btnCerrar2_Click(object sender, EventArgs e)
        {
            pListas.Visible = false;
        }
    }
}