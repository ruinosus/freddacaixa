using System.Collections.Generic;
using ModuloBasico;
using RegraNegocio.ModuloBasico;

namespace Repositorios.Interfaces
{
    public interface IFotoRepositorio
    {
        /// <summary>
        /// Método responsável por incluir um foto no sistema.
        /// </summary>
        /// <param name="foto">Objeto do tipo foto a ser incluido.</param>
        void Incluir(Foto foto);

        /// <summary>
        /// Método responsável por excluir um foto do sistema.
        /// </summary>
        /// <param name="foto">Objeto do tipo foto a ser excluido.</param>
        void Excluir(Foto foto);

        /// <summary>
        /// Método reponsável por alterar um foto do sistema.
        /// </summary>
        /// <param name="foto">Objeto do tipo foto a ser alterado.</param>
        void Alterar(Foto foto);

        /// <summary>
        /// Método responsável por consultar perfis do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="foto">Objeto do tipo foto que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os perfis cadastrados.</returns>
        List<Foto> Consultar(Foto foto, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todos os comentários do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os fotos cadastrados.</returns>
        List<Foto> Consultar();

        /// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
        void Confirmar();
    }
}