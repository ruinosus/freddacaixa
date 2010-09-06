using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Configuration;
using ModuloBasico;
using Controladores.Interfaces;



public partial class Index : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

        //try
        {
            IIndexControlador controlador = IndexControlador.Instance;


            gridIndex.DataSource = controlador.Consultar();
            gridIndex.DataBind();
        }
        //catch (Exception exe)
        //{
            
         
        //}
       
    }

}
