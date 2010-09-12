using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Web.Mail;
using RegraNegocio.ModuloBasico;

public partial class Contato : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnEnviar_Click(object sender, EventArgs e)
    {

        Email.EnviarEmail(System.Configuration.ConfigurationManager.AppSettings["emailDestinatario"], txtAssunto.Text, txtMensagem.Text, txtNome.Text, ckbInformacao.Checked, txtEmail.Text);
      //  Email.EnviarEmail("jeffeson.barnabe@gmail.com", txtAssunto.Text, txtMensagem.Text, txtNome.Text, ckbInformacao.Checked, txtEmail.Text);
        txtAssunto.Text = string.Empty;
        txtEmail.Text = string.Empty;
        txtMensagem.Text = string.Empty;
        txtNome.Text = string.Empty;
        btnEnviar.Enabled = false;
        ckbInformacao.Checked = false;
        btnEnviar.Text = "Sua mensagem foi enviada.";
    }


}

