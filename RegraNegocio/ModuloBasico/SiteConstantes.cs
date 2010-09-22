using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace ModuloBasico
{
    public static class SiteConstantes
    {
        //Index
        public static readonly String INDEX_NAO_INCLUIDO = "Conte�do do Index n�o inclu�do.";
        public static readonly String INDEX_NAO_ALTERADO = "Conte�do do Index n�o alterado.";
        public static readonly String INDEX_NAO_EXCLUIDO = "Conte�do do Index n�o excluido.";
        public static readonly String INDEX_INCLUIDO = "Conte�do do Index inclu�do com sucesso.";
        public static readonly String INDEX_ALTERADO = "Conte�do do Index alterado com sucesso.";
        public static readonly String INDEX_EXCLUIDO = "Conte�do do Index excluido com sucesso.";

        //Partido
        public static readonly String PARTIDO_NAO_INCLUIDO = "Conte�do do Partido n�o inclu�do.";
        public static readonly String PARTIDO_NAO_ALTERADO = "Conte�do do Partido n�o alterado.";
        public static readonly String PARTIDO_NAO_EXCLUIDO = "Conte�do do Partido n�o excluido.";
        public static readonly String PARTIDO_INCLUIDO = "Conte�do do Partido inclu�do com sucesso.";
        public static readonly String PARTIDO_ALTERADO = "Conte�do do Partido alterado com sucesso.";
        public static readonly String PARTIDO_EXCLUIDO = "Conte�do do Partido excluido com sucesso.";

        //Lider
        public static readonly String LIDER_NAO_INCLUIDO = "Conte�do do Lider n�o inclu�do.";
        public static readonly String LIDER_NAO_ALTERADO = "Conte�do do Lider n�o alterado.";
        public static readonly String LIDER_NAO_EXCLUIDO = "Conte�do do Lider n�o excluido.";
        public static readonly String LIDER_INCLUIDO = "Conte�do do Lider inclu�do com sucesso.";
        public static readonly String LIDER_ALTERADO = "Conte�do do Lider alterado com sucesso.";
        public static readonly String LIDER_EXCLUIDO = "Conte�do do Lider excluido com sucesso.";



        //Perfil
        public static readonly String PERFIL_NAO_INCLUIDO = "Conte�do do Perfil n�o inclu�do.";
        public static readonly String PERFIL_NAO_ALTERADO = "Conte�do do Perfil n�o alterado.";
        public static readonly String PERFIL_NAO_EXCLUIDO = "Conte�do do Perfil n�o excluido.";
        public static readonly String PERFIL_INCLUIDO = "Conte�do do Perfil inclu�do com sucesso.";
        public static readonly String PERFIL_ALTERADO = "Conte�do do Perfil alterado com sucesso.";
        public static readonly String PERFIL_EXCLUIDO = "Conte�do do Perfil excluido com sucesso.";

        //Video
        public static readonly String VIDEO_NAO_INCLUIDO = "Conte�do do Video n�o inclu�do.";
        public static readonly String VIDEO_NAO_ALTERADO = "Conte�do do Video n�o alterado.";
        public static readonly String VIDEO_NAO_EXCLUIDO = "Conte�do do Video n�o excluido.";
        public static readonly String VIDEO_INCLUIDO = "Conte�do do Video inclu�do com sucesso.";
        public static readonly String VIDEO_ALTERADO = "Conte�do do Video alterado com sucesso.";
        public static readonly String VIDEO_EXCLUIDO = "Conte�do do Video excluido com sucesso.";


        //Proposta
        public static readonly String PROPOSTA_NAO_INCLUIDA = "Conte�do da Proposta n�o inclu�do.";
        public static readonly String PROPOSTA_NAO_ALTERADA = "Conte�do da Proposta n�o alterado.";
        public static readonly String PROPOSTA_NAO_EXCLUIDA = "Conte�do da Proposta n�o excluido.";
        public static readonly String PROPOSTA_INCLUIDA = "Conte�do da Proposta inclu�do com sucesso.";
        public static readonly String PROPOSTA_ALTERADA = "Conte�do da Proposta alterado com sucesso.";
        public static readonly String PROPOSTA_EXCLUIDA = "Conte�do da Proposta excluido com sucesso.";

        //Foto
        public static readonly String FOTO_NAO_INCLUIDA = "Conte�do da Foto n�o inclu�do.";
        public static readonly String FOTO_NAO_ALTERADA = "Conte�do da Foto n�o alterado.";
        public static readonly String FOTO_NAO_EXCLUIDA = "Conte�do da Foto n�o excluido.";
        public static readonly String FOTO_INCLUIDA = "Conte�do da Foto inclu�do com sucesso.";
        public static readonly String FOTO_ALTERADA = "Conte�do da Foto alterado com sucesso.";
        public static readonly String FOTO_EXCLUIDA = "Conte�do da Foto excluido com sucesso.";


        //Usuario
        public static readonly String USUARIO_NAO_INCLUIDO = "Usu�rio n�o inclu�do.";
        public static readonly String USUARIO_NAO_ALTERADO = "Usu�rio n�o alterado.";
        public static readonly String USUARIO_NAO_EXCLUIDO = "Usu�rio n�o excluido.";
        public static readonly String USUARIO_INCLUIDO = "Usu�rio inclu�do com sucesso.";
        public static readonly String USUARIO_ALTERADO = "Usu�rio alterado com sucesso.";
        public static readonly String USUARIO_EXCLUIDO = "Usu�rio excluido com sucesso.";
        public static readonly String USUARIO_LOGIN_OU_SENHA_INVALIDOS = "Login ou senha inv�lidos.";
        public static readonly String USUARIO_LOING_JA_EXISTENTE = "Login j� informado, por favor informe outro.";


        //Galeria
        public static readonly String GALERIA_NAO_INCLUIDA = "Conte�do da Galeria n�o inclu�do.";
        public static readonly String GALERIA_NAO_ALTERADA = "Conte�do da Galeria n�o alterado.";
        public static readonly String GALERIA_NAO_EXCLUIDA = "Conte�do da Galeria n�o excluido.";
        public static readonly String GALERIA_INCLUIDA = "Conte�do da Galeria inclu�do com sucesso.";
        public static readonly String GALERIA_ALTERADA = "Conte�do da Galeria alterado com sucesso.";
        public static readonly String GALERIA_EXCLUIDA = "Conte�do da Galeria excluido com sucesso.";



        public static readonly String PAGINA_PRINCIPAL = "~/ModuloAdministrador/Admin.aspx";


        public static string RecuperarNomePastaGaleria(string maphServer, int idGaleria)
        {
            string resultado = string.Empty;
            resultado = maphServer + "Imagens\\GALERIA_" + idGaleria + "\\";
            return resultado;
        }

        public static string RecuperarNomePastaFoto(string maphServer, int idFoto, int idGaleria)
        {
            string resultado = string.Empty;
            resultado = maphServer + "Imagens\\GALERIA_" + idGaleria + "\\FOTO_" + idFoto + "\\";
            return resultado;
        }

        public static string RecuperarPasta(string caminho)
        {
            string resultado = string.Empty;

            DirectoryInfo dir = new DirectoryInfo(caminho);
            try
            {
                if (dir.Exists)
                {
                    resultado = caminho;
                }
                else
                {
                    dir.Create();
                    resultado = caminho;
                }
            }
            catch (Exception exe)
            {
                throw exe;
            }

            return resultado;
        }

       

      

    }
}