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

        //Proposta
        public static readonly String PROPOSTA_NAO_INCLUIDA = "Conteúdo da Proposta não incluído.";
        public static readonly String PROPOSTA_NAO_ALTERADA = "Conteúdo da Proposta não alterado.";
        public static readonly String PROPOSTA_NAO_EXCLUIDA = "Conteúdo da Proposta não excluido.";
        public static readonly String PROPOSTA_INCLUIDA = "Conteúdo da Proposta incluído com sucesso.";
        public static readonly String PROPOSTA_ALTERADA = "Conteúdo da Proposta alterado com sucesso.";
        public static readonly String PROPOSTA_EXCLUIDA = "Conteúdo da Proposta excluido com sucesso.";

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

        public static string RecuperarPastaGaleria(string caminho)
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

        public static DirectoryInfo[] RecuperarDiretorioImagensGaleria()
        {
            DirectoryInfo[] resultado = null;
            string caminho = AppDomain.CurrentDomain.BaseDirectory + "ModuloAdministrador\\ModuloGaleria\\Imagens\\";
            DirectoryInfo dir = new DirectoryInfo(caminho);
            if (dir.Exists)
                resultado = dir.GetDirectories();

            return resultado;

        }

        public static List<string> RecuperarImagensGaleria(DirectoryInfo[] diretorios)
        {
            List<string> resultado = new List<string>();
            FileInfo[] arquivos;
            foreach (DirectoryInfo d in diretorios)
            {
                arquivos = d.GetFiles();

                for (int i = 0; i < arquivos.Length; i++)
                {
                    resultado.Add(arquivos[i].FullName);
                }

            }

            return resultado;

        }

    }
}