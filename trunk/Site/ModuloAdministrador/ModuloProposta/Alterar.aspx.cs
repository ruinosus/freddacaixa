using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModuloBasico;
using RegraNegocio.ModuloBasico;
using Controladores.Interfaces;

public partial class ModuloAdministrador_ModuloProposta_Alterar : System.Web.UI.Page
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
        if (Session["PropostaAlterar"] != null)
        {
            Proposta proposta = (Proposta)Session["PropostaAlterar"];


            WebHtmlEditorCorpo.Text = proposta.Corpo;

            txtSubTitulo.Text = proposta.SubTitulo;
            txtTitulo.Text = proposta.Titulo;

        }
    }

    protected void btnConfirmar_Click(object sender, EventArgs e)
    {
        try
        {
            IPropostaControlador controlador = PropostaControlador.Instance;

            Proposta proposta = new Proposta();

            proposta = (Proposta)Session["PropostaAlterar"];
            proposta.Titulo = txtTitulo.Text;

            proposta.Corpo = WebHtmlEditorCorpo.Text;


            

            controlador.Alterar(proposta);

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