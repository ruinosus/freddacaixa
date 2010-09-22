using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controladores.Interfaces;
using ModuloBasico;
using RegraNegocio.ModuloBasico;

public partial class ModuloAdministrador_ModuloVideo_Incluir : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClasseAuxiliar.ValidarUsuarioLogado();
    }

    protected void btnConfirmar_Click(object sender, EventArgs e)
    {
        try
        {
            IVideoControlador controlador = VideoControlador.Instance;
            Video video = new Video();

            video.Titulo = txtTitulo.Text;
            video.SubTitulo = txtSubTitulo.Text;
            video.Corpo = txtCorpo.Text;

            controlador.Incluir(video);
            cvaAvisoDeInformacao.ErrorMessage = SiteConstantes.INDEX_INCLUIDO;
            cvaAvisoDeInformacao.IsValid = false;
        }
        catch (Exception ex)
        {
            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;

        }
    }
}
