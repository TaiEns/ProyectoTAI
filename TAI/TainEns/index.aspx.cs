using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Entidades;
using Negocios;

namespace TainEns
{
    public partial class index : System.Web.UI.Page
    {
        E_Usuario ObjEU = new E_Usuario();
        N_Usuario ObjNU = new N_Usuario();
        E_Rol ObjER = new E_Rol();
        N_Rol ObjNR = new N_Rol();
        E_UsuarioRol ObjEUR = new E_UsuarioRol();
        N_UsuarioRol ObjNUR = new N_UsuarioRol();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack){
                Inicio();
            }
        }

        protected void Inicio()
        {
            ApagarComponentes();
        }

        #region Metodos
        protected void ApagarComponentes()
        {
            pnErrorUsuarioContra.Visible = false;
        }

        protected void Direccionar(E_Usuario ObjEU)
        {
            ObjEUR = ObjNUR.BuscarUsuarioRolPorId(ObjEU.IdUsuarios);
            Session["IdUsuario"] = ObjEU.IdUsuarios;
            if (ObjEUR.IdRol == 1)
            {
                Response.Redirect("paginas/Administrador/administrador.aspx");
            }
            if (ObjEUR.IdRol == 2)
            { 
                Response.Redirect("paginas/Cliente/cliente.aspx");
            }
            if (ObjEUR.IdRol == 3)
            {
                //Cliente
            }
        }
        #endregion

        #region Botones
        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Response.Redirect("paginas/registrar_usuario.aspx");
        }

        protected void IniciarSesion_Click(object sender, EventArgs e)
        {
            ObjEU = ObjNU.BuscarUsuarioPorUsuario(Usuario.Text);
            if(ObjEU != null)
            {
                if(ObjEU.PasswordUsuario == Contrasena.Text)
                {
                    Direccionar(ObjEU);
                }
                else
                {
                    pnErrorUsuarioContra.Visible = true;
                }
                
            }
            else
            {
                pnErrorUsuarioContra.Visible = true;
            }
        }
        #endregion
    }
}