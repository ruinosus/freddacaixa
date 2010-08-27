using System.Collections.Generic;
using ModuloBasico;

namespace Repositorios.Interfaces
{
    public interface IGaleriaRepositorio
    {
        /// <summary>
        /// Método responsável por incluir um galeria no sistema.
        /// </summary>
        /// <param name="galeria">Objeto do tipo galeria a ser incluido.</param>
        void Incluir(Galeria galeria);

        /// <summary>
        /// Método responsável por excluir um galeria do sistema.
        /// </summary>
        /// <param name="galeria">Objeto do tipo galeria a ser excluido.</param>
        void Excluir(Galeria galeria);

        /// <summary>
        /// Método reponsável por alterar um galeria do sistema.
        /// </summary>
        /// <param name="galeria">Objeto do tipo galeria a ser alterado.</param>
        void Alterar(Galeria galeria);

        /// <summary>
        /// Método responsável por consultar perfis do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="galeria">Objeto do tipo galeria que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os perfis cadastrados.</returns>
        List<Galeria> Consultar(Galeria galeria, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todos os comentários do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os galerias cadastrados.</returns>
        List<Galeria> Consultar();

        /// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
        void Confirmar();
    }
}