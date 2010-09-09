using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controladores.Interfaces;

public partial class Perfil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {
            IPerfilControlador controlador = PerfilControlador.Instance;


            gridIndex.DataSource = controlador.Consultar();
            gridIndex.DataBind();

           


        }
        catch (Exception exe)
        {


        }
    }
}
