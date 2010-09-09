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
    public class LiderControlador : Singleton<LiderControlador>, ILiderControlador
    {
        #region Atributos
        private ILiderRepositorio liderRepositorio = null;
        #endregion

        #region Construtor
        public LiderControlador()
        {
            liderRepositorio = LiderFabrica.ILiderInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Lider lider)
        {
            try
            {
                this.liderRepositorio.Incluir(lider);
                this.liderRepositorio.Confirmar();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Lider lider)
        {
            try
            {
                this.liderRepositorio.Excluir(lider);
                this.liderRepositorio.Confirmar();
            }
            catch (Exception e)
            {

                throw e;
            }
  
        }

        public void Alterar(Lider lider)
        {
            this.liderRepositorio.Alterar(lider);
            this.liderRepositorio.Confirmar();
        }

        public List<Lider> Consultar(Lider lider, TipoPesquisa tipoPesquisa)
        {
            List<Lider> liderList = this.liderRepositorio.Consultar(lider, tipoPesquisa);

            return liderList;
        }

        public List<Lider> Consultar()
        {
            List<Lider> liderList = liderRepositorio.Consultar();

            return liderList;
        }

       

        #endregion
    }
}