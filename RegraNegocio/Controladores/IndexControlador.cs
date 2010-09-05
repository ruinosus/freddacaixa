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
    public class IndexControlador : Singleton<IndexControlador>, IIndexControlador
    {
        #region Atributos
        private IIndexRepositorio indexRepositorio = null;
        #endregion

        #region Construtor
        public IndexControlador()
        {
            indexRepositorio = IndexFabrica.IIndexInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Index index)
        {
            try
            {
                this.indexRepositorio.Incluir(index);
                this.indexRepositorio.Confirmar();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Index index)
        {
            try
            {
                this.indexRepositorio.Excluir(index);
                this.indexRepositorio.Confirmar();
            }
            catch (Exception e)
            {

                throw e;
            }
  
        }

        public void Alterar(Index index)
        {
            this.indexRepositorio.Alterar(index);
            this.indexRepositorio.Confirmar();
        }

        public List<Index> Consultar(Index index, TipoPesquisa tipoPesquisa)
        {
            List<Index> indexList = this.indexRepositorio.Consultar(index, tipoPesquisa);

            return indexList;
        }

        public List<Index> Consultar()
        {
            List<Index> indexList = indexRepositorio.Consultar();

            return indexList;
        }

       

        #endregion
    }
}