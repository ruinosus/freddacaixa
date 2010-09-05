using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModuloBasico;
using Controladores.Interfaces;
using RegraNegocio.ModuloBasico;

public partial class ModuloAdministrador_ModuloProposta_Consultar : System.Web.UI.Page
{
    #region Atributos
    private bool selecionado;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        ClasseAuxiliar.ValidarUsuarioLogado();
        // ClasseAuxiliar.ValidarUsuarioLogado(true);
        PropostaSelecionar1.OnSelect += new EventHandler(PropostaSelecionar1_OnSelect);
        HabilitarBotoes();
    }


    private void HabilitarBotoes()
    {
        DesabilitarBotoes();
        btnIncluir.Enabled = true;
        if (selecionado)
        {
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
 
        }

    }

    private void DesabilitarBotoes()
    {
        btnIncluir.Enabled = false;
        btnAlterar.Enabled = false;
        btnExcluir.Enabled = false;

    }
    protected void PropostaSelecionar1_OnSelect(object sender, EventArgs e)
    {
        int idProposta = PropostaSelecionar1.IdProposta;

        if (idProposta != 0)
        {
            selecionado = true;

        }
        HabilitarBotoes();
    }
    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        try
        {
            IPropostaControlador processo = PropostaControlador.Instance;
            Proposta proposta = new Proposta();
            proposta.ID = PropostaSelecionar1.IdProposta;


            Session.Add("PropostaAlterar", processo.Consultar(proposta, TipoPesquisa.E)[0]);
            Response.Redirect("Alterar.aspx", false);
        }
        catch (Exception ex)
        {

            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;
        }
    }

    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        try
        {
            IPropostaControlador processo = PropostaControlador.Instance;
            Proposta proposta = new Proposta();
            proposta.ID = PropostaSelecionar1.IdProposta;

            processo.Excluir(proposta);
            cvaAvisoDeInformacao.ErrorMessage = SiteConstantes.INDEX_EXCLUIDO;
            cvaAvisoDeInformacao.IsValid = false;
            PropostaSelecionar1.Consultar();
            selecionado = false;
            HabilitarBotoes();
        }
        catch (Exception ex)
        {

            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;
        }
    }

    protected void btnImagem_Click(object sender, EventArgs e)
    {
        try
        {
            IPropostaControlador processo = PropostaControlador.Instance;
            Proposta proposta = new Proposta();
            proposta.ID = PropostaSelecionar1.IdProposta;


            Session.Add("PropostaIncluirImagem", processo.Consultar(proposta, TipoPesquisa.E)[0]);
            Response.Redirect("~/ModuloImagem/Consultar.aspx", false);
        }
        catch (Exception ex)
        {

            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;
        }
    }
}