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
    public partial class mis_negocios : System.Web.UI.Page
    {
        E_Usuario ObjEU = new E_Usuario();
        N_Usuario ObjNE = new N_Usuario();
        E_Negocios ObjEN = new E_Negocios();
        N_Negocio ObjNN = new N_Negocio();
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
            int IdUsuario = Convert.ToInt16(Session["IdUsuario"]);
            //int IdUsuario = 3;
            ObjEU = ObjNE.BuscarUsuarioPorId(IdUsuario);
            List<E_UsuarioNegocios> LstUN = new N_UsuarioNegocios().LstUsuarioNegocio();
            List<E_Negocios> LstN = new List<E_Negocios>();
            E_Negocios Neg = new E_Negocios();
            N_Negocio NNeg = new N_Negocio();
            foreach (E_UsuarioNegocios UN in LstUN)
            {
                if (UN.IdUsuario == IdUsuario)
                {
                    Neg = NNeg.BuscarNegocioPorId(UN.IdNegocios);
                    if( Neg.EstadoNegocio == "3")
                    {
                        LstN.Add(new N_Negocio().BuscarNegocioPorId(UN.IdNegocios));
                    }
                    
                }
            }

            GridView1.DataSource = LstN;
            GridView1.DataBind();


        }
        
        #region Metodos
        protected void ApagarComponentes()
        {
            pELiminar.Visible = false;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["IdNegocio"] = Convert.ToInt16(GridView1.SelectedDataKey["IdNegocios"]);
            Response.Redirect("modificar_negocio.aspx");
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int IdNegocio = (int)GridView1.DataKeys[e.RowIndex].Value;
            Session["IdNegocios"] = IdNegocio;
            Response.Redirect("productos.aspx");
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int rowIndex = Convert.ToInt32(((LinkButton)sender).Attributes["ROW_INDEX"].ToString());
            int id = Convert.ToInt32(GridView1.DataKeys[rowIndex].Value);
        }
        #endregion

        protected void btnBorrar_OnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow row = btn.NamingContainer as GridViewRow;
            string pk = GridView1.DataKeys[row.RowIndex].Values[0].ToString();
        }
        
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string comando = e.CommandName;
            string str = e.CommandArgument.ToString();
            string nombrenegocio = GridView1.Rows[Convert.ToInt16(str)].Cells[0].Text;
            int idNegocio = (new N_Negocio().BuscarUsuarioPorNombre(nombrenegocio)).IdNegocios;
            Session["IdNegocio"] = idNegocio;
            switch (comando)
            {
                case "productos":
                    {
                        Response.Redirect("productos.aspx");
                        break;
                    };
                case "modificar":
                    {
                        Response.Redirect("modificar_negocio.aspx");
                        break;
                    };

                case "eliminar":
                    {
                        #region Dani
                        //eliminando negocio de usuario negocios
                        //modificar el stored procedure de DELETE dbo.[tbUsuarioNegocios] WHERE IdUsuario = @IdUsuario
                        // a DELETE dbo.[tbUsuarioNegocios] WHERE IdNegocios = @IdUsuario
                        /* List<E_UsuarioNegocios> LstUN = new N_UsuarioNegocios().LstUsuarioNegocio();
                         foreach (E_UsuarioNegocios UN in LstUN)
                         {
                             if (UN.IdNegocios == idNegocio)
                             {
                                 N_UsuarioNegocios ObjUN = new N_UsuarioNegocios();
                                 string msnUn = ObjUN.BorraUsuarioNegocio(idNegocio);
                             }
                         }

                         //eliminando productos de tabla productos negocio
                         //modificar el stored procedure de DELETE dbo.[tbProductoNegocios] WHERE IdUsuario = @IdProducto
                         // a DELETE dbo.[tbProductoNegocios] WHERE IdNegocios = @IdProducto
                         List<E_ProductoNegocios> LstPN = new N_ProductoNegocios().LstNegocios();
                         foreach (E_ProductoNegocios PN in LstPN)
                         {
                             if (PN.IdNegocios == idNegocio)
                             {
                                 N_ProductoNegocios ObjPN = new N_ProductoNegocios();
                                 string msnPN = ObjPN.BorraProductoNegocios(idNegocio);
                             }
                         }

                         //Eliminando horarios de la tabla horarionegocios
                         //este stored procedure esta bien
                         List<E_HorarioNegocios> LstHN = new N_HorarioNegocios().LstNegocios();
                         foreach (E_HorarioNegocios HN in LstHN)
                         {
                             if (HN.IdNegocios == idNegocio)
                             {
                                 N_HorarioNegocios ObjHN = new N_HorarioNegocios();
                                 string msnHN = ObjHN.BorraHorarioNegocios(idNegocio);
                             }
                         }

                         //finalmente eliminar el negocio
                         //cambio en el metodo N_Negocio.BorraNegocio, pedia solo la id del negocio, ahora debe pedir la entidad completa
                         //la entidad debe tener todos los campos llenos
                         N_Negocio N = new N_Negocio();
                         //N.BorraNegocio(new N_Negocio().BuscarNegocioPorId(idNegocio));*/

                        //string msnBN = N.BorraNegocio(idNegocio);
                        #endregion
                        pELiminar.Visible = true;
                        
                        break;
                    };
                default:
                    {
                        break;
                    };
            }
            // Response.Redirect("productos.aspx");
        }

        protected void btnSi_Click(object sender, EventArgs e)
        {
            int idNegocio = Convert.ToInt16(Session["IdNegocio"]);
            ObjEN = ObjNN.BuscarNegocioPorId(idNegocio);
            string msnBN = ObjNN.BorrarNegocio2(ObjEN);
            GridView1.DataBind();
            Response.Redirect("mis_negocios.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            ApagarComponentes();
        }
    }
}