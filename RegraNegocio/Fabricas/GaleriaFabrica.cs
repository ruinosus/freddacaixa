using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorios.Interfaces;
using Repositorios;


namespace Fabricas
{
    /// <summary>
    /// Classe GaleriaFabrica
    /// </summary>
    public class GaleriaFabrica
    {
        #region Atributos
        private static IGaleriaRepositorio iGaleriaRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IGaleriaRepositorio.
        /// </summary>
        public static IGaleriaRepositorio IGaleriaInstance
        {
            get
            {
                iGaleriaRepositorioInstance = new GaleriaRepositorio();
                return iGaleriaRepositorioInstance;
            }

        }
        #endregion
    }
}