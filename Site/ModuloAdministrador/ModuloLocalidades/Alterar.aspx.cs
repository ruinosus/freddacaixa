using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModuloBasico;
using RegraNegocio.ModuloBasico;
using Controladores.Interfaces;

public partial class ModuloAdministrador_ModuloLocalidades_Alterar : System.Web.UI.Page
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
        if (Session["LocalidadesAlterar"] != null)
        {
            Localidades localidade = (Localidades)Session["LocalidadesAlterar"];



            txtTitulo.Text = localidade.Descricao;

        }
    }

    protected void btnConfirmar_Click(object sender, EventArgs e)
    {
        try
        {
            ILocalidadesControlador controlador = LocalidadesControlador.Instance;

            Localidades localidade = new Localidades();

            localidade = (Localidades)Session["LocalidadesAlterar"];
            localidade.Descricao = txtTitulo.Text;




            

            controlador.Alterar(localidade);

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


        txtTitulo.Text = string.Empty;

    }
    #endregion
}