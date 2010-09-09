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

public partial class ModuloAdministrador_ModuloGaleria_IncluirGaleria : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnConfirmar_Click(object sender, EventArgs e)
    {
        try
        {
            if (fileUpEx.HasFile)
            {
                string filepath = fileUpEx.PostedFile.FileName;

                IGaleriaControlador controlador = GaleriaControlador.Instance;
                Galeria galeria = new Galeria();

                galeria.Titulo = txtTitulo.Text;
                galeria.Legenda = txtLegenda.Text;

                controlador.Incluir(galeria);
                string pastaUrl = SiteConstantes.RecuperarNomePastaGaleria(Server.MapPath(".\\"), galeria.ID);
                pastaUrl = SiteConstantes.RecuperarPasta(pastaUrl);
                galeria.ImagemUrl = pastaUrl + filepath;
                fileUpEx.PostedFile.SaveAs(galeria.ImagemUrl);

                controlador.Alterar(galeria);
                
                cvaAvisoDeInformacao.ErrorMessage = SiteConstantes.GALERIA_INCLUIDA;
                cvaAvisoDeInformacao.IsValid = false;


            }
            else
                throw new Exception("Escolha uma imagem para a galeria.");
        }
        catch (Exception exe)
        {

            cvaAvisoDeErro.IsValid = false;
            cvaAvisoDeErro.ErrorMessage = exe.Message;
        }
    }
}