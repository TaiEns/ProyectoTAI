using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Entidades;
using Negocios;

namespace TainEns.paginas.Olvide_Contrasena
{
    public partial class olvide_contrasena : System.Web.UI.Page
    {
        E_Email ObjEE = new E_Email();
        N_Email ObjNE = new N_Email();
        E_Usuario ObjEU = new E_Usuario();
        N_Usuario ObjNU = new N_Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Inicio();
            }   
        }

        #region Metodos
        public string CodigoRecuperacion()
        {
            string[] LetrasMay = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] LetrasMin = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] Numeros = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            string codigo = "";
            Random rand1 = new Random();
            Random rand2 = new Random();
            int x;

            for (int i = 0; i < 6; i++)
            {
                x = rand1.Next(0, 2);
                if (x == 0)
                {
                    codigo = codigo + LetrasMay[rand2.Next(0, 25)];
                }
                else
                {
                    if (x == 1)
                    {
                        codigo = codigo + LetrasMin[rand2.Next(0, 25)];
                    }
                    else
                    {
                        codigo = codigo + Numeros[rand2.Next(0, 10)];
                    }
                }
            }

            return codigo;
        }
        protected void Inicio()
        {
            ApagarComponentes();
            pFase1.Visible = true;
        }
        protected void ApagarComponentes()
        {
            pFase1.Visible = false;
            pFase2.Visible = false;
            pFase3.Visible = false;
        }

        #endregion

        #region Botones
        protected void btnEnviarCodigo_Click(object sender, EventArgs e)
        {
            ObjEU = ObjNU.BuscarUsuarioPorEmail(inputEmail.Text);
            if (ObjEU != null)
            {
                ObjEE.From = "santiago.valdovinos@uabc.edu.mx";
                ObjEE.Password = "papalotes15";
                ObjEE.To = inputEmail.Text;
                ObjEE.Msn = CodigoRecuperacion();
                Session["UsuarioRecuperacion"] = ObjEU;
                Session["Mensaje"] = ObjEE;
                ObjNE.EnviarCorreo(ObjEE);
                ApagarComponentes();
                pFase2.Visible = true;
            }
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            ObjEE = (E_Email)Session["Mensaje"];
            if (tbCodigo.Text == ObjEE.Msn)
            {
                ApagarComponentes();
                pFase3.Visible = true;
            }
        }

        protected void btnCambiar_Click(object sender, EventArgs e)
        {
            if (inputPassword.Text == tbConfirmarContra.Text)
            {
                ObjEU = (E_Usuario)Session["UsuarioRecuperacion"];
                ObjEU.PasswordUsuario = inputPassword.Text;
                string msn = ObjNU.ModoficaUsuario(ObjEU);
                Response.Redirect("../../index.aspx");
            }
        }
        #endregion

    }
}