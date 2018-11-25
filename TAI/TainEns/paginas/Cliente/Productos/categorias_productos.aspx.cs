﻿using System;
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
        }

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            //ApagarComponentes();
        }
        #endregion

        protected void gridbusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Panelcategorias.Visible = true;
            int IdProducto = Convert.ToInt16(gridbusqueda.SelectedDataKey["IdProducto"]);
            pProducto.Visible = true;
            ObjEP = ObjNP.BuscarProductoPorId(IdProducto);
            lblCardTitle.Text = ObjEP.NombreProducto;
            lblMarca.Text = ObjEP.Marca;
            lblCantidad.Text = Convert.ToString(ObjEP.CantidadProducto);
            lblMedida.Text = ObjEP.MedidaProducto;
        }
    }
}