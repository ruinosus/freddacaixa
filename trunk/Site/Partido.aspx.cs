using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controladores.Interfaces;

public partial class Partido : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            IPartidoControlador controlador = PartidoControlador.Instance;


            gridIndex.DataSource = controlador.Consultar();
            gridIndex.DataBind();




        }
        catch (Exception exe)
        {


        }
    }
}
