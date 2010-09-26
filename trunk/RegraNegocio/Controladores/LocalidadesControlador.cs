using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ModuloBasico;
using Fabricas;
using Repositorios.Interfaces;
using RegraNegocio.ModuloBasico;
namespace Controladores.Interfaces
{
    public class LocalidadesControlador : Singleton<LocalidadesControlador>, ILocalidadesControlador
    {
        #region Atributos
        private ILocalidadesRepositorio localidadesRepositorio = null;
        #endregion

        #region Construtor
        public LocalidadesControlador()
        {
            localidadesRepositorio = LocalidadesFabrica.ILocalidadesInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Localidades localidades)
        {
            try
            {
                this.localidadesRepositorio.Incluir(localidades);
                this.localidadesRepositorio.Confirmar();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Localidades localidades)
        {
            try
            {
                this.localidadesRepositorio.Excluir(localidades);
                this.localidadesRepositorio.Confirmar();
            }
            catch (Exception e)
            {

                throw e;
            }
  
        }

        public void Alterar(Localidades localidades)
        {
            this.localidadesRepositorio.Alterar(localidades);
            this.localidadesRepositorio.Confirmar();
        }

        public List<Localidades> Consultar(Localidades localidades, TipoPesquisa tipoPesquisa)
        {
            List<Localidades> localidadesList = this.localidadesRepositorio.Consultar(localidades, tipoPesquisa);

            return localidadesList;
        }

        public List<Localidades> Consultar()
        {
            List<Localidades> localidadesList = localidadesRepositorio.Consultar();

            return localidadesList;
        }

       

        #endregion
    }
}