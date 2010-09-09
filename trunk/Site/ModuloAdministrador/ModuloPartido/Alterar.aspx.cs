using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModuloBasico;
using RegraNegocio.ModuloBasico;
using Controladores.Interfaces;

public partial class ModuloAdministrador_ModuloPartido_Alterar : System.Web.UI.Page
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
        if (Session["PartidoAlterar"] != null)
        {
            Partido partido = (Partido)Session["PartidoAlterar"];


            WebHtmlEditorCorpo.Text = partido.Corpo;

            txtSubTitulo.Text = partido.SubTitulo;
            txtTitulo.Text = partido.Titulo;

        }
    }

    protected void btnConfirmar_Click(object sender, EventArgs e)
    {
        try
        {
            IPartidoControlador controlador = PartidoControlador.Instance;

            Partido partido = new Partido();

            partido = (Partido)Session["PartidoAlterar"];
            partido.Titulo = txtTitulo.Text;

            partido.Corpo = WebHtmlEditorCorpo.Text;


            

            controlador.Alterar(partido);

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

        WebHtmlEditorCorpo.Text = string.Empty;
        txtTitulo.Text = string.Empty;

    }
    #endregion
}