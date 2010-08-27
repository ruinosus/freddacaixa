using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Configuration;
using Twitterizer;
using ModuloBasico;
using Controladores.Interfaces;



public partial class Index : System.Web.UI.Page
{
    protected const string usuario = "userTwitter";
    protected const string senha = "senhaTwitter";
    protected const string urlPost = "http://twitter.com/statuses/update.xml{0}";
    protected void Page_Load(object sender, EventArgs e)
    {

        IIndexControlador controlador = IndexControlador.Instance;


        gridIndex.DataSource = controlador.Consultar();
        gridIndex.DataBind();
        //Usuario user = new Usuario();
        //user.ID = 2;
        //user.Login = "mudei";
        //user.Senha = "admin";

        //UsuarioControlador.Instance.Alterar(user);

        //OAuthTokens oa = new OAuthTokens();
        //oa.ConsumerKey = "bijZRmG0cscUgDuxaLIWw";
        //oa.ConsumerSecret = "r7EoUXlhZ0hcP3X7PRwywP98tyjUiZvS18e83UrVBI";

        //OAuthTokenResponse requestAccessTokens = OAuthUtility.GetAccessToken(
        //        "bijZRmG0cscUgDuxaLIWw",
        //        "r7EoUXlhZ0hcP3X7PRwywP98tyjUiZvS18e83UrVBI");
        //Twittar("teste", ConfigurationManager.AppSettings[usuario], ConfigurationManager.AppSettings[usuario]);
    }

    /// <summary>
    /// Método que envia o post para o twitter
    /// </summary>
    /// <param name="mensagem">Mensagem a ser postada</param>
    /// <param name="usuario">usuário do Twitter (eu coloquei no web.config)</param>
    /// <param name="senha">Senha do Twitter  (eu coloquei no web.config)</param>
    public void Twittar(string mensagem, string usuario, string senha)
    {
        string url = urlPost;
        // Passando o URLEncode na mensagem a ser postada
        string dados = string.Format("?status={0}", HttpUtility.UrlEncode(mensagem));
        url = String.Format(url, dados);

        try
        {
            //Instanciando o WebRequest
            WebRequest Req = WebRequest.Create(url);
            Req.Method = "POST";
            Req.Credentials = new NetworkCredential(usuario, senha);
            Req.ContentType = "text/xml; charset=utf-8";
            WebResponse Res = Req.GetResponse();
            //this.lblResult.Text = "Post enviado com sucesso.";
        }
        catch (WebException e)
        {
            //this.lblResult.Text = e.Message;
        }

    }
}
