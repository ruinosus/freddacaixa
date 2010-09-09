using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModuloBasico;
using RegraNegocio.ModuloBasico;
using Controladores.Interfaces;

public partial class ModuloAdministrador_ModuloFoto_AlterarFoto : System.Web.UI.Page
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
        if (Session["FotoAlterar"] != null)
        {
            Foto foto = (Foto)Session["FotoAlterar"];



            txtLegenda.Text = foto.Legenda;
            txtTitulo.Text = foto.Titulo;

        }
    }

    protected void btnConfirmar_Click(object sender, EventArgs e)
    {
        try
        {
            IFotoControlador controlador = FotoControlador.Instance;

            Foto foto = new Foto();

            foto = (Foto)Session["FotoAlterar"];
            foto.Titulo = txtTitulo.Text;

            foto.Legenda = txtLegenda.Text;


            

            controlador.Alterar(foto);

            cvaAvisoDeInformacao.ErrorMessage = SiteConstantes.GALERIA_ALTERADA;
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
        txtLegenda.Text = string.Empty;

        txtTitulo.Text = string.Empty;

    }
    #endregion
}