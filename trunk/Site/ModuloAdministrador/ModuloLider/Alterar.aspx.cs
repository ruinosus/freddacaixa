using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModuloBasico;
using RegraNegocio.ModuloBasico;
using Controladores.Interfaces;

public partial class ModuloAdministrador_ModuloLider_Alterar : System.Web.UI.Page
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
        if (Session["LiderAlterar"] != null)
        {
            Lider lider = (Lider)Session["LiderAlterar"];
            txtBairro.Text = lider.Bairro;
            txtCep.Text = lider.Cep;
            txtCidade.Text = lider.Cidade;
            txtComplemento.Text = lider.Complemento;
            txtCpf.Text = lider.Cpf;
            txtEmail.Text = lider.Email;

            cmbLocal.SelectedValue = lider.Local;
            txtLogradouro.Text = lider.Logradouro;
            txtNome.Text = lider.Nome;
            txtNumero.Text = lider.Numero;
            txtObs.Text = lider.Obs;
            txtRg.Text = lider.Rg;
            txtTelefone1.Text = lider.Telefone1;
            txtTelefone2.Text = lider.Telefone2;
           

        }
    }

    protected void btnConfirmar_Click(object sender, EventArgs e)
    {
        try
        {
            ILiderControlador controlador = LiderControlador.Instance;

            Lider lider = new Lider();

            lider = (Lider)Session["LiderAlterar"];
           

            lider.Bairro = txtBairro.Text;
            lider.Cep = txtCep.Text;
            lider.Cidade = txtCidade.Text;
            lider.Complemento = txtComplemento.Text;
            lider.Cpf = txtCpf.Text;
            lider.Email = txtEmail.Text;
            lider.Estado = "PE";
            lider.Local = cmbLocal.SelectedValue;
            lider.Logradouro = txtLogradouro.Text;
            lider.Nome = txtNome.Text;
            lider.Numero = txtNumero.Text;
            lider.Obs = txtObs.Text;
            lider.Rg = txtRg.Text;
            lider.Telefone1 = txtTelefone1.Text;
            lider.Telefone2 = txtTelefone2.Text;


            controlador.Alterar(lider);

            cvaAvisoDeInformacao.ErrorMessage = SiteConstantes.LIDER_ALTERADO;
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

        txtBairro.Text = string.Empty;
        txtCep.Text = string.Empty;
        txtCidade.Text = string.Empty;
        txtComplemento.Text = string.Empty;
        txtCpf.Text = string.Empty;
        txtEmail.Text = string.Empty;

        cmbLocal.SelectedValue = string.Empty;
        txtLogradouro.Text = string.Empty;
        txtNome.Text = string.Empty;
        txtNumero.Text = string.Empty;
        txtObs.Text = string.Empty;
        txtRg.Text = string.Empty;
        txtTelefone1.Text = string.Empty;
        txtTelefone2.Text = string.Empty;


    }
    #endregion
}