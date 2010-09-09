using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorios.Interfaces;
using Repositorios;


namespace Fabricas
{
    /// <summary>
    /// Classe PerfilFabrica
    /// </summary>
    public class PerfilFabrica
    {
        #region Atributos
        private static IPerfilRepositorio iPerfilRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IPerfilRepositorio.
        /// </summary>
        public static IPerfilRepositorio IPerfilInstance
        {
            get
            {
                iPerfilRepositorioInstance = new PerfilRepositorio();
                return iPerfilRepositorioInstance;
            }

        }
        #endregion
    }
}