using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RegraNegocio.ModuloBasico;
using ModuloBasico;
using Controladores.Interfaces;

public partial class ModuloAdministrador_ModuloIndex_IndexSelecionar : System.Web.UI.UserControl, System.Web.UI.IPostBackEventHandler
{
    #region Atributos

    private int idIndex;
    private List<Index> indexList;
    private bool check = false;


    #endregion

    #region Propriedades
    public int IdIndex
    {
        get
        {
            if (Session["idIndex"] != null)
                idIndex = Convert.ToInt32(Session["idIndex"]);

            return idIndex;
        }
        set
        {
            Session.Add("idIndex", value);
        }
    }

    public List<Index> IndexList
    {
        get
        {
            if (Session["IndexList"] != null)
                indexList = (List<Index>)Session["IndexList"];

            return indexList;
        }
        set
        {
            Session.Add("IndexList", value);
        }
    }
    #endregion

    #region Eventos

    public event EventHandler OnSelect;

    #endregion

    #region IPostBackEventHandler Members

    void IPostBackEventHandler.RaisePostBackEvent(string eventArgument)
    {
        IdIndex = Convert.ToInt32(eventArgument);

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
    /// <param name="idIndex">O ID do ProdutoVO que será passado como parâmetro para o evento</param>
    /// <returns>O JavaScript</returns>
    protected string GetOnSelectEvent(object idIndex)
    {
        if (OnSelect != null && idIndex != null)
        {
            PostBackOptions options = new PostBackOptions(this);

            options.Argument = idIndex.ToString();

            string postBackReference = Page.ClientScript.GetPostBackEventReference(options);

            return "checkOnlyOne(this,'idIndex');" + postBackReference + ";";
        }

        return "checkOnlyOne(this,'idIndex');";
    }

    #region Métodos Privados
    /// <summary>
    /// Método para exibir o gridView com valores em branco.
    /// </summary>
    private void PreencherGridVazio()
    {
        IndexList = new List<Index>();

        Index IndexInicial = new Index();

        IndexList.Add(IndexInicial);

        GrdIndex.DataSource = IndexList;
        GrdIndex.DataBind();

        foreach (TableCell cell in GrdIndex.Rows[0].Cells)
        {
            cell.Text = "&nbsp;";
        }
    }

    private void ClearSession()
    {
        Session.Remove("idIndex");
        Session.Remove("IndexList");
    }

    #endregion

    #region Métodos Públicos
    public void Consultar()
    {
        try
        {
            IndexList = new List<Index>();
           
            if (!string.IsNullOrEmpty(txtTitulo.Text.Trim()))
            {
                IIndexControlador controlador = IndexControlador.Instance;
                Index index = new Index();
                index.Titulo = txtTitulo.Text.Trim();              


                IndexList = controlador.Consultar(index, TipoPesquisa.E);

                GrdIndex.DataSource = IndexList;
                GrdIndex.DataBind();
            }
            else
            {
                IIndexControlador controlador = IndexControlador.Instance;




                IndexList = controlador.Consultar();


                GrdIndex.DataSource = IndexList;
                GrdIndex.DataBind();
            }
        }
        catch (Exception ex)
        {
            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;
        }

    }

    //public StatusIndex GetStatusIndex(int id)
    //{
    //    StatusIndex status = StatusIndex.NaoAlterar;
    //    foreach (Index post in IndexList)
    //    {
    //        if (post.ID == id)
    //            status = post.StatusIndex;
    //    }

    //    return status;
    //}
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        //ClasseAuxiliar.ValidarUsuarioLogado(true);
        if (!IsPostBack)
        {
           // ClasseAuxiliar.CarregarComboEnum<TipoIndex>(ddlTipoIndex);
            //PreencherGridVazio();
            Consultar();
        }
    }

    protected void grdIndex_RowCreated(object sender, GridViewRowEventArgs e)
    {
        foreach (TableCell cell in e.Row.Cells)
        {
            Control control = cell.FindControl("idIndex");

            if (check && control != null && control is RadioButton)
            {
                ((RadioButton)control).Checked = check;
            }
        }
    }

    protected void grdIndex_PreRender(object sender, EventArgs e)
    {
        if (IndexList == null || IndexList.Count == 0)
        {
            PreencherGridVazio();
        }
    }

    protected void grdIndex_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GrdIndex.DataSource = IndexList;
        if (GrdIndex.DataSource != null)
        {
            GrdIndex.PageIndex = e.NewPageIndex;
            GrdIndex.DataBind();
        }
    }

    protected void btnPesquisar_OnClick(object sender, EventArgs e)
    {
        Consultar();
    }
}