using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controladores.Interfaces;
using ModuloBasico;

public partial class ModuloAdministrador_ModuloIndex_Incluir : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClasseAuxiliar.ValidarUsuarioLogado();
    }

    protected void btnConfirmar_Click(object sender, EventArgs e)
    {
        try
        {
            IIndexControlador controlador = IndexControlador.Instance;
            Index index = new Index();

            index.Titulo = txtTitulo.Text;
            index.SubTitulo = txtSubTitulo.Text;
            index.Corpo = WebHtmlEditorCorpo.Text;

            controlador.Incluir(index);
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
