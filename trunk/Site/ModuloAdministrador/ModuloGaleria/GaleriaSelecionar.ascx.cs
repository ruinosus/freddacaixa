using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RegraNegocio.ModuloBasico;
using ModuloBasico;
using Controladores.Interfaces;

public partial class ModuloAdministrador_ModuloGaleria_GaleriaSelecionar : System.Web.UI.UserControl, System.Web.UI.IPostBackEventHandler
{
    #region Atributos

    private int idGaleria;
    private List<Galeria> galeriaList;
    private bool check = false;


    #endregion

    #region Propriedades
    public int IdGaleria
    {
        get
        {
            if (Session["idGaleria"] != null)
                idGaleria = Convert.ToInt32(Session["idGaleria"]);

            return idGaleria;
        }
        set
        {
            Session.Add("idGaleria", value);
        }
    }

    public List<Galeria> GaleriaList
    {
        get
        {
            if (Session["GaleriaList"] != null)
                galeriaList = (List<Galeria>)Session["GaleriaList"];

            return galeriaList;
        }
        set
        {
            Session.Add("GaleriaList", value);
        }
    }
    #endregion

    #region Eventos

    public event EventHandler OnSelect;

    #endregion

    #region IPostBackEventHandler Members

    void IPostBackEventHandler.RaisePostBackEvent(string eventArgument)
    {
        IdGaleria = Convert.ToInt32(eventArgument);

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
    /// <param name="idGaleria">O ID do ProdutoVO que será passado como parâmetro para o evento</param>
    /// <returns>O JavaScript</returns>
    protected string GetOnSelectEvent(object idGaleria)
    {
        if (OnSelect != null && idGaleria != null)
        {
            PostBackOptions options = new PostBackOptions(this);

            options.Argument = idGaleria.ToString();

            string postBackReference = Page.ClientScript.GetPostBackEventReference(options);

            return "checkOnlyOne(this,'idGaleria');" + postBackReference + ";";
        }

        return "checkOnlyOne(this,'idGaleria');";
    }

    #region Métodos Privados
    /// <summary>
    /// Método para exibir o gridView com valores em branco.
    /// </summary>
    private void PreencherGridVazio()
    {
        GaleriaList = new List<Galeria>();

        Galeria GaleriaInicial = new Galeria();

        GaleriaList.Add(GaleriaInicial);

        GrdGaleria.DataSource = GaleriaList;
        GrdGaleria.DataBind();

        foreach (TableCell cell in GrdGaleria.Rows[0].Cells)
        {
            cell.Text = "&nbsp;";
        }
    }

    private void ClearSession()
    {
        Session.Remove("idGaleria");
        Session.Remove("GaleriaList");
    }

    #endregion

    #region Métodos Públicos
    public void Consultar()
    {
        try
        {
            GaleriaList = new List<Galeria>();
           
            if (!string.IsNullOrEmpty(txtTitulo.Text.Trim()))
            {
                IGaleriaControlador controlador = GaleriaControlador.Instance;
                Galeria galeria = new Galeria();
                galeria.Titulo = txtTitulo.Text.Trim();              


                GaleriaList = controlador.Consultar(galeria, TipoPesquisa.E);

                GrdGaleria.DataSource = GaleriaList;
                GrdGaleria.DataBind();
            }
            else
            {
                IGaleriaControlador controlador = GaleriaControlador.Instance;




                GaleriaList = controlador.Consultar();


                GrdGaleria.DataSource = GaleriaList;
                GrdGaleria.DataBind();
            }
        }
        catch (Exception ex)
        {
            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;
        }

    }

    //public StatusGaleria GetStatusGaleria(int id)
    //{
    //    StatusGaleria status = StatusGaleria.NaoAlterar;
    //    foreach (Galeria post in GaleriaList)
    //    {
    //        if (post.ID == id)
    //            status = post.StatusGaleria;
    //    }

    //    return status;
    //}
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        //ClasseAuxiliar.ValidarUsuarioLogado(true);
        if (!IsPostBack)
        {
           // ClasseAuxiliar.CarregarComboEnum<TipoGaleria>(ddlTipoGaleria);
            //PreencherGridVazio();
            Consultar();
        }
    }

    protected void grdGaleria_RowCreated(object sender, GridViewRowEventArgs e)
    {
        foreach (TableCell cell in e.Row.Cells)
        {
            Control control = cell.FindControl("idGaleria");

            if (check && control != null && control is RadioButton)
            {
                ((RadioButton)control).Checked = check;
            }
        }
    }

    protected void grdGaleria_PreRender(object sender, EventArgs e)
    {
        if (GaleriaList == null || GaleriaList.Count == 0)
        {
            PreencherGridVazio(); 
        }
    }

    protected void grdGaleria_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GrdGaleria.DataSource = GaleriaList;
        if (GrdGaleria.DataSource != null)
        {
            GrdGaleria.PageIndex = e.NewPageIndex;
            GrdGaleria.DataBind();
        }
    }

    protected void btnPesquisar_OnClick(object sender, EventArgs e)
    {
        Consultar();
    }
}