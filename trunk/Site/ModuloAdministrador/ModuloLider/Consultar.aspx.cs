using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModuloBasico;
using Controladores.Interfaces;
using RegraNegocio.ModuloBasico;

public partial class ModuloAdministrador_ModuloLider_Consultar : System.Web.UI.Page
{
    #region Atributos
    private bool selecionado;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        ClasseAuxiliar.ValidarUsuarioLogado();
        // ClasseAuxiliar.ValidarUsuarioLogado(true);
        LiderSelecionar1.OnSelect += new EventHandler(LiderSelecionar1_OnSelect);
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
    protected void LiderSelecionar1_OnSelect(object sender, EventArgs e)
    {
        int idLider = LiderSelecionar1.IdLider;

        if (idLider != 0)
        {
            selecionado = true;

        }
        HabilitarBotoes();
    }
    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        try
        {
            ILiderControlador processo = LiderControlador.Instance;
            Lider lider = new Lider();
            lider.ID = LiderSelecionar1.IdLider;


            Session.Add("LiderAlterar", processo.Consultar(lider, TipoPesquisa.E)[0]);
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
            ILiderControlador processo = LiderControlador.Instance;
            Lider lider = new Lider();
            lider.ID = LiderSelecionar1.IdLider;

            processo.Excluir(lider);
            cvaAvisoDeInformacao.ErrorMessage = SiteConstantes.INDEX_EXCLUIDO;
            cvaAvisoDeInformacao.IsValid = false;
            LiderSelecionar1.Consultar();
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
            ILiderControlador processo = LiderControlador.Instance;
            Lider lider = new Lider();
            lider.ID = LiderSelecionar1.IdLider;


            Session.Add("LiderIncluirImagem", processo.Consultar(lider, TipoPesquisa.E)[0]);
            Response.Redirect("~/ModuloImagem/Consultar.aspx", false);
        }
        catch (Exception ex)
        {

            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;
        }
    }
}