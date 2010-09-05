using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorios.Interfaces;
using Repositorios;


namespace Fabricas
{
    /// <summary>
    /// Classe IndexFabrica
    /// </summary>
    public class IndexFabrica
    {
        #region Atributos
        private static IIndexRepositorio iIndexRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IIndexRepositorio.
        /// </summary>
        public static IIndexRepositorio IIndexInstance
        {
            get
            {
                iIndexRepositorioInstance = new IndexRepositorio();
                return iIndexRepositorioInstance;
            }

        }
        #endregion
    }
}