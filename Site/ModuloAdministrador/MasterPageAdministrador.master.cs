using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModuloBasico;
using Controladores.Interfaces;
using RegraNegocio.ModuloBasico;

public partial class ModuloAdministrador_MasterPageAdministrador : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CarregarLogin();
    }

    private void CarregarLogin()
    {
     
        if (Session["UsuarioLogado"] == null)
        {
            pnlLogar.Visible = true;
            WebDataMenuPrincipal.Visible = false;
        }
        else
        {           
            WebDataMenuPrincipal.Visible = true;
            pnlLogar.Visible = false;
        }

    }



    protected void btnConfirmar_Click(object sender, EventArgs e)
    {
        IUsuarioControlador processo = UsuarioControlador.Instance;
        Usuario usuario = new Usuario();


        try
        {
            if (string.IsNullOrEmpty(txtLogin.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                throw new Exception(SiteConstantes.USUARIO_LOGIN_OU_SENHA_INVALIDOS);
            }

            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;

            List<Usuario> usuarioList = processo.Consultar(usuario, TipoPesquisa.E);

            if (usuarioList.Count > 0)
            {
                Session.Add("UsuarioLogado", usuarioList[0]);

                CarregarLogin();
            }
            else
                throw new Exception(SiteConstantes.USUARIO_LOGIN_OU_SENHA_INVALIDOS);
        }

        catch (Exception ex)
        {
            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;
        }

    }

    protected void WebDataMenuPrincipal_ItemClick(object sender, Infragistics.Web.UI.NavigationControls.DataMenuItemEventArgs e)
    {
        if (e.Item.Value.Equals("Deslogar"))
        {
            Session.Remove("UsuarioLogado");

            CarregarLogin();
            ClasseAuxiliar.ValidarUsuarioLogado();
        }
    }
}
