using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RegraNegocio.ModuloBasico;
using ModuloBasico;
using Controladores.Interfaces;

public partial class ModuloAdministrador_ModuloLocalidades_LocalidadesSelecionar : System.Web.UI.UserControl, System.Web.UI.IPostBackEventHandler
{
    #region Atributos

    private int idLocalidades;
    private List<Localidades> localidadeList;
    private bool check = false;


    #endregion

    #region Propriedades
    public int IdLocalidades
    {
        get
        {
            if (Session["idLocalidades"] != null)
                idLocalidades = Convert.ToInt32(Session["idLocalidades"]);

            return idLocalidades;
        }
        set
        {
            Session.Add("idLocalidades", value);
        }
    }

    public List<Localidades> LocalidadesList
    {
        get
        {
            if (Session["LocalidadesList"] != null)
                localidadeList = (List<Localidades>)Session["LocalidadesList"];

            return localidadeList;
        }
        set
        {
            Session.Add("LocalidadesList", value);
        }
    }
    #endregion

    #region Eventos

    public event EventHandler OnSelect;

    #endregion

    #region IPostBackEventHandler Members

    void IPostBackEventHandler.RaisePostBackEvent(string eventArgument)
    {
        IdLocalidades = Convert.ToInt32(eventArgument);

        // Verifica se existe algum Evento relacionado
        if (OnSelect != null)
        {

            OnSelect.Invoke(this, new EventArgs());
        }
    }

    #endregion

    /// <summary>
    /// Retorna o JavaScript necessário para invocar o evento OnSelect
    /// </summary>
    /// <param name="idLocalidades">O ID do ProdutoVO que será passado como parâmetro para o evento</param>
    /// <returns>O JavaScript</returns>
    protected string GetOnSelectEvent(object idLocalidades)
    {
        if (OnSelect != null && idLocalidades != null)
        {
            PostBackOptions options = new PostBackOptions(this);

            options.Argument = idLocalidades.ToString();

            string postBackReference = Page.ClientScript.GetPostBackEventReference(options);

            return "checkOnlyOne(this,'idLocalidades');" + postBackReference + ";";
        }

        return "checkOnlyOne(this,'idLocalidades');";
    }

    #region Métodos Privados
    /// <summary>
    /// Método para exibir o gridView com valores em branco.
    /// </summary>
    private void PreencherGridVazio()
    {
        LocalidadesList = new List<Localidades>();

        Localidades LocalidadesInicial = new Localidades();

        LocalidadesList.Add(LocalidadesInicial);

        GrdLocalidades.DataSource = LocalidadesList;
        GrdLocalidades.DataBind();

        foreach (TableCell cell in GrdLocalidades.Rows[0].Cells)
        {
            cell.Text = "&nbsp;";
        }
    }

    private void ClearSession()
    {
        Session.Remove("idLocalidades");
        Session.Remove("LocalidadesList");
    }

    #endregion

    #region Métodos Públicos
    public void Consultar()
    {
        try
        {
            LocalidadesList = new List<Localidades>();
           
            if (!string.IsNullOrEmpty(txtTitulo.Text.Trim()))
            {
                ILocalidadesControlador controlador = LocalidadesControlador.Instance;
                Localidades localidade = new Localidades();
                localidade.Descricao = txtTitulo.Text.Trim();              


                LocalidadesList = controlador.Consultar(localidade, TipoPesquisa.E);

                GrdLocalidades.DataSource = LocalidadesList;
                GrdLocalidades.DataBind();
            }
            else
            {
                ILocalidadesControlador controlador = LocalidadesControlador.Instance;




                LocalidadesList = controlador.Consultar();


                GrdLocalidades.DataSource = LocalidadesList;
                GrdLocalidades.DataBind();
            }
        }
        catch (Exception ex)
        {
            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;
        }

    }

    //public StatusLocalidades GetStatusLocalidades(int id)
    //{
    //    StatusLocalidades status = StatusLocalidades.NaoAlterar;
    //    foreach (Localidades post in LocalidadesList)
    //    {
    //        if (post.ID == id)
    //            status = post.StatusLocalidades;
    //    }

    //    return status;
    //}
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        //ClasseAuxiliar.ValidarUsuarioLogado(true);
        if (!IsPostBack)
        {
           // ClasseAuxiliar.CarregarComboEnum<TipoLocalidades>(ddlTipoLocalidades);
            //PreencherGridVazio();
            Consultar();
        }
    }

    protected void grdLocalidades_RowCreated(object sender, GridViewRowEventArgs e)
    {
        foreach (TableCell cell in e.Row.Cells)
        {
            Control control = cell.FindControl("idLocalidades");

            if (check && control != null && control is RadioButton)
            {
                ((RadioButton)control).Checked = check;
            }
        }
    }

    protected void grdLocalidades_PreRender(object sender, EventArgs e)
    {
        if (LocalidadesList == null || LocalidadesList.Count == 0)
        {
            PreencherGridVazio();
        }
    }

    protected void grdLocalidades_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GrdLocalidades.DataSource = LocalidadesList;
        if (GrdLocalidades.DataSource != null)
        {
            GrdLocalidades.PageIndex = e.NewPageIndex;
            GrdLocalidades.DataBind();
        }
    }

    protected void btnPesquisar_OnClick(object sender, EventArgs e)
    {
        Consultar();
    }
}