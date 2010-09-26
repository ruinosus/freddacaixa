using System.Collections.Generic;
using ModuloBasico;
using RegraNegocio.ModuloBasico;

namespace Controladores.Interfaces
{
    public interface ILocalidadesControlador
    {
        /// <summary>
        /// Método responsável por incluir um localidades no sistema.
        /// </summary>
        /// <param name="localidades">Objeto do tipo localidades a ser incluido.</param>
        void Incluir(Localidades localidades);

        /// <summary>
        /// Método responsável por excluir um localidades do sistema.
        /// </summary>
        /// <param name="localidades">Objeto do tipo localidades a ser excluido.</param>
        void Excluir(Localidades localidades);

        /// <summary>
        /// Método reponsável por alterar um localidades do sistema.
        /// </summary>
        /// <param name="localidades">Objeto do tipo localidades a ser alterado.</param>
        void Alterar(Localidades localidades);

        /// <summary>
        /// Método responsável por consultar perfis do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="localidades">Objeto do tipo localidades que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os perfis cadastrados.</returns>
        List<Localidades> Consultar(Localidades localidades, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todos os comentários do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os localidadess cadastrados.</returns>
        List<Localidades> Consultar();              
    }
}