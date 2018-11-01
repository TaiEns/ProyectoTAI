﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TainEns
{
    public partial class index : System.Web.UI.Page
    {
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
        #endregion
    }
}