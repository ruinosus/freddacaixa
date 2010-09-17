using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RegraNegocio.ModuloBasico;
using ModuloBasico;
using Controladores.Interfaces;

public partial class ModuloAdministrador_ModuloLider_LiderSelecionar : System.Web.UI.UserControl, System.Web.UI.IPostBackEventHandler
{
    #region Atributos

    private int idLider;
    private List<Lider> liderList;
    private bool check = false;


    #endregion

    #region Propriedades
    public int IdLider
    {
        get
        {
            if (Session["idLider"] != null)
                idLider = Convert.ToInt32(Session["idLider"]);

            return idLider;
        }
        set
        {
            Session.Add("idLider", value);
        }
    }

    public List<Lider> LiderList
    {
        get
        {
            if (Session["LiderList"] != null)
                liderList = (List<Lider>)Session["LiderList"];

            return liderList;
        }
        set
        {
            Session.Add("LiderList", value);
        }
    }
    #endregion

    #region Eventos

    public event EventHandler OnSelect;

    #endregion

    #region IPostBackEventHandler Members

    void IPostBackEventHandler.RaisePostBackEvent(string eventArgument)
    {
        IdLider = Convert.ToInt32(eventArgument);

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
    /// <param name="idLider">O ID do ProdutoVO que será passado como parâmetro para o evento</param>
    /// <returns>O JavaScript</returns>
    protected string GetOnSelectEvent(object idLider)
    {
        if (OnSelect != null && idLider != null)
        {
            PostBackOptions options = new PostBackOptions(this);

            options.Argument = idLider.ToString();

            string postBackReference = Page.ClientScript.GetPostBackEventReference(options);

            return "checkOnlyOne(this,'idLider');" + postBackReference + ";";
        }

        return "checkOnlyOne(this,'idLider');";
    }

    #region Métodos Privados
    /// <summary>
    /// Método para exibir o gridView com valores em branco.
    /// </summary>
    private void PreencherGridVazio()
    {
        LiderList = new List<Lider>();

        Lider LiderInicial = new Lider();

        LiderList.Add(LiderInicial);

        GrdLider.DataSource = LiderList;
        GrdLider.DataBind();

        foreach (TableCell cell in GrdLider.Rows[0].Cells)
        {
            cell.Text = "&nbsp;";
        }
    }

    private void ClearSession()
    {
        Session.Remove("idLider");
        Session.Remove("LiderList");
    }

    #endregion

    #region Métodos Públicos
    public void Consultar()
    {
        try
        {
            LiderList = new List<Lider>();
           
            if (!string.IsNullOrEmpty(txtNome.Text.Trim()))
            {
                ILiderControlador controlador = LiderControlador.Instance;
                Lider lider = new Lider();
                lider.Nome = txtNome.Text.Trim();              


                LiderList = controlador.Consultar(lider, TipoPesquisa.E);

                GrdLider.DataSource = LiderList;
                GrdLider.DataBind();
            }
            else
            {
                ILiderControlador controlador = LiderControlador.Instance;




                LiderList = controlador.Consultar();


                GrdLider.DataSource = LiderList;
                GrdLider.DataBind();
            }
        }
        catch (Exception ex)
        {
            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;
        }

    }

    //public StatusLider GetStatusLider(int id)
    //{
    //    StatusLider status = StatusLider.NaoAlterar;
    //    foreach (Lider post in LiderList)
    //    {
    //        if (post.ID == id)
    //            status = post.StatusLider;
    //    }

    //    return status;
    //}
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        //ClasseAuxiliar.ValidarUsuarioLogado(true);
        if (!IsPostBack)
        {
           // ClasseAuxiliar.CarregarComboEnum<TipoLider>(ddlTipoLider);
            //PreencherGridVazio();
            Consultar();
        }
    }

    protected void grdLider_RowCreated(object sender, GridViewRowEventArgs e)
    {
        foreach (TableCell cell in e.Row.Cells)
        {
            Control control = cell.FindControl("idLider");

            if (check && control != null && control is RadioButton)
            {
                ((RadioButton)control).Checked = check;
            }
        }
    }

    protected void grdLider_PreRender(object sender, EventArgs e)
    {
        if (LiderList == null || LiderList.Count == 0)
        {
            PreencherGridVazio();
        }
    }

    protected void grdLider_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GrdLider.DataSource = LiderList;
        if (GrdLider.DataSource != null)
        {
            GrdLider.PageIndex = e.NewPageIndex;
            GrdLider.DataBind();
        }
    }

    protected void btnPesquisar_OnClick(object sender, EventArgs e)
    {
        Consultar();
    }
}