using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModuloBasico;
using RegraNegocio.ModuloBasico;
using Controladores.Interfaces;

public partial class ModuloAdministrador_ModuloIndex_Alterar : System.Web.UI.Page
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
        if (Session["IndexAlterar"] != null)
        {
            Index index = (Index)Session["IndexAlterar"];


            WebHtmlEditorCorpo.Text = index.Corpo;

            txtSubTitulo.Text = index.SubTitulo;
            txtTitulo.Text = index.Titulo;

        }
    }

    protected void btnConfirmar_Click(object sender, EventArgs e)
    {
        try
        {
            IIndexControlador controlador = IndexControlador.Instance;

            Index index = new Index();

            index = (Index)Session["IndexAlterar"];
            index.Titulo = txtTitulo.Text;

            index.Corpo = WebHtmlEditorCorpo.Text;


            

            controlador.Alterar(index);

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

        WebHtmlEditorCorpo.Text = string.Empty;
        txtTitulo.Text = string.Empty;

    }
    #endregion
}