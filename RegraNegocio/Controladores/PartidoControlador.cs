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
    public class PartidoControlador : Singleton<PartidoControlador>, IPartidoControlador
    {
        #region Atributos
        private IPartidoRepositorio partidoRepositorio = null;
        #endregion

        #region Construtor
        public PartidoControlador()
        {
            partidoRepositorio = PartidoFabrica.IPartidoInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Partido partido)
        {
            try
            {
                this.partidoRepositorio.Incluir(partido);
                this.partidoRepositorio.Confirmar();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Partido partido)
        {
            try
            {
                this.partidoRepositorio.Excluir(partido);
                this.partidoRepositorio.Confirmar();
            }
            catch (Exception e)
            {

                throw e;
            }
  
        }

        public void Alterar(Partido partido)
        {
            this.partidoRepositorio.Alterar(partido);
            this.partidoRepositorio.Confirmar();
        }

        public List<Partido> Consultar(Partido partido, TipoPesquisa tipoPesquisa)
        {
            List<Partido> partidoList = this.partidoRepositorio.Consultar(partido, tipoPesquisa);

            return partidoList;
        }

        public List<Partido> Consultar()
        {
            List<Partido> partidoList = partidoRepositorio.Consultar();

            return partidoList;
        }

       

        #endregion
    }
}