using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RegraNegocio.ModuloBasico;
using ModuloBasico;
using Controladores.Interfaces;

public partial class ModuloAdministrador_ModuloPerfil_PerfilSelecionar : System.Web.UI.UserControl, System.Web.UI.IPostBackEventHandler
{
    #region Atributos

    private int idPerfil;
    private List<Perfil> perfilList;
    private bool check = false;


    #endregion

    #region Propriedades
    public int IdPerfil
    {
        get
        {
            if (Session["idPerfil"] != null)
                idPerfil = Convert.ToInt32(Session["idPerfil"]);

            return idPerfil;
        }
        set
        {
            Session.Add("idPerfil", value);
        }
    }

    public List<Perfil> PerfilList
    {
        get
        {
            if (Session["PerfilList"] != null)
                perfilList = (List<Perfil>)Session["PerfilList"];

            return perfilList;
        }
        set
        {
            Session.Add("PerfilList", value);
        }
    }
    #endregion

    #region Eventos

    public event EventHandler OnSelect;

    #endregion

    #region IPostBackEventHandler Members

    void IPostBackEventHandler.RaisePostBackEvent(string eventArgument)
    {
        IdPerfil = Convert.ToInt32(eventArgument);

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
    /// <param name="idPerfil">O ID do ProdutoVO que será passado como parâmetro para o evento</param>
    /// <returns>O JavaScript</returns>
    protected string GetOnSelectEvent(object idPerfil)
    {
        if (OnSelect != null && idPerfil != null)
        {
            PostBackOptions options = new PostBackOptions(this);

            options.Argument = idPerfil.ToString();

            string postBackReference = Page.ClientScript.GetPostBackEventReference(options);

            return "checkOnlyOne(this,'idPerfil');" + postBackReference + ";";
        }

        return "checkOnlyOne(this,'idPerfil');";
    }

    #region Métodos Privados
    /// <summary>
    /// Método para exibir o gridView com valores em branco.
    /// </summary>
    private void PreencherGridVazio()
    {
        PerfilList = new List<Perfil>();

        Perfil PerfilInicial = new Perfil();

        PerfilList.Add(PerfilInicial);

        GrdPerfil.DataSource = PerfilList;
        GrdPerfil.DataBind();

        foreach (TableCell cell in GrdPerfil.Rows[0].Cells)
        {
            cell.Text = "&nbsp;";
        }
    }

    private void ClearSession()
    {
        Session.Remove("idPerfil");
        Session.Remove("PerfilList");
    }

    #endregion

    #region Métodos Públicos
    public void Consultar()
    {
        try
        {
            PerfilList = new List<Perfil>();
           
            if (!string.IsNullOrEmpty(txtTitulo.Text.Trim()))
            {
                IPerfilControlador controlador = PerfilControlador.Instance;
                Perfil perfil = new Perfil();
                perfil.Titulo = txtTitulo.Text.Trim();              


                PerfilList = controlador.Consultar(perfil, TipoPesquisa.E);

                GrdPerfil.DataSource = PerfilList;
                GrdPerfil.DataBind();
            }
            else
            {
                IPerfilControlador controlador = PerfilControlador.Instance;




                PerfilList = controlador.Consultar();


                GrdPerfil.DataSource = PerfilList;
                GrdPerfil.DataBind();
            }
        }
        catch (Exception ex)
        {
            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;
        }

    }

    //public StatusPerfil GetStatusPerfil(int id)
    //{
    //    StatusPerfil status = StatusPerfil.NaoAlterar;
    //    foreach (Perfil post in PerfilList)
    //    {
    //        if (post.ID == id)
    //            status = post.StatusPerfil;
    //    }

    //    return status;
    //}
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        //ClasseAuxiliar.ValidarUsuarioLogado(true);
        if (!IsPostBack)
        {
           // ClasseAuxiliar.CarregarComboEnum<TipoPerfil>(ddlTipoPerfil);
            //PreencherGridVazio();
            Consultar();
        }
    }

    protected void grdPerfil_RowCreated(object sender, GridViewRowEventArgs e)
    {
        foreach (TableCell cell in e.Row.Cells)
        {
            Control control = cell.FindControl("idPerfil");

            if (check && control != null && control is RadioButton)
            {
                ((RadioButton)control).Checked = check;
            }
        }
    }

    protected void grdPerfil_PreRender(object sender, EventArgs e)
    {
        if (PerfilList == null || PerfilList.Count == 0)
        {
            PreencherGridVazio();
        }
    }

    protected void grdPerfil_PagePerfilChanging(object sender, GridViewPageEventArgs e)
    {
        GrdPerfil.DataSource = PerfilList;
        if (GrdPerfil.DataSource != null)
        {
            GrdPerfil.PageIndex = e.NewPageIndex;
            GrdPerfil.DataBind();
        }
    }

    protected void btnPesquisar_OnClick(object sender, EventArgs e)
    {
        Consultar();
    }
}