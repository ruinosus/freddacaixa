using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModuloBasico;
using Controladores.Interfaces;
using RegraNegocio.ModuloBasico;

public partial class ModuloAdministrador_ModuloFoto_ConsultarFoto : System.Web.UI.Page
{
    #region Atributos
    private bool selecionado;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        ClasseAuxiliar.ValidarUsuarioLogado();
        // ClasseAuxiliar.ValidarUsuarioLogado(true);
        FotoSelecionar1.OnSelect += new EventHandler(FotoSelecionar1_OnSelect);
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
    protected void FotoSelecionar1_OnSelect(object sender, EventArgs e)
    {
        int idFoto = FotoSelecionar1.IdFoto;

        if (idFoto != 0)
        {
            selecionado = true;

        }
        HabilitarBotoes();
    }
    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        try
        {
            IFotoControlador processo = FotoControlador.Instance;
            Foto foto = new Foto();
            foto.ID = FotoSelecionar1.IdFoto;


            Session.Add("FotoAlterar", processo.Consultar(foto, TipoPesquisa.E)[0]);
            Response.Redirect("AlterarFoto.aspx", false);
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
            IFotoControlador processo = FotoControlador.Instance;
            Foto foto = new Foto();
            foto.ID = FotoSelecionar1.IdFoto;

            processo.Excluir(foto);
            cvaAvisoDeInformacao.ErrorMessage = SiteConstantes.GALERIA_EXCLUIDA;
            cvaAvisoDeInformacao.IsValid = false;
            FotoSelecionar1.Consultar();
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
            IFotoControlador processo = FotoControlador.Instance;
            Foto foto = new Foto();
            foto.ID = FotoSelecionar1.IdFoto;


            Session.Add("FotoIncluirImagem", processo.Consultar(foto, TipoPesquisa.E)[0]);
            Response.Redirect("~/ModuloFoto/ConsultarFoto.aspx", false);
        }
        catch (Exception ex)
        {

            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;
        }
    }
}