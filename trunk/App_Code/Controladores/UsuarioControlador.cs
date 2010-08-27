using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ModuloBasico;
using Fabricas;
using Repositorios.Interfaces;
namespace Controladores.Interfaces
{
    public class UsuarioControlador : Singleton<UsuarioControlador>, IUsuarioControlador
    {
        #region Atributos
        private IUsuarioRepositorio usuarioRepositorio = null;
        #endregion

        #region Construtor
        public UsuarioControlador()
        {
            usuarioRepositorio = UsuarioFabrica.IUsuarioInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Usuario usuario)
        {
            try
            {
                Usuario userPesquisa= new Usuario();
                userPesquisa.Login = usuario.Login;
                List<Usuario> resultado = Consultar(userPesquisa,TipoPesquisa.E);
                if (resultado.Count > 0)
                    throw new Exception(SiteConstantes.USUARIO_LOING_JA_EXISTENTE);

                this.usuarioRepositorio.Incluir(usuario);
                this.usuarioRepositorio.Confirmar();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Usuario usuario)
        {
            try
            {
                this.usuarioRepositorio.Excluir(usuario);
                this.usuarioRepositorio.Confirmar();
            }
            catch (Exception e)
            {

                throw e;
            }
  
        }

        public void Alterar(Usuario usuario)
        {
            this.usuarioRepositorio.Alterar(usuario);
            this.usuarioRepositorio.Confirmar();
        }

        public List<Usuario> Consultar(Usuario usuario, TipoPesquisa tipoPesquisa)
        {
            List<Usuario> usuarioList = this.usuarioRepositorio.Consultar(usuario, tipoPesquisa);

            return usuarioList;
        }

        public List<Usuario> Consultar()
        {
            List<Usuario> usuarioList = usuarioRepositorio.Consultar();

            return usuarioList;
        }

       

        #endregion
    }
}