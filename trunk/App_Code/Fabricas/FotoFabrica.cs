using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorios.Interfaces;
using Repositorios;


namespace Fabricas
{
    /// <summary>
    /// Classe FotoFabrica
    /// </summary>
    public class FotoFabrica
    {
        #region Atributos
        private static IFotoRepositorio iFotoRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IFotoRepositorio.
        /// </summary>
        public static IFotoRepositorio IFotoInstance
        {
            get
            {
                iFotoRepositorioInstance = new FotoRepositorio();
                return iFotoRepositorioInstance;
            }

        }
        #endregion
    }
}