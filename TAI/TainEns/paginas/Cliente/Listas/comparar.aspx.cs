using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Entidades;
using Negocios;

namespace TainEns.paginas.Cliente.Listas
{
    public class ProductoPrecio
    {
        private string _Nombre;
        private int _Precio;

        public ProductoPrecio()
        {
            _Nombre = string.Empty;
            _Precio = 0;
        }

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public int Precio { get => _Precio; set => _Precio = value; }
    }
    public partial class comparar : System.Web.UI.Page
    {
        E_Negocios ObjEN = new E_Negocios();
        N_Negocio ObjNN = new N_Negocio();
        E_ListaProducto ObjELP = new E_ListaProducto();
        N_ListaProducto ObjNLP = new N_ListaProducto();
        E_ListaUsuario ObjELU = new E_ListaUsuario();
        N_ListaUsuario ObjNLU = new N_ListaUsuario();
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
            //Buscar si ya selecciono un negocio del DDL
           // while (true)
           // {
                //string nom = ddlNegocio.Text;
                string nom = "Otro Cafe";
                ObjEN = ObjNN.BuscarUsuarioPorNombre(nom);
                if (ObjEN != null)
                {
                    Comparar(ObjEN);
                }
           // }
        }

        protected void InfoNegocio(E_Negocios negocio)
        {
            E_HorarioNegocios ObjEHN = new N_HorarioNegocios().BuscarHorarioNegociosPorIdNegocio(negocio.IdNegocios);
            lblNombreNegocio.Text = negocio.NombreNegocio;
            lblUbicacion.Text = negocio.CalleNegocio + " " + negocio.ColoniaNegocio + " " + negocio.NumeroCalle;
            lblTipo.Text = negocio.TipoNegocio;
            lblTelefono.Text = negocio.TelefonoNegocio;
            lblL.Text = ObjEHN.LE + "--" + ObjEHN.LS;
            lblM.Text = ObjEHN.ME + "--" + ObjEHN.MS;
            lblMi.Text = ObjEHN.MIE + "--" + ObjEHN.MIS;
            lblJ.Text = ObjEHN.JE + "--" + ObjEHN.JS;
            lblV.Text = ObjEHN.VE + "--" + ObjEHN.VS;
            lblS.Text = ObjEHN.SE + "--" + ObjEHN.SS;
            lblD.Text = ObjEHN.DE + "--" + ObjEHN.DS;

        }

        protected void Comparar(E_Negocios negocio)
        {
            lblTitulo.Text = negocio.NombreNegocio;
            BuscarProductos(negocio);
            InfoNegocio(negocio);
        }

        protected List<E_ListaProducto> LstProductosL()
        {
            //Crear una lista con los productos que son parte de la lista a comparar
            int IdLista = Convert.ToInt16(Session["idlista"]);
            List<E_ListaProducto> LstLP = new N_ListaProducto().LstUsuarios();
            List<E_ListaProducto> LLP = new List<E_ListaProducto>();
            foreach(E_ListaProducto LP in LstLP)
            {
                if(LP.IdLista == IdLista)
                {
                    LLP.Add(LP);
                }
            }

            return LLP;
        }

        protected List<E_ProductoNegocios> LstProductosN(E_Negocios negocio)
        {
            //Crear una lista con los productos que son parte del negocio
            List<E_ProductoNegocios> LstPN = new N_ProductoNegocios().LstNegocios(); 
            List<E_ProductoNegocios> LPN = new List<E_ProductoNegocios>();
            foreach (E_ProductoNegocios PN in LstPN)
            {
                if (PN.IdNegocios == negocio.IdNegocios)
                {
                    LPN.Add(PN);
                }
            }

            return LPN;
        }

        protected void BuscarProductos(E_Negocios negocio)
        {
            int IdLista = Convert.ToInt16(Session["idlista"]);
            ObjELU = ObjNLU.BuscarListaUsuarioporLista(IdLista);
            lblNombreLista.Text = ObjELU.NombreLista;
            List<E_ListaProducto> LstLP = LstProductosL(); //Lista de productos de la lista a comparar
            List<E_ProductoNegocios> LstPN = LstProductosN(negocio); //Lista de productos del negocio
            List<ProductoPrecio> PN_encontrados = new List<ProductoPrecio>();
            List<ProductoPrecio> PN_no_encontrados = new List<ProductoPrecio>();
            ProductoPrecio ObjPP = new ProductoPrecio();
            int cont;

            foreach (E_ProductoNegocios P in LstPN)
            {
                cont = 0;
                foreach(E_ListaProducto LP in LstLP)
                {
                    if(P.IdProducto == LP.IdProducto)
                    {
                        ObjEP = ObjNP.BuscarProductoPorId(P.IdProducto);
                        ObjPP.Nombre = ObjEP.NombreProducto;
                        ObjPP.Precio = P.Precios;
                        PN_encontrados.Add(ObjPP);
                        cont++;
                    }
                }
                if(cont == 0)
                {
                    ObjEP = ObjNP.BuscarProductoPorId(P.IdProducto);
                    ObjPP.Nombre = ObjEP.NombreProducto;
                    ObjPP.Precio = P.Precios;
                    PN_no_encontrados.Add(ObjPP);
                }
            }
            grvProductosEncontrados.DataSource = PN_encontrados;
            grvProductosNoEnocntrados.DataSource = PN_no_encontrados;
            grvProductosEncontrados.DataBind();
            grvProductosNoEnocntrados.DataBind();

        }
    }
}