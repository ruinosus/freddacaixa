using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModuloBasico;
using Controladores.Interfaces;
using RegraNegocio.ModuloBasico;

public partial class ModuloAdministrador_ModuloPerfil_Consultar : System.Web.UI.Page
{
    #region Atributos
    private bool selecionado;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        ClasseAuxiliar.ValidarUsuarioLogado();
        // ClasseAuxiliar.ValidarUsuarioLogado(true);
        PerfilSelecionar1.OnSelect += new EventHandler(PerfilSelecionar1_OnSelect);
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
    protected void PerfilSelecionar1_OnSelect(object sender, EventArgs e)
    {
        int idPerfil = PerfilSelecionar1.IdPerfil;

        if (idPerfil != 0)
        {
            selecionado = true;

        }
        HabilitarBotoes();
    }
    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        try
        {
            IPerfilControlador processo = PerfilControlador.Instance;
            Perfil perfil = new Perfil();
            perfil.ID = PerfilSelecionar1.IdPerfil;


            Session.Add("PerfilAlterar", processo.Consultar(perfil, TipoPesquisa.E)[0]);
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
            IPerfilControlador processo = PerfilControlador.Instance;
            Perfil perfil = new Perfil();
            perfil.ID = PerfilSelecionar1.IdPerfil;

            processo.Excluir(perfil);
            cvaAvisoDeInformacao.ErrorMessage = SiteConstantes.INDEX_EXCLUIDO;
            cvaAvisoDeInformacao.IsValid = false;
            PerfilSelecionar1.Consultar();
            selecionado = false;
            HabilitarBotoes();
        }
        catch (Exception ex)
        {

            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;
        }
    }

    
}