using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controladores.Interfaces;

public partial class Projetos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        IPropostaControlador controlador = PropostaControlador.Instance;


        gridProposta.DataSource = controlador.Consultar();
        gridProposta.DataBind();
    }
}
