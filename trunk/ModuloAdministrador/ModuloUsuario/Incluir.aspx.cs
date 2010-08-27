using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controladores.Interfaces;
using ModuloBasico;


public partial class ModuloAdministrador_ModuloUsuario_Incluir : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClasseAuxiliar.ValidarUsuarioLogado();
    }
    protected void btnConfirmar_Click(object sender, EventArgs e)
    {
        try
        {
            IUsuarioControlador controlador = UsuarioControlador.Instance;
            Usuario usuario = new Usuario();
           
            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;
          
            controlador.Incluir(usuario); 
            cvaAvisoDeInformacao.ErrorMessage = SiteConstantes.USUARIO_INCLUIDO;
            cvaAvisoDeInformacao.IsValid = false;
        }
        catch (Exception ex)
        {
            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;

        }
    }
}
