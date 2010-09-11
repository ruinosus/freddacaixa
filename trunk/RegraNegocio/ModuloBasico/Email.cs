using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Configuration;

namespace RegraNegocio.ModuloBasico
{
    public class Email
    {

        /// <summary>
        /// Método para enviar email
        /// </summary>
        /// <param name="emailDestinatario">Email do destinatário</param>
        /// <param name="assunto">Assunto do email</param>
        /// <param name="mensagem">mensagem do email</param>
        /// <param name="Nome">nome do eleitor</param>
        /// <param name="desejaReceber">Se deseja receber informações</param>
        public static void EnviarEmail(string emailDestinatario, string assunto, string mensagem, string Nome, bool desejaReceber, string emailInformado)
        {
            //Cria o objeto que envia o e-mail
            SmtpClient client = new SmtpClient();
            client.Host = "smtp-web.kinghost.net";
            System.Net.NetworkCredential mailAuthentication = new System.Net.NetworkCredential("thecase@thecase.com.br", "e7k6v9n9");
            //Cria o endereço de email do remetente
            MailAddress de = new MailAddress(System.Configuration.ConfigurationManager.AppSettings["emailRemetente"]);
            //Cria o endereço de email do destinatário -->
            MailAddress para = new MailAddress(emailDestinatario);
            MailMessage mensagemMail = new MailMessage(de, para);
            mensagemMail.IsBodyHtml = true;


            //Assunto do email
            mensagemMail.Subject = assunto;
            //Conteúdo do email
            string mensagemInformacao = "O eleitor: <b><ELEITOR></b>, <FLAG> deseja receber atualizações por email. <br> Email: <b><EMAIL></b><br>";
            mensagemInformacao = mensagemInformacao.Replace("<ELEITOR>", Nome);
            mensagemInformacao = mensagemInformacao.Replace("<EMAIL>", emailDestinatario);
            if (desejaReceber)
                mensagemInformacao = mensagemInformacao.Replace("<FLAG>", "");
            else
                mensagemInformacao = mensagemInformacao.Replace("<FLAG>", "não");
            string mensagemCorpo = "Assunto: <ASSUNTO> <br> Mensagem: <MENSAGEM> ";
            mensagemCorpo = mensagemCorpo.Replace("<ASSUNTO>", assunto);
            mensagemCorpo = mensagemCorpo.Replace("<MENSAGEM>", mensagem);
            string mensagemFinal = mensagemInformacao + mensagemCorpo;
            mensagemMail.Body = mensagemFinal;


            try
            {
                client.EnableSsl = true;

                client.UseDefaultCredentials = false;

                client.Credentials = mailAuthentication;
                //Envia o email
                client.Send(mensagemMail);
            }
            catch
            {

            }
        }
    }
}
