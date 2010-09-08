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
using System.IO;
using Infragistics.Web.UI.ListControls;
using RegraNegocio.ModuloBasico;



public partial class Index : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

        //try
        {
            IIndexControlador controlador = IndexControlador.Instance;


            gridIndex.DataSource = controlador.Consultar();
            gridIndex.DataBind();

            IGaleriaControlador controladoGaleria = GaleriaControlador.Instance;
            List<Galeria> galerias = controladoGaleria.Consultar();

            foreach (Galeria galeria in galerias)
            {
                galeria.ImagemUrl= galeria.ImagemUrl.Replace("\\", "/");
                int index = galeria.ImagemUrl.IndexOf("/Modulo");
                galeria.ImagemUrl = galeria.ImagemUrl.Substring(index, galeria.ImagemUrl.Length-index);
                galeria.ImagemUrl = "~" + galeria.ImagemUrl;

            }
            WebImageViewer1.DataSource = galerias;
            WebImageViewer1.ImageItemBinding.ImageUrlField = "ImagemUrl";
            WebImageViewer1.DataBind();




            //DirectoryInfo[] diretorios = SiteConstantes.RecuperarDiretorioImagensGaleria();

            //if (diretorios != null)
            //{
                

            //    List<string> resultado = SiteConstantes.RecuperarImagensGaleria(diretorios);
               
            //    WebImageViewer1.DataSource = resultado;
            //    WebImageViewer1.DataBind();
            //}
        }
        //catch (Exception exe)
        //{
            
         
        //}



       
    }


   


    protected void WebImageViewer1_SelectedIndexChanged(object sender, ImageItemEventArgs e)
    {
        string imagemUrl = e.Item.ImageUrl;
        int indexInicial = imagemUrl.IndexOf("GALERIA_");
        
        imagemUrl = imagemUrl.Substring(indexInicial,imagemUrl.Length-indexInicial);
        indexInicial = imagemUrl.IndexOf("_");
        imagemUrl = imagemUrl.Substring(indexInicial,imagemUrl.Length-indexInicial);
        int indexFinal = imagemUrl.IndexOf("/");
        imagemUrl = imagemUrl.Substring(0,indexFinal);

        imagemUrl = imagemUrl.Replace("_", "");

        Response.Redirect("~/Fotos.aspx?GaleriaId=" + imagemUrl);

    }
}
