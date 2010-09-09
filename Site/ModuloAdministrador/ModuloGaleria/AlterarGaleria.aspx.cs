using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModuloBasico;
using RegraNegocio.ModuloBasico;
using Controladores.Interfaces;

public partial class ModuloAdministrador_ModuloGaleria_AlterarGaleria : System.Web.UI.Page
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
        if (Session["GaleriaAlterar"] != null)
        {
            Galeria galeria = (Galeria)Session["GaleriaAlterar"];



            txtLegenda.Text = galeria.Legenda;
            txtTitulo.Text = galeria.Titulo;

        }
    }

    protected void btnConfirmar_Click(object sender, EventArgs e)
    {
        try
        {
            IGaleriaControlador controlador = GaleriaControlador.Instance;

            Galeria galeria = new Galeria();

            galeria = (Galeria)Session["GaleriaAlterar"];
            galeria.Titulo = txtTitulo.Text;

            galeria.Legenda = txtLegenda.Text;


            

            controlador.Alterar(galeria);

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