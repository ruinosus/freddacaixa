using System.Collections.Generic;
using ModuloBasico;

namespace Controladores.Interfaces
{
    public interface IIndexControlador
    {
        /// <summary>
        /// Método responsável por incluir um index no sistema.
        /// </summary>
        /// <param name="index">Objeto do tipo index a ser incluido.</param>
        void Incluir(Index index);

        /// <summary>
        /// Método responsável por excluir um index do sistema.
        /// </summary>
        /// <param name="index">Objeto do tipo index a ser excluido.</param>
        void Excluir(Index index);

        /// <summary>
        /// Método reponsável por alterar um index do sistema.
        /// </summary>
        /// <param name="index">Objeto do tipo index a ser alterado.</param>
        void Alterar(Index index);

        /// <summary>
        /// Método responsável por consultar perfis do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="index">Objeto do tipo index que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os perfis cadastrados.</returns>
        List<Index> Consultar(Index index, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todos os comentários do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os indexs cadastrados.</returns>
        List<Index> Consultar();              
    }
}