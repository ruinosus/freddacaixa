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
    public class VideoControlador : Singleton<VideoControlador>, IVideoControlador
    {
        #region Atributos
        private IVideoRepositorio videoRepositorio = null;
        #endregion

        #region Construtor
        public VideoControlador()
        {
            videoRepositorio = VideoFabrica.IVideoInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Video video)
        {
            try
            {
                this.videoRepositorio.Incluir(video);
                this.videoRepositorio.Confirmar();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Video video)
        {
            try
            {
                this.videoRepositorio.Excluir(video);
                this.videoRepositorio.Confirmar();
            }
            catch (Exception e)
            {

                throw e;
            }
  
        }

        public void Alterar(Video video)
        {
            this.videoRepositorio.Alterar(video);
            this.videoRepositorio.Confirmar();
        }

        public List<Video> Consultar(Video video, TipoPesquisa tipoPesquisa)
        {
            List<Video> videoList = this.videoRepositorio.Consultar(video, tipoPesquisa);

            return videoList;
        }

        public List<Video> Consultar()
        {
            List<Video> videoList = videoRepositorio.Consultar();

            return videoList;
        }

       

        #endregion
    }
}