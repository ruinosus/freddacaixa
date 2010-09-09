using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using Controladores.Interfaces;
using RegraNegocio.ModuloBasico;
using ModuloBasico;

public partial class ModuloAdministrador_ModuloFoto_IncluirFoto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnConfirmar_Click(object sender, EventArgs e)
    {
        try
        {
            if (Session["GaleriaIncluirFoto"] == null)
                Response.Redirect(SiteConstantes.PAGINA_PRINCIPAL);

            Galeria galeria = (Galeria)Session["GaleriaIncluirFoto"];
            if (fileUpEx.HasFile)
            {
                string filepath = fileUpEx.PostedFile.FileName;

                IFotoControlador controlador = FotoControlador.Instance;
                Foto foto = new Foto();
                foto.GaleriaID = galeria.ID;
                foto.Titulo = txtTitulo.Text;
                foto.Legenda = txtLegenda.Text;

                controlador.Incluir(foto);
                string pastaUrl = SiteConstantes.RecuperarNomePastaFoto(Server.MapPath(".\\"), foto.ID,foto.GaleriaID);
                pastaUrl = SiteConstantes.RecuperarPasta(pastaUrl);
                foto.ImagemUrl = pastaUrl + filepath;
                fileUpEx.PostedFile.SaveAs(foto.ImagemUrl);

                controlador.Alterar(foto);
                
                cvaAvisoDeInformacao.ErrorMessage = SiteConstantes.FOTO_INCLUIDA;
                cvaAvisoDeInformacao.IsValid = false;


            }
            else
                throw new Exception("Escolha uma imagem para a foto.");
        }
        catch (Exception exe)
        {

            cvaAvisoDeErro.IsValid = false;
            cvaAvisoDeErro.ErrorMessage = exe.Message;
        }
    }
}