using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ModuloBasico;
using Fabricas;
using Repositorios.Interfaces;
namespace Controladores.Interfaces
{
    public class PropostaControlador : Singleton<PropostaControlador>, IPropostaControlador
    {
        #region Atributos
        private IPropostaRepositorio propostaRepositorio = null;
        #endregion

        #region Construtor
        public PropostaControlador()
        {
            propostaRepositorio = PropostaFabrica.IPropostaInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Proposta proposta)
        {
            try
            {
                this.propostaRepositorio.Incluir(proposta);
                this.propostaRepositorio.Confirmar();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Proposta proposta)
        {
            try
            {
                this.propostaRepositorio.Excluir(proposta);
                this.propostaRepositorio.Confirmar();
            }
            catch (Exception e)
            {

                throw e;
            }
  
        }

        public void Alterar(Proposta proposta)
        {
            this.propostaRepositorio.Alterar(proposta);
            this.propostaRepositorio.Confirmar();
        }

        public List<Proposta> Consultar(Proposta proposta, TipoPesquisa tipoPesquisa)
        {
            List<Proposta> propostaList = this.propostaRepositorio.Consultar(proposta, tipoPesquisa);

            return propostaList;
        }

        public List<Proposta> Consultar()
        {
            List<Proposta> propostaList = propostaRepositorio.Consultar();

            return propostaList;
        }

       

        #endregion
    }
}