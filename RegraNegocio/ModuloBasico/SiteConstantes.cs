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

        //Proposta
        public static readonly String PROPOSTA_NAO_INCLUIDA = "Conte�do da Proposta n�o inclu�do.";
        public static readonly String PROPOSTA_NAO_ALTERADA = "Conte�do da Proposta n�o alterado.";
        public static readonly String PROPOSTA_NAO_EXCLUIDA = "Conte�do da Proposta n�o excluido.";
        public static readonly String PROPOSTA_INCLUIDA = "Conte�do da Proposta inclu�do com sucesso.";
        public static readonly String PROPOSTA_ALTERADA = "Conte�do da Proposta alterado com sucesso.";
        public static readonly String PROPOSTA_EXCLUIDA = "Conte�do da Proposta excluido com sucesso.";

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