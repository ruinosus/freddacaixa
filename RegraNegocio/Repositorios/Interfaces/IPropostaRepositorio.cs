using System.Collections.Generic;
using ModuloBasico;
using RegraNegocio.ModuloBasico;

namespace Repositorios.Interfaces
{
    public interface IPropostaRepositorio
    {
        /// <summary>
        /// Método responsável por incluir um proposta no sistema.
        /// </summary>
        /// <param name="proposta">Objeto do tipo proposta a ser incluido.</param>
        void Incluir(Proposta proposta);

        /// <summary>
        /// Método responsável por excluir um proposta do sistema.
        /// </summary>
        /// <param name="proposta">Objeto do tipo proposta a ser excluido.</param>
        void Excluir(Proposta proposta);

        /// <summary>
        /// Método reponsável por alterar um proposta do sistema.
        /// </summary>
        /// <param name="proposta">Objeto do tipo proposta a ser alterado.</param>
        void Alterar(Proposta proposta);

        /// <summary>
        /// Método responsável por consultar perfis do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="proposta">Objeto do tipo proposta que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os perfis cadastrados.</returns>
        List<Proposta> Consultar(Proposta proposta, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todos os comentários do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os propostas cadastrados.</returns>
        List<Proposta> Consultar();

        /// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
        void Confirmar();
    }
}