using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controladores.Interfaces;
using ModuloBasico;

public partial class ModuloAdministrador_ModuloProposta_Incluir : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClasseAuxiliar.ValidarUsuarioLogado();
    }

    protected void btnConfirmar_Click(object sender, EventArgs e)
    {
        try
        {
            IPropostaControlador controlador = PropostaControlador.Instance;
            Proposta proposta = new Proposta();

            proposta.Titulo = txtTitulo.Text;
            proposta.SubTitulo = txtSubTitulo.Text;
            proposta.Corpo = WebHtmlEditorCorpo.Text;

            controlador.Incluir(proposta);
            cvaAvisoDeInformacao.ErrorMessage = SiteConstantes.PROPOSTA_INCLUIDA;
            cvaAvisoDeInformacao.IsValid = false;
        }
        catch (Exception ex)
        {
            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;

        }
    }
}
