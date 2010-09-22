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
        public static readonly String INDEX_NAO_INCLUIDO = "Conteúdo do Index não incluído.";
        public static readonly String INDEX_NAO_ALTERADO = "Conteúdo do Index não alterado.";
        public static readonly String INDEX_NAO_EXCLUIDO = "Conteúdo do Index não excluido.";
        public static readonly String INDEX_INCLUIDO = "Conteúdo do Index incluído com sucesso.";
        public static readonly String INDEX_ALTERADO = "Conteúdo do Index alterado com sucesso.";
        public static readonly String INDEX_EXCLUIDO = "Conteúdo do Index excluido com sucesso.";

        //Partido
        public static readonly String PARTIDO_NAO_INCLUIDO = "Conteúdo do Partido não incluído.";
        public static readonly String PARTIDO_NAO_ALTERADO = "Conteúdo do Partido não alterado.";
        public static readonly String PARTIDO_NAO_EXCLUIDO = "Conteúdo do Partido não excluido.";
        public static readonly String PARTIDO_INCLUIDO = "Conteúdo do Partido incluído com sucesso.";
        public static readonly String PARTIDO_ALTERADO = "Conteúdo do Partido alterado com sucesso.";
        public static readonly String PARTIDO_EXCLUIDO = "Conteúdo do Partido excluido com sucesso.";

        //Lider
        public static readonly String LIDER_NAO_INCLUIDO = "Conteúdo do Lider não incluído.";
        public static readonly String LIDER_NAO_ALTERADO = "Conteúdo do Lider não alterado.";
        public static readonly String LIDER_NAO_EXCLUIDO = "Conteúdo do Lider não excluido.";
        public static readonly String LIDER_INCLUIDO = "Conteúdo do Lider incluído com sucesso.";
        public static readonly String LIDER_ALTERADO = "Conteúdo do Lider alterado com sucesso.";
        public static readonly String LIDER_EXCLUIDO = "Conteúdo do Lider excluido com sucesso.";



        //Perfil
        public static readonly String PERFIL_NAO_INCLUIDO = "Conteúdo do Perfil não incluído.";
        public static readonly String PERFIL_NAO_ALTERADO = "Conteúdo do Perfil não alterado.";
        public static readonly String PERFIL_NAO_EXCLUIDO = "Conteúdo do Perfil não excluido.";
        public static readonly String PERFIL_INCLUIDO = "Conteúdo do Perfil incluído com sucesso.";
        public static readonly String PERFIL_ALTERADO = "Conteúdo do Perfil alterado com sucesso.";
        public static readonly String PERFIL_EXCLUIDO = "Conteúdo do Perfil excluido com sucesso.";

        //Video
        public static readonly String VIDEO_NAO_INCLUIDO = "Conteúdo do Video não incluído.";
        public static readonly String VIDEO_NAO_ALTERADO = "Conteúdo do Video não alterado.";
        public static readonly String VIDEO_NAO_EXCLUIDO = "Conteúdo do Video não excluido.";
        public static readonly String VIDEO_INCLUIDO = "Conteúdo do Video incluído com sucesso.";
        public static readonly String VIDEO_ALTERADO = "Conteúdo do Video alterado com sucesso.";
        public static readonly String VIDEO_EXCLUIDO = "Conteúdo do Video excluido com sucesso.";


        //Proposta
        public static readonly String PROPOSTA_NAO_INCLUIDA = "Conteúdo da Proposta não incluído.";
        public static readonly String PROPOSTA_NAO_ALTERADA = "Conteúdo da Proposta não alterado.";
        public static readonly String PROPOSTA_NAO_EXCLUIDA = "Conteúdo da Proposta não excluido.";
        public static readonly String PROPOSTA_INCLUIDA = "Conteúdo da Proposta incluído com sucesso.";
        public static readonly String PROPOSTA_ALTERADA = "Conteúdo da Proposta alterado com sucesso.";
        public static readonly String PROPOSTA_EXCLUIDA = "Conteúdo da Proposta excluido com sucesso.";

        //Foto
        public static readonly String FOTO_NAO_INCLUIDA = "Conteúdo da Foto não incluído.";
        public static readonly String FOTO_NAO_ALTERADA = "Conteúdo da Foto não alterado.";
        public static readonly String FOTO_NAO_EXCLUIDA = "Conteúdo da Foto não excluido.";
        public static readonly String FOTO_INCLUIDA = "Conteúdo da Foto incluído com sucesso.";
        public static readonly String FOTO_ALTERADA = "Conteúdo da Foto alterado com sucesso.";
        public static readonly String FOTO_EXCLUIDA = "Conteúdo da Foto excluido com sucesso.";


        //Usuario
        public static readonly String USUARIO_NAO_INCLUIDO = "Usuário não incluído.";
        public static readonly String USUARIO_NAO_ALTERADO = "Usuário não alterado.";
        public static readonly String USUARIO_NAO_EXCLUIDO = "Usuário não excluido.";
        public static readonly String USUARIO_INCLUIDO = "Usuário incluído com sucesso.";
        public static readonly String USUARIO_ALTERADO = "Usuário alterado com sucesso.";
        public static readonly String USUARIO_EXCLUIDO = "Usuário excluido com sucesso.";
        public static readonly String USUARIO_LOGIN_OU_SENHA_INVALIDOS = "Login ou senha inválidos.";
        public static readonly String USUARIO_LOING_JA_EXISTENTE = "Login já informado, por favor informe outro.";


        //Galeria
        public static readonly String GALERIA_NAO_INCLUIDA = "Conteúdo da Galeria não incluído.";
        public static readonly String GALERIA_NAO_ALTERADA = "Conteúdo da Galeria não alterado.";
        public static readonly String GALERIA_NAO_EXCLUIDA = "Conteúdo da Galeria não excluido.";
        public static readonly String GALERIA_INCLUIDA = "Conteúdo da Galeria incluído com sucesso.";
        public static readonly String GALERIA_ALTERADA = "Conteúdo da Galeria alterado com sucesso.";
        public static readonly String GALERIA_EXCLUIDA = "Conteúdo da Galeria excluido com sucesso.";



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