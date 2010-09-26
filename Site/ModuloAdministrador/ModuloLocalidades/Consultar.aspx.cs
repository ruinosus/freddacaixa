using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModuloBasico;
using Controladores.Interfaces;
using RegraNegocio.ModuloBasico;

public partial class ModuloAdministrador_ModuloLocalidades_Consultar : System.Web.UI.Page
{
    #region Atributos
    private bool selecionado;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        ClasseAuxiliar.ValidarUsuarioLogado();
        // ClasseAuxiliar.ValidarUsuarioLogado(true);
        LocalidadesSelecionar1.OnSelect += new EventHandler(LocalidadesSelecionar1_OnSelect);
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
    protected void LocalidadesSelecionar1_OnSelect(object sender, EventArgs e)
    {
        int idLocalidades = LocalidadesSelecionar1.IdLocalidades;

        if (idLocalidades != 0)
        {
            selecionado = true;

        }
        HabilitarBotoes();
    }
    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        try
        {
            ILocalidadesControlador processo = LocalidadesControlador.Instance;
            Localidades localidade = new Localidades();
            localidade.ID = LocalidadesSelecionar1.IdLocalidades;


            Session.Add("LocalidadesAlterar", processo.Consultar(localidade, TipoPesquisa.E)[0]);
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
            ILocalidadesControlador processo = LocalidadesControlador.Instance;
            Localidades localidade = new Localidades();
            localidade.ID = LocalidadesSelecionar1.IdLocalidades;

            processo.Excluir(localidade);
            cvaAvisoDeInformacao.ErrorMessage = SiteConstantes.INDEX_EXCLUIDO;
            cvaAvisoDeInformacao.IsValid = false;
            LocalidadesSelecionar1.Consultar();
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
            ILocalidadesControlador processo = LocalidadesControlador.Instance;
            Localidades localidade = new Localidades();
            localidade.ID = LocalidadesSelecionar1.IdLocalidades;


            Session.Add("LocalidadesIncluirImagem", processo.Consultar(localidade, TipoPesquisa.E)[0]);
            Response.Redirect("~/ModuloImagem/Consultar.aspx", false);
        }
        catch (Exception ex)
        {

            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;
        }
    }
}