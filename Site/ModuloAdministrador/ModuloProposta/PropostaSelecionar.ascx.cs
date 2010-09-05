using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RegraNegocio.ModuloBasico;
using ModuloBasico;
using Controladores.Interfaces;

public partial class ModuloAdministrador_ModuloProposta_PropostaSelecionar : System.Web.UI.UserControl, System.Web.UI.IPostBackEventHandler
{
    #region Atributos

    private int idProposta;
    private List<Proposta> propostaList;
    private bool check = false;


    #endregion

    #region Propriedades
    public int IdProposta
    {
        get
        {
            if (Session["idProposta"] != null)
                idProposta = Convert.ToInt32(Session["idProposta"]);

            return idProposta;
        }
        set
        {
            Session.Add("idProposta", value);
        }
    }

    public List<Proposta> PropostaList
    {
        get
        {
            if (Session["PropostaList"] != null)
                propostaList = (List<Proposta>)Session["PropostaList"];

            return propostaList;
        }
        set
        {
            Session.Add("PropostaList", value);
        }
    }
    #endregion

    #region Eventos

    public event EventHandler OnSelect;

    #endregion

    #region IPostBackEventHandler Members

    void IPostBackEventHandler.RaisePostBackEvent(string eventArgument)
    {
        IdProposta = Convert.ToInt32(eventArgument);

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
    /// <param name="idProposta">O ID do ProdutoVO que será passado como parâmetro para o evento</param>
    /// <returns>O JavaScript</returns>
    protected string GetOnSelectEvent(object idProposta)
    {
        if (OnSelect != null && idProposta != null)
        {
            PostBackOptions options = new PostBackOptions(this);

            options.Argument = idProposta.ToString();

            string postBackReference = Page.ClientScript.GetPostBackEventReference(options);

            return "checkOnlyOne(this,'idProposta');" + postBackReference + ";";
        }

        return "checkOnlyOne(this,'idProposta');";
    }

    #region Métodos Privados
    /// <summary>
    /// Método para exibir o gridView com valores em branco.
    /// </summary>
    private void PreencherGridVazio()
    {
        PropostaList = new List<Proposta>();

        Proposta PropostaInicial = new Proposta();

        PropostaList.Add(PropostaInicial);

        GrdProposta.DataSource = PropostaList;
        GrdProposta.DataBind();

        foreach (TableCell cell in GrdProposta.Rows[0].Cells)
        {
            cell.Text = "&nbsp;";
        }
    }

    private void ClearSession()
    {
        Session.Remove("idProposta");
        Session.Remove("PropostaList");
    }

    #endregion

    #region Métodos Públicos
    public void Consultar()
    {
        try
        {
            PropostaList = new List<Proposta>();
           
            if (!string.IsNullOrEmpty(txtTitulo.Text.Trim()))
            {
                IPropostaControlador controlador = PropostaControlador.Instance;
                Proposta proposta = new Proposta();
                proposta.Titulo = txtTitulo.Text.Trim();              


                PropostaList = controlador.Consultar(proposta, TipoPesquisa.E);

                GrdProposta.DataSource = PropostaList;
                GrdProposta.DataBind();
            }
            else
            {
                IPropostaControlador controlador = PropostaControlador.Instance;




                PropostaList = controlador.Consultar();


                GrdProposta.DataSource = PropostaList;
                GrdProposta.DataBind();
            }
        }
        catch (Exception ex)
        {
            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;
        }

    }

    //public StatusProposta GetStatusProposta(int id)
    //{
    //    StatusProposta status = StatusProposta.NaoAlterar;
    //    foreach (Proposta post in PropostaList)
    //    {
    //        if (post.ID == id)
    //            status = post.StatusProposta;
    //    }

    //    return status;
    //}
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        //ClasseAuxiliar.ValidarUsuarioLogado(true);
        if (!IsPostBack)
        {
           // ClasseAuxiliar.CarregarComboEnum<TipoProposta>(ddlTipoProposta);
            //PreencherGridVazio();
            Consultar();
        }
    }

    protected void grdProposta_RowCreated(object sender, GridViewRowEventArgs e)
    {
        foreach (TableCell cell in e.Row.Cells)
        {
            Control control = cell.FindControl("idProposta");

            if (check && control != null && control is RadioButton)
            {
                ((RadioButton)control).Checked = check;
            }
        }
    }

    protected void grdProposta_PreRender(object sender, EventArgs e)
    {
        if (PropostaList == null || PropostaList.Count == 0)
        {
            PreencherGridVazio();
        }
    }

    protected void grdProposta_PagePropostaChanging(object sender, GridViewPageEventArgs e)
    {
        GrdProposta.DataSource = PropostaList;
        if (GrdProposta.DataSource != null)
        {
            GrdProposta.PageIndex = e.NewPageIndex;
            GrdProposta.DataBind();
        }
    }

    protected void btnPesquisar_OnClick(object sender, EventArgs e)
    {
        Consultar();
    }
}