using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controladores.Interfaces;
using ModuloBasico;
using RegraNegocio.ModuloBasico;

public partial class ModuloAdministrador_ModuloLider_Incluir : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClasseAuxiliar.ValidarUsuarioLogado();
    }

    protected void btnConfirmar_Click(object sender, EventArgs e)
    {
        try
        {
            ILiderControlador controlador = LiderControlador.Instance;
            Lider lider = new Lider();

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
            controlador.Incluir(lider);
            cvaAvisoDeInformacao.ErrorMessage = SiteConstantes.LIDER_INCLUIDO;
            cvaAvisoDeInformacao.IsValid = false;
        }
        catch (Exception ex)
        {
            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;

        }
    }
}
