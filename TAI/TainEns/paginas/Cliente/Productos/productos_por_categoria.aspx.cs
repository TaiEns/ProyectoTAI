using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Entidades;
using Negocios;

namespace TainEns.paginas.Cliente.Productos
{
    public partial class productos_por_categoria : System.Web.UI.Page
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
            ApagarComponentes();
            string Categoria = Convert.ToString(Session["Categoria"]);
            List<E_Producto> LstP = new N_Producto().LstProductos();
            List<E_Producto> LstNT = new List<E_Producto>();

            foreach (E_Producto P in LstP)
            {
                if (P.CategoriaProducto == Categoria)
                {
                    LstNT.Add(new N_Producto().BuscarProductoPorCategoria(P.CategoriaProducto));
                }
            }

            grvProductos.DataSource = LstNT;
            grvProductos.DataBind();

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
        }

        #region Metodos
        protected void ApagarComponentes()
        {
            pProducto.Visible = false;
            pListas.Visible = false;
            pFormLista.Visible = false;
        }
        #endregion

        #region Botones
        protected void grvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApagarComponentes();
            int IdProducto = Convert.ToInt16(grvProductos.SelectedDataKey["IdProducto"]);
            Session["IdProducto"] = IdProducto;
            pProducto.Visible = true;
            ObjEP = ObjNP.BuscarProductoPorId(IdProducto);

            lblCardTitle.Text = ObjEP.NombreProducto;
            lblMarca.Text = ObjEP.Marca;
            lblCantidad.Text = Convert.ToString(ObjEP.CantidadProducto);
            lblMedida.Text = ObjEP.MedidaProducto;

        }

        protected void btnAgregaraLista_Click(object sender, EventArgs e)
        {
            pListas.Visible = true;
        }

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            ApagarComponentes();
        }
        #endregion

        protected void btnAgregarLista1_Click(object sender, EventArgs e)
        {
            pFormLista.Visible = true;
        }

        protected void btnListo_Click(object sender, EventArgs e)
        {
            int IdUsuario = Convert.ToInt16(Session["IdUsuario"]);
            ObjELU.IdUsuario = IdUsuario;
            //ObjELU.NombreLista = tbNombreLista.Text;

            string msn = ObjNLU.InsertarListaUsuario(ObjELU);
            grvListas.DataBind();
            pFormLista.Visible = false;
        }

        protected void btnCerrar2_Click(object sender, EventArgs e)
        {
            pListas.Visible = false;
        }

        protected void grvListas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IdProducto = Convert.ToInt16(Session["IdProducto"]);
            int IdLista = Convert.ToInt16(grvListas.SelectedDataKey["IdLista"]);
            ObjELP.IdProducto = IdProducto;
            ObjELP.IdLista = IdLista;

            string msn2 = ObjNLP.InsertarListaProductol(ObjELP);

            ApagarComponentes();
        }
    }
}