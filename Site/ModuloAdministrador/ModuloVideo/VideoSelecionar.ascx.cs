using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RegraNegocio.ModuloBasico;
using ModuloBasico;
using Controladores.Interfaces;

public partial class ModuloAdministrador_ModuloVideo_VideoSelecionar : System.Web.UI.UserControl, System.Web.UI.IPostBackEventHandler
{
    #region Atributos

    private int idVideo;
    private List<Video> videoList;
    private bool check = false;


    #endregion

    #region Propriedades
    public int IdVideo
    {
        get
        {
            if (Session["idVideo"] != null)
                idVideo = Convert.ToInt32(Session["idVideo"]);

            return idVideo;
        }
        set
        {
            Session.Add("idVideo", value);
        }
    }

    public List<Video> VideoList
    {
        get
        {
            if (Session["VideoList"] != null)
                videoList = (List<Video>)Session["VideoList"];

            return videoList;
        }
        set
        {
            Session.Add("VideoList", value);
        }
    }
    #endregion

    #region Eventos

    public event EventHandler OnSelect;

    #endregion

    #region IPostBackEventHandler Members

    void IPostBackEventHandler.RaisePostBackEvent(string eventArgument)
    {
        IdVideo = Convert.ToInt32(eventArgument);

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
    /// <param name="idVideo">O ID do ProdutoVO que será passado como parâmetro para o evento</param>
    /// <returns>O JavaScript</returns>
    protected string GetOnSelectEvent(object idVideo)
    {
        if (OnSelect != null && idVideo != null)
        {
            PostBackOptions options = new PostBackOptions(this);

            options.Argument = idVideo.ToString();

            string postBackReference = Page.ClientScript.GetPostBackEventReference(options);

            return "checkOnlyOne(this,'idVideo');" + postBackReference + ";";
        }

        return "checkOnlyOne(this,'idVideo');";
    }

    #region Métodos Privados
    /// <summary>
    /// Método para exibir o gridView com valores em branco.
    /// </summary>
    private void PreencherGridVazio()
    {
        VideoList = new List<Video>();

        Video VideoInicial = new Video();

        VideoList.Add(VideoInicial);

        GrdVideo.DataSource = VideoList;
        GrdVideo.DataBind();

        foreach (TableCell cell in GrdVideo.Rows[0].Cells)
        {
            cell.Text = "&nbsp;";
        }
    }

    private void ClearSession()
    {
        Session.Remove("idVideo");
        Session.Remove("VideoList");
    }

    #endregion

    #region Métodos Públicos
    public void Consultar()
    {
        try
        {
            VideoList = new List<Video>();
           
            if (!string.IsNullOrEmpty(txtTitulo.Text.Trim()))
            {
                IVideoControlador controlador = VideoControlador.Instance;
                Video video = new Video();
                video.Titulo = txtTitulo.Text.Trim();              


                VideoList = controlador.Consultar(video, TipoPesquisa.E);

                GrdVideo.DataSource = VideoList;
                GrdVideo.DataBind();
            }
            else
            {
                IVideoControlador controlador = VideoControlador.Instance;




                VideoList = controlador.Consultar();


                GrdVideo.DataSource = VideoList;
                GrdVideo.DataBind();
            }
        }
        catch (Exception ex)
        {
            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;
        }

    }

    //public StatusVideo GetStatusVideo(int id)
    //{
    //    StatusVideo status = StatusVideo.NaoAlterar;
    //    foreach (Video post in VideoList)
    //    {
    //        if (post.ID == id)
    //            status = post.StatusVideo;
    //    }

    //    return status;
    //}
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        //ClasseAuxiliar.ValidarUsuarioLogado(true);
        if (!IsPostBack)
        {
           // ClasseAuxiliar.CarregarComboEnum<TipoVideo>(ddlTipoVideo);
            //PreencherGridVazio();
            Consultar();
        }
    }

    protected void grdVideo_RowCreated(object sender, GridViewRowEventArgs e)
    {
        foreach (TableCell cell in e.Row.Cells)
        {
            Control control = cell.FindControl("idVideo");

            if (check && control != null && control is RadioButton)
            {
                ((RadioButton)control).Checked = check;
            }
        }
    }

    protected void grdVideo_PreRender(object sender, EventArgs e)
    {
        if (VideoList == null || VideoList.Count == 0)
        {
            PreencherGridVazio();
        }
    }

    protected void grdVideo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GrdVideo.DataSource = VideoList;
        if (GrdVideo.DataSource != null)
        {
            GrdVideo.PageIndex = e.NewPageIndex;
            GrdVideo.DataBind();
        }
    }

    protected void btnPesquisar_OnClick(object sender, EventArgs e)
    {
        Consultar();
    }
}