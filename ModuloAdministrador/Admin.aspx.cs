using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controladores.Interfaces;
using ModuloBasico;

public partial class ModuloAdministrador_Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["UsuarioLogado"] != null)
        {
            cvaAvisoDeInformacao.ErrorMessage = "Para utilizar o sistema basta verificar a opção desejada no menu logo acima";
            cvaAvisoDeInformacao.IsValid = false;
        }
    }

    


    
    
}
