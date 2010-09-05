using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorios.Interfaces;
using Repositorios;


namespace Fabricas
{
    /// <summary>
    /// Classe PropostaFabrica
    /// </summary>
    public class PropostaFabrica
    {
        #region Atributos
        private static IPropostaRepositorio iPropostaRepositorioInstance;
        #endregion

        #region Propriedades
        /// <summary>
        /// Instancia da interface IPropostaRepositorio.
        /// </summary>
        public static IPropostaRepositorio IPropostaInstance
        {
            get
            {
                iPropostaRepositorioInstance = new PropostaRepositorio();
                return iPropostaRepositorioInstance;
            }

        }
        #endregion
    }
}