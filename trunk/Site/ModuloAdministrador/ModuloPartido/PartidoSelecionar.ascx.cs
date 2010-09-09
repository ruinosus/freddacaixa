using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RegraNegocio.ModuloBasico;
using ModuloBasico;
using Controladores.Interfaces;

public partial class ModuloAdministrador_ModuloPartido_PartidoSelecionar : System.Web.UI.UserControl, System.Web.UI.IPostBackEventHandler
{
    #region Atributos

    private int idPartido;
    private List<Partido> partidoList;
    private bool check = false;


    #endregion

    #region Propriedades
    public int IdPartido
    {
        get
        {
            if (Session["idPartido"] != null)
                idPartido = Convert.ToInt32(Session["idPartido"]);

            return idPartido;
        }
        set
        {
            Session.Add("idPartido", value);
        }
    }

    public List<Partido> PartidoList
    {
        get
        {
            if (Session["PartidoList"] != null)
                partidoList = (List<Partido>)Session["PartidoList"];

            return partidoList;
        }
        set
        {
            Session.Add("PartidoList", value);
        }
    }
    #endregion

    #region Eventos

    public event EventHandler OnSelect;

    #endregion

    #region IPostBackEventHandler Members

    void IPostBackEventHandler.RaisePostBackEvent(string eventArgument)
    {
        IdPartido = Convert.ToInt32(eventArgument);

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
    /// <param name="idPartido">O ID do ProdutoVO que será passado como parâmetro para o evento</param>
    /// <returns>O JavaScript</returns>
    protected string GetOnSelectEvent(object idPartido)
    {
        if (OnSelect != null && idPartido != null)
        {
            PostBackOptions options = new PostBackOptions(this);

            options.Argument = idPartido.ToString();

            string postBackReference = Page.ClientScript.GetPostBackEventReference(options);

            return "checkOnlyOne(this,'idPartido');" + postBackReference + ";";
        }

        return "checkOnlyOne(this,'idPartido');";
    }

    #region Métodos Privados
    /// <summary>
    /// Método para exibir o gridView com valores em branco.
    /// </summary>
    private void PreencherGridVazio()
    {
        PartidoList = new List<Partido>();

        Partido PartidoInicial = new Partido();

        PartidoList.Add(PartidoInicial);

        GrdPartido.DataSource = PartidoList;
        GrdPartido.DataBind();

        foreach (TableCell cell in GrdPartido.Rows[0].Cells)
        {
            cell.Text = "&nbsp;";
        }
    }

    private void ClearSession()
    {
        Session.Remove("idPartido");
        Session.Remove("PartidoList");
    }

    #endregion

    #region Métodos Públicos
    public void Consultar()
    {
        try
        {
            PartidoList = new List<Partido>();
           
            if (!string.IsNullOrEmpty(txtTitulo.Text.Trim()))
            {
                IPartidoControlador controlador = PartidoControlador.Instance;
                Partido partido = new Partido();
                partido.Titulo = txtTitulo.Text.Trim();              


                PartidoList = controlador.Consultar(partido, TipoPesquisa.E);

                GrdPartido.DataSource = PartidoList;
                GrdPartido.DataBind();
            }
            else
            {
                IPartidoControlador controlador = PartidoControlador.Instance;




                PartidoList = controlador.Consultar();


                GrdPartido.DataSource = PartidoList;
                GrdPartido.DataBind();
            }
        }
        catch (Exception ex)
        {
            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;
        }

    }

    //public StatusPartido GetStatusPartido(int id)
    //{
    //    StatusPartido status = StatusPartido.NaoAlterar;
    //    foreach (Partido post in PartidoList)
    //    {
    //        if (post.ID == id)
    //            status = post.StatusPartido;
    //    }

    //    return status;
    //}
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        //ClasseAuxiliar.ValidarUsuarioLogado(true);
        if (!IsPostBack)
        {
           // ClasseAuxiliar.CarregarComboEnum<TipoPartido>(ddlTipoPartido);
            //PreencherGridVazio();
            Consultar();
        }
    }

    protected void grdPartido_RowCreated(object sender, GridViewRowEventArgs e)
    {
        foreach (TableCell cell in e.Row.Cells)
        {
            Control control = cell.FindControl("idPartido");

            if (check && control != null && control is RadioButton)
            {
                ((RadioButton)control).Checked = check;
            }
        }
    }

    protected void grdPartido_PreRender(object sender, EventArgs e)
    {
        if (PartidoList == null || PartidoList.Count == 0)
        {
            PreencherGridVazio();
        }
    }

    protected void grdPartido_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GrdPartido.DataSource = PartidoList;
        if (GrdPartido.DataSource != null)
        {
            GrdPartido.PageIndex = e.NewPageIndex;
            GrdPartido.DataBind();
        }
    }

    protected void btnPesquisar_OnClick(object sender, EventArgs e)
    {
        Consultar();
    }
}