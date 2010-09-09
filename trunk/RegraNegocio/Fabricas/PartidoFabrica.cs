using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorios.Interfaces;
using Repositorios;


namespace Fabricas
{
    /// <summary>
    /// Classe PartidoFabrica
    /// </summary>
    public class PartidoFabrica
    {
        #region Atributos
        private static IPartidoRepositorio iPartidoRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IPartidoRepositorio.
        /// </summary>
        public static IPartidoRepositorio IPartidoInstance
        {
            get
            {
                iPartidoRepositorioInstance = new PartidoRepositorio();
                return iPartidoRepositorioInstance;
            }

        }
        #endregion
    }
}