using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RegraNegocio.ModuloBasico;
using Controladores.Interfaces;

public partial class Fotos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["GaleriaId"] != null)
        {
            try
            {
                int GaleriaId = Convert.ToInt32(Request.QueryString["GaleriaId"].ToString());
                Foto foto = new Foto();
                foto.GaleriaID = GaleriaId;

                IFotoControlador controlador = FotoControlador.Instance;
                List<Foto> resultado = controlador.Consultar(foto, ModuloBasico.TipoPesquisa.E);

                foreach (Foto   f in resultado)
                {
                    f.ImagemUrl = f.ImagemUrl.Replace("\\", "/");
                    int index = f.ImagemUrl.IndexOf("/ModuloAdministrador");
                    f.ImagemUrl = f.ImagemUrl.Substring(index, f.ImagemUrl.Length - index);
                    f.ImagemUrl = "~" + f.ImagemUrl;

                }
             
                gridFotos1.DataSource = resultado;
                gridFotos1.DataBind();
            }
            catch (Exception)
            {


            }

        }
    }
}
