using System.Collections.Generic;
using ModuloBasico;
using RegraNegocio.ModuloBasico;

namespace Controladores.Interfaces
{
    public interface ILiderControlador
    {
        /// <summary>
        /// Método responsável por incluir um lider no sistema.
        /// </summary>
        /// <param name="lider">Objeto do tipo lider a ser incluido.</param>
        void Incluir(Lider lider);

        /// <summary>
        /// Método responsável por excluir um lider do sistema.
        /// </summary>
        /// <param name="lider">Objeto do tipo lider a ser excluido.</param>
        void Excluir(Lider lider);

        /// <summary>
        /// Método reponsável por alterar um lider do sistema.
        /// </summary>
        /// <param name="lider">Objeto do tipo lider a ser alterado.</param>
        void Alterar(Lider lider);

        /// <summary>
        /// Método responsável por consultar perfis do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="lider">Objeto do tipo lider que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os perfis cadastrados.</returns>
        List<Lider> Consultar(Lider lider, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todos os comentários do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os liders cadastrados.</returns>
        List<Lider> Consultar();              
    }
}