using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Entidades;
using Negocios;

namespace TainEns.paginas.Administrador
{
    public partial class calificaciones : System.Web.UI.Page
    {
        E_Criticas ObjEC = new E_Criticas();
        N_Critica ObjNC = new N_Critica();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Iniciar();
            }
        }

        protected void Iniciar()
        {
            List<E_Criticas> LstC = ObjNC.LstCriticas();
            List<E_Usuario> LstU = new List<E_Usuario>();
            E_Usuario ObjEU = new E_Usuario();
            float chido = 0;
            float mal = 0;
            int total = LstC.Count;
            foreach(E_Criticas C in LstC)
            {
                ObjEU = new N_Usuario().BuscarUsuarioPorId(C.IdUsuario);
                ObjEU.ApellidoUsuario = C.Comentario;
                LstU.Add(ObjEU);
                if(C.ValorCritica == 1)
                {
                    chido++;
                }
                if (C.ValorCritica == 0)
                {
                    mal++;
                }
            }
            chido = (chido / total) * 100;
            mal = (mal / total) * 100;
            lblChido.Text = chido + "%";
            lblMal.Text = mal + "%";
            pVerde.Style.Add("width", chido + "%");
            pRojo.Style.Add("width", mal + "%");
            grvCriticas.DataSource = LstU;
            grvCriticas.DataBind();
        }

        protected void Tabla()
        {

        }
    }
}