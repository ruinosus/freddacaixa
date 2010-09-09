using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RegraNegocio.ModuloBasico;
using ModuloBasico;
using Controladores.Interfaces;

public partial class ModuloAdministrador_ModuloFoto_FotoSelecionar : System.Web.UI.UserControl, System.Web.UI.IPostBackEventHandler
{
    #region Atributos

    private int idFoto;
    private List<Foto> fotoList;
    private bool check = false;


    #endregion

    #region Propriedades
    public int IdFoto
    {
        get
        {
            if (Session["idFoto"] != null)
                idFoto = Convert.ToInt32(Session["idFoto"]);

            return idFoto;
        }
        set
        {
            Session.Add("idFoto", value);
        }
    }

    public List<Foto> FotoList
    {
        get
        {
            if (Session["FotoList"] != null)
                fotoList = (List<Foto>)Session["FotoList"];

            return fotoList;
        }
        set
        {
            Session.Add("FotoList", value);
        }
    }
    #endregion

    #region Eventos

    public event EventHandler OnSelect;

    #endregion

    #region IPostBackEventHandler Members

    void IPostBackEventHandler.RaisePostBackEvent(string eventArgument)
    {
        IdFoto = Convert.ToInt32(eventArgument);

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
    /// <param name="idFoto">O ID do ProdutoVO que será passado como parâmetro para o evento</param>
    /// <returns>O JavaScript</returns>
    protected string GetOnSelectEvent(object idFoto)
    {
        if (OnSelect != null && idFoto != null)
        {
            PostBackOptions options = new PostBackOptions(this);

            options.Argument = idFoto.ToString();

            string postBackReference = Page.ClientScript.GetPostBackEventReference(options);

            return "checkOnlyOne(this,'idFoto');" + postBackReference + ";";
        }

        return "checkOnlyOne(this,'idFoto');";
    }

    #region Métodos Privados
    /// <summary>
    /// Método para exibir o gridView com valores em branco.
    /// </summary>
    private void PreencherGridVazio()
    {
        FotoList = new List<Foto>();

        Foto FotoInicial = new Foto();

        FotoList.Add(FotoInicial);

        GrdFoto.DataSource = FotoList;
        GrdFoto.DataBind();

        foreach (TableCell cell in GrdFoto.Rows[0].Cells)
        {
            cell.Text = "&nbsp;";
        }
    }

    private void ClearSession()
    {
        Session.Remove("idFoto");
        Session.Remove("FotoList");
    }

    #endregion

    #region Métodos Públicos
    public void Consultar()
    {
        try
        {
            FotoList = new List<Foto>();
           
            if (!string.IsNullOrEmpty(txtTitulo.Text.Trim()))
            {
                IFotoControlador controlador = FotoControlador.Instance;
                Foto foto = new Foto();
                foto.Titulo = txtTitulo.Text.Trim();              


                FotoList = controlador.Consultar(foto, TipoPesquisa.E);

                GrdFoto.DataSource = FotoList;
                GrdFoto.DataBind();
            }
            else
            {
                IFotoControlador controlador = FotoControlador.Instance;




                FotoList = controlador.Consultar();


                GrdFoto.DataSource = FotoList;
                GrdFoto.DataBind();
            }
        }
        catch (Exception ex)
        {
            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;
        }

    }

    //public StatusFoto GetStatusFoto(int id)
    //{
    //    StatusFoto status = StatusFoto.NaoAlterar;
    //    foreach (Foto post in FotoList)
    //    {
    //        if (post.ID == id)
    //            status = post.StatusFoto;
    //    }

    //    return status;
    //}
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        //ClasseAuxiliar.ValidarUsuarioLogado(true);
        if (!IsPostBack)
        {
           // ClasseAuxiliar.CarregarComboEnum<TipoFoto>(ddlTipoFoto);
            //PreencherGridVazio();
            Consultar();
        }
    }

    protected void grdFoto_RowCreated(object sender, GridViewRowEventArgs e)
    {
        foreach (TableCell cell in e.Row.Cells)
        {
            Control control = cell.FindControl("idFoto");

            if (check && control != null && control is RadioButton)
            {
                ((RadioButton)control).Checked = check;
            }
        }
    }

    protected void grdFoto_PreRender(object sender, EventArgs e)
    {
        if (FotoList == null || FotoList.Count == 0)
        {
            PreencherGridVazio();
        }
    }

    protected void grdFoto_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GrdFoto.DataSource = FotoList;
        if (GrdFoto.DataSource != null)
        {
            GrdFoto.PageIndex = e.NewPageIndex;
            GrdFoto.DataBind();
        }
    }

    protected void btnPesquisar_OnClick(object sender, EventArgs e)
    {
        Consultar();
    }
}