using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ModuloBasico;
using Fabricas;
using Repositorios.Interfaces;
namespace Controladores.Interfaces
{
    public class FotoControlador : Singleton<FotoControlador>, IFotoControlador
    {
        #region Atributos
        private IFotoRepositorio fotoRepositorio = null;
        #endregion

        #region Construtor
        public FotoControlador()
        {
            fotoRepositorio = FotoFabrica.IFotoInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Foto foto)
        {
            try
            {
                this.fotoRepositorio.Incluir(foto);
                this.fotoRepositorio.Confirmar();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Foto foto)
        {
            try
            {
                this.fotoRepositorio.Excluir(foto);
                this.fotoRepositorio.Confirmar();
            }
            catch (Exception e)
            {

                throw e;
            }
  
        }

        public void Alterar(Foto foto)
        {
            this.fotoRepositorio.Alterar(foto);
            this.fotoRepositorio.Confirmar();
        }

        public List<Foto> Consultar(Foto foto, TipoPesquisa tipoPesquisa)
        {
            List<Foto> fotoList = this.fotoRepositorio.Consultar(foto, tipoPesquisa);

            return fotoList;
        }

        public List<Foto> Consultar()
        {
            List<Foto> fotoList = fotoRepositorio.Consultar();

            return fotoList;
        }

       

        #endregion
    }
}