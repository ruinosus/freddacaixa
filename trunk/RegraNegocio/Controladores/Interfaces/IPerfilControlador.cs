using System.Collections.Generic;
using ModuloBasico;
using RegraNegocio.ModuloBasico;

namespace Controladores.Interfaces
{
    public interface IPerfilControlador
    {
        /// <summary>
        /// Método responsável por incluir um perfil no sistema.
        /// </summary>
        /// <param name="perfil">Objeto do tipo perfil a ser incluido.</param>
        void Incluir(Perfil perfil);

        /// <summary>
        /// Método responsável por excluir um perfil do sistema.
        /// </summary>
        /// <param name="perfil">Objeto do tipo perfil a ser excluido.</param>
        void Excluir(Perfil perfil);

        /// <summary>
        /// Método reponsável por alterar um perfil do sistema.
        /// </summary>
        /// <param name="perfil">Objeto do tipo perfil a ser alterado.</param>
        void Alterar(Perfil perfil);

        /// <summary>
        /// Método responsável por consultar perfis do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="perfil">Objeto do tipo perfil que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os perfis cadastrados.</returns>
        List<Perfil> Consultar(Perfil perfil, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todos os comentários do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os perfils cadastrados.</returns>
        List<Perfil> Consultar();              
    }
}