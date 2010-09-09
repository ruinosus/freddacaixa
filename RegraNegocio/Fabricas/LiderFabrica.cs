using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorios.Interfaces;
using Repositorios;


namespace Fabricas
{
    /// <summary>
    /// Classe LiderFabrica
    /// </summary>
    public class LiderFabrica
    {
        #region Atributos
        private static ILiderRepositorio iLiderRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface ILiderRepositorio.
        /// </summary>
        public static ILiderRepositorio ILiderInstance
        {
            get
            {
                iLiderRepositorioInstance = new LiderRepositorio();
                return iLiderRepositorioInstance;
            }

        }
        #endregion
    }
}