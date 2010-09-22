using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModuloBasico;
using RegraNegocio.ModuloBasico;
using Controladores.Interfaces;

public partial class ModuloAdministrador_ModuloVideo_Alterar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClasseAuxiliar.ValidarUsuarioLogado();
        if (!IsPostBack)
        {

            LimparCampos();
            CarregarDados();
        }
    }




    #region Métodos Privados

    private void CarregarDados()
    {
        if (Session["VideoAlterar"] != null)
        {
            Video video = (Video)Session["VideoAlterar"];


            txtCorpo.Text = video.Corpo;

            txtSubTitulo.Text = video.SubTitulo;
            txtTitulo.Text = video.Titulo;

        }
    }

    protected void btnConfirmar_Click(object sender, EventArgs e)
    {
        try
        {
            IVideoControlador controlador = VideoControlador.Instance;

            Video video = new Video();

            video = (Video)Session["VideoAlterar"];
            video.Titulo = txtTitulo.Text;

            video.Corpo = txtCorpo.Text;


            

            controlador.Alterar(video);

            cvaAvisoDeInformacao.ErrorMessage = SiteConstantes.INDEX_ALTERADO;
            cvaAvisoDeInformacao.IsValid = false;
        }
        catch (Exception ex)
        {
            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;

        }
    }

    protected void Cancelar(object sender, EventArgs e)
    {
        Response.Redirect("Consultar.aspx", false);
    }

    protected void LimparCampos(object sender, EventArgs e)
    {
        LimparCampos();
    }

    private void LimparCampos()
    {

        txtCorpo.Text = string.Empty;
        txtTitulo.Text = string.Empty;

    }
    #endregion
}