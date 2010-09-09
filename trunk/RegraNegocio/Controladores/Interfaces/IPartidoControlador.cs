using System.Collections.Generic;
using ModuloBasico;
using RegraNegocio.ModuloBasico;

namespace Controladores.Interfaces
{
    public interface IPartidoControlador
    {
        /// <summary>
        /// Método responsável por incluir um partido no sistema.
        /// </summary>
        /// <param name="partido">Objeto do tipo partido a ser incluido.</param>
        void Incluir(Partido partido);

        /// <summary>
        /// Método responsável por excluir um partido do sistema.
        /// </summary>
        /// <param name="partido">Objeto do tipo partido a ser excluido.</param>
        void Excluir(Partido partido);

        /// <summary>
        /// Método reponsável por alterar um partido do sistema.
        /// </summary>
        /// <param name="partido">Objeto do tipo partido a ser alterado.</param>
        void Alterar(Partido partido);

        /// <summary>
        /// Método responsável por consultar perfis do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="partido">Objeto do tipo partido que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os perfis cadastrados.</returns>
        List<Partido> Consultar(Partido partido, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todos os comentários do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os partidos cadastrados.</returns>
        List<Partido> Consultar();              
    }
}