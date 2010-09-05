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
    public class GaleriaControlador : Singleton<GaleriaControlador>, IGaleriaControlador
    {
        #region Atributos
        private IGaleriaRepositorio galeriaRepositorio = null;
        #endregion

        #region Construtor
        public GaleriaControlador()
        {
            galeriaRepositorio = GaleriaFabrica.IGaleriaInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Galeria galeria)
        {
            try
            {
                this.galeriaRepositorio.Incluir(galeria);
                this.galeriaRepositorio.Confirmar();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Galeria galeria)
        {
            try
            {
                this.galeriaRepositorio.Excluir(galeria);
                this.galeriaRepositorio.Confirmar();
            }
            catch (Exception e)
            {

                throw e;
            }
  
        }

        public void Alterar(Galeria galeria)
        {
            this.galeriaRepositorio.Alterar(galeria);
            this.galeriaRepositorio.Confirmar();
        }

        public List<Galeria> Consultar(Galeria galeria, TipoPesquisa tipoPesquisa)
        {
            List<Galeria> galeriaList = this.galeriaRepositorio.Consultar(galeria, tipoPesquisa);

            return galeriaList;
        }

        public List<Galeria> Consultar()
        {
            List<Galeria> galeriaList = galeriaRepositorio.Consultar();

            return galeriaList;
        }

       

        #endregion
    }
}