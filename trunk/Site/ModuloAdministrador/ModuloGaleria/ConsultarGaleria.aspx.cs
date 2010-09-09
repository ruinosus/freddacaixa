﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModuloBasico;
using Controladores.Interfaces;
using RegraNegocio.ModuloBasico;

public partial class ModuloAdministrador_ModuloGaleria_ConsultarGaleria : System.Web.UI.Page
{
    #region Atributos
    private bool selecionado;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        ClasseAuxiliar.ValidarUsuarioLogado();
        // ClasseAuxiliar.ValidarUsuarioLogado(true);
        GaleriaSelecionar1.OnSelect += new EventHandler(GaleriaSelecionar1_OnSelect);
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
    protected void GaleriaSelecionar1_OnSelect(object sender, EventArgs e)
    {
        int idGaleria = GaleriaSelecionar1.IdGaleria;

        if (idGaleria != 0)
        {
            selecionado = true;

        }
        HabilitarBotoes();
    }
    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        try
        {
            IGaleriaControlador processo = GaleriaControlador.Instance;
            Galeria galeria = new Galeria();
            galeria.ID = GaleriaSelecionar1.IdGaleria;


            Session.Add("GaleriaAlterar", processo.Consultar(galeria, TipoPesquisa.E)[0]);
            Response.Redirect("AlterarGaleria.aspx", false);
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
            IGaleriaControlador processo = GaleriaControlador.Instance;
            Galeria galeria = new Galeria();
            galeria.ID = GaleriaSelecionar1.IdGaleria;

            processo.Excluir(galeria);
            cvaAvisoDeInformacao.ErrorMessage = SiteConstantes.GALERIA_EXCLUIDA;
            cvaAvisoDeInformacao.IsValid = false;
            GaleriaSelecionar1.Consultar();
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
            IGaleriaControlador processo = GaleriaControlador.Instance;
            Galeria galeria = new Galeria();
            galeria.ID = GaleriaSelecionar1.IdGaleria;


            Session.Add("GaleriaIncluirImagem", processo.Consultar(galeria, TipoPesquisa.E)[0]);
            Response.Redirect("~/ModuloGaleria/ConsultarGaleria.aspx", false);
        }
        catch (Exception ex)
        {

            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;
        }
    }
}