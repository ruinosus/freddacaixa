using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ModuloBasico;
using Fabricas;
using Repositorios.Interfaces;
using RegraNegocio.ModuloBasico;
namespace Controladores.Interfaces
{
    public class PerfilControlador : Singleton<PerfilControlador>, IPerfilControlador
    {
        #region Atributos
        private IPerfilRepositorio perfilRepositorio = null;
        #endregion

        #region Construtor
        public PerfilControlador()
        {
            perfilRepositorio = PerfilFabrica.IPerfilInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Perfil perfil)
        {
            try
            {
                this.perfilRepositorio.Incluir(perfil);
                this.perfilRepositorio.Confirmar();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Perfil perfil)
        {
            try
            {
                this.perfilRepositorio.Excluir(perfil);
                this.perfilRepositorio.Confirmar();
            }
            catch (Exception e)
            {

                throw e;
            }
  
        }

        public void Alterar(Perfil perfil)
        {
            this.perfilRepositorio.Alterar(perfil);
            this.perfilRepositorio.Confirmar();
        }

        public List<Perfil> Consultar(Perfil perfil, TipoPesquisa tipoPesquisa)
        {
            List<Perfil> perfilList = this.perfilRepositorio.Consultar(perfil, tipoPesquisa);

            return perfilList;
        }

        public List<Perfil> Consultar()
        {
            List<Perfil> perfilList = perfilRepositorio.Consultar();

            return perfilList;
        }

       

        #endregion
    }
}