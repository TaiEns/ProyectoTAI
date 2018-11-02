using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Entidades;
using Negocios;

namespace TainEns.paginas
{
    public partial class registrar_usuario : System.Web.UI.Page
    {
        E_Usuario ObjEU = new E_Usuario();
        N_Usuario ObjNU = new N_Usuario();
        E_UsuarioRol ObjEUR = new E_UsuarioRol();
        N_UsuarioRol ObjNUR = new N_UsuarioRol();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ApagarComponentes();
            }
        }


        #region Metodos
        protected void ApagarComponentes()
        {
            pnModal.Visible = true;
        }
        
        #endregion

        protected void Registrarse_Click(object sender, EventArgs e)
        {
            string Nombre = Nombres.Text;
            string Apellido = Apellidos.Text;
            string NombreUsuario = Usuario.Text;
            string Email = Correo.Text;
            string Contra = Contrasena.Text;
            string confContra = ConfContrasena.Text;

            if(Nombre != "" && Apellido != "" && NombreUsuario != "" && Email != "" && Contra != "")
            {
                pnModal.Visible = true;
                Registrarse.Attributes.Add("data-toggle", "modal");
                System.Threading.Thread.Sleep(3000);
                //Response.Redirect("../index.aspx");
            }
        }
    }
}