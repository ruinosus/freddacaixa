using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controladores.Interfaces;
using ModuloBasico;
using RegraNegocio.ModuloBasico;

public partial class ModuloAdministrador_ModuloPerfil_Incluir : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClasseAuxiliar.ValidarUsuarioLogado();
    }

    protected void btnConfirmar_Click(object sender, EventArgs e)
    {
        try
        {
            IPerfilControlador controlador = PerfilControlador.Instance;
            Perfil perfil = new Perfil();

            perfil.Titulo = txtTitulo.Text;
            perfil.SubTitulo = txtSubTitulo.Text;
            perfil.Corpo = WebHtmlEditorCorpo.Text;

            controlador.Incluir(perfil);
            cvaAvisoDeInformacao.ErrorMessage = SiteConstantes.INDEX_INCLUIDO;
            cvaAvisoDeInformacao.IsValid = false;
        }
        catch (Exception ex)
        {
            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;

        }
    }
}
