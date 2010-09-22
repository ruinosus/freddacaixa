using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorios.Interfaces;
using Repositorios;


namespace Fabricas
{
    /// <summary>
    /// Classe VideoFabrica
    /// </summary>
    public class VideoFabrica
    {
        #region Atributos
        private static IVideoRepositorio iVideoRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IVideoRepositorio.
        /// </summary>
        public static IVideoRepositorio IVideoInstance
        {
            get
            {
                iVideoRepositorioInstance = new VideoRepositorio();
                return iVideoRepositorioInstance;
            }

        }
        #endregion
    }
}