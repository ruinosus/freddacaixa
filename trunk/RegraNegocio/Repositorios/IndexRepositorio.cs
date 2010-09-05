using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorios.Interfaces;
using ModuloBasico;
using RegraNegocio.ModuloBasico;

namespace Repositorios
{
    public class IndexRepositorio : IIndexRepositorio
    {
        #region Atributos

        FredDaCaixaEntities db;

        #endregion

        #region Métodos da Interface

        public void Incluir(Index index)
        {
            db.AddToindices(index);
        }

        public void Excluir(Index index)
        {
            Index indexAux = new Index();
            indexAux.ID = index.ID;
            List<Index> resultado = this.Consultar(indexAux, TipoPesquisa.E);
            indexAux = resultado[0];
            db.DeleteObject(indexAux);

        }

        public void Alterar(Index index)
        {
            Index indexAux = new Index();
            indexAux.ID = index.ID;
            List<Index> resultado = this.Consultar(indexAux, TipoPesquisa.E);
            indexAux = resultado[0];

            indexAux.Corpo = index.Corpo;
            indexAux.SubTitulo = index.SubTitulo;
            indexAux.Titulo = index.Titulo;

        }

        public List<Index> Consultar(Index index, TipoPesquisa tipoPesquisa)
        {
            List<Index> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (index.ID != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.ID == index.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(index.Titulo))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Titulo.Contains(index.Titulo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(index.SubTitulo))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.SubTitulo.Contains(index.SubTitulo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }   
                        
                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (index.ID != 0)
                        {

                            resultado.AddRange((from p in resultado
                                                where
                                                p.ID == index.ID
                                                select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(index.Titulo))
                        {

                            resultado.AddRange((from p in resultado
                                                where
                                                p.Titulo.Contains(index.Titulo)
                                                select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }


                        if (!string.IsNullOrEmpty(index.SubTitulo))
                        {

                            resultado.AddRange((from p in resultado
                                                where
                                                p.SubTitulo.Contains(index.SubTitulo)
                                                select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }   

                        
                        break;
                    }
                #endregion
            }

            return resultado;
        }

        public List<Index> Consultar()
        {
            return db.indices.ToList();
        }

        public void Confirmar()
        {
            db.SaveChanges();
        }

        #endregion

        #region Construtor
        public IndexRepositorio(FredDaCaixaEntities db)
        {
            this.db = db;
        }

        public IndexRepositorio()
        {
            this.db =new FredDaCaixaEntities();
        }
        #endregion
    }
}