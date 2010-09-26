using System.Collections.Generic;
using ModuloBasico;
using RegraNegocio.ModuloBasico;

namespace Repositorios.Interfaces
{
    public interface ILocalidadesRepositorio
    {
        /// <summary>
        /// Método responsável por incluir um localidade no sistema.
        /// </summary>
        /// <param name="localidade">Objeto do tipo localidade a ser incluido.</param>
        void Incluir(Localidades localidade);

        /// <summary>
        /// Método responsável por excluir um localidade do sistema.
        /// </summary>
        /// <param name="localidade">Objeto do tipo localidade a ser excluido.</param>
        void Excluir(Localidades localidade);

        /// <summary>
        /// Método reponsável por alterar um localidade do sistema.
        /// </summary>
        /// <param name="localidade">Objeto do tipo localidade a ser alterado.</param>
        void Alterar(Localidades localidade);

        /// <summary>
        /// Método responsável por consultar perfis do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="localidade">Objeto do tipo localidade que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os perfis cadastrados.</returns>
        List<Localidades> Consultar(Localidades localidade, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todos os comentários do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os localidades cadastrados.</returns>
        List<Localidades> Consultar();

        /// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
        void Confirmar();
    }
}