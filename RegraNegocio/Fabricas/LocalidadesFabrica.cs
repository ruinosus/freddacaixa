using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorios.Interfaces;
using Repositorios;


namespace Fabricas
{
    /// <summary>
    /// Classe LocalidadeFabrica
    /// </summary>
    public class LocalidadesFabrica
    {
        #region Atributos
        private static ILocalidadesRepositorio iLocalidadesRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface ILocalidadeRepositorio.
        /// </summary>
        public static ILocalidadesRepositorio ILocalidadesInstance
        {
            get
            {
                iLocalidadesRepositorioInstance = new LocalidadesRepositorio();
                return iLocalidadesRepositorioInstance;
            }

        }
        #endregion
    }
}