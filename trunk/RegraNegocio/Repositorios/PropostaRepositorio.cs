using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorios.Interfaces;
using ModuloBasico;
using RegraNegocio.ModuloBasico;

namespace Repositorios
{
    public class PropostaRepositorio : IPropostaRepositorio
    {
        #region Atributos

        FredDaCaixaEntities db;

        #endregion

        #region Métodos da Interface

        public void Incluir(Proposta proposta)
        {
            db.AddToProposta(proposta);
        }

        public void Excluir(Proposta proposta)
        {
            Proposta propostaAux = new Proposta();
            propostaAux.ID = proposta.ID;
            List<Proposta> resultado = this.Consultar(propostaAux, TipoPesquisa.E);
            propostaAux = resultado[0];
            db.DeleteObject(propostaAux);
        }

        public void Alterar(Proposta proposta)
        {
            Proposta propostaAux = new Proposta();
            propostaAux.ID = proposta.ID;
            List<Proposta> resultado = this.Consultar(propostaAux, TipoPesquisa.E);
            propostaAux = resultado[0];

            propostaAux.Corpo = proposta.Corpo;
            propostaAux.SubTitulo = proposta.SubTitulo;
            propostaAux.Titulo = proposta.Titulo;

        }

        public List<Proposta> Consultar(Proposta proposta, TipoPesquisa tipoPesquisa)
        {
            List<Proposta> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (proposta.ID != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.ID == proposta.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(proposta.Titulo))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Titulo.Contains(proposta.Titulo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(proposta.SubTitulo))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.SubTitulo.Contains(proposta.SubTitulo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }   
                        
                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (proposta.ID != 0)
                        {

                            resultado.AddRange((from p in resultado
                                                where
                                                p.ID == proposta.ID
                                                select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(proposta.Titulo))
                        {

                            resultado.AddRange((from p in resultado
                                                where
                                                p.Titulo.Contains(proposta.Titulo)
                                                select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }


                        if (!string.IsNullOrEmpty(proposta.SubTitulo))
                        {

                            resultado.AddRange((from p in resultado
                                                where
                                                p.SubTitulo.Contains(proposta.SubTitulo)
                                                select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }   

                        
                        break;
                    }
                #endregion
            }

            return resultado;
        }

        public List<Proposta> Consultar()
        {
            return db.Proposta.ToList();
        }

        public void Confirmar()
        {
            db.SaveChanges();
        }

        #endregion

        #region Construtor
        public PropostaRepositorio(FredDaCaixaEntities db)
        {
            this.db = db;
        }

        public PropostaRepositorio()
        {
            this.db =new FredDaCaixaEntities();
        }
        #endregion
    }
}