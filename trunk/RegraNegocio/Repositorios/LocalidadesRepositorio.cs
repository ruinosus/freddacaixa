using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorios.Interfaces;
using ModuloBasico;
using RegraNegocio.ModuloBasico;

namespace Repositorios
{
    public class LocalidadesRepositorio : ILocalidadesRepositorio
    {
        #region Atributos

        FredDaCaixaEntities db;

        #endregion

        #region Métodos da Interface

        public void Incluir(Localidades localidade)
        {
            db.AddToLocalidades(localidade);
        }

        public void Excluir(Localidades localidade)
        {
            Localidades localidadeAux = new Localidades();
            localidadeAux.ID = localidade.ID;
            List<Localidades> resultado = this.Consultar(localidadeAux, TipoPesquisa.E);
            localidadeAux = resultado[0];
            db.DeleteObject(localidadeAux);

        }

        public void Alterar(Localidades localidade)
        {
            Localidades localidadeAux = new Localidades();
            localidadeAux.ID = localidade.ID;
            List<Localidades> resultado = this.Consultar(localidadeAux, TipoPesquisa.E);
            localidadeAux = resultado[0];



        }

        public List<Localidades> Consultar(Localidades localidade, TipoPesquisa tipoPesquisa)
        {
            List<Localidades> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (localidade.ID != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.ID == localidade.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(localidade.Descricao))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Descricao.Contains(localidade.Descricao)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }

                    
                        
                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (localidade.ID != 0)
                        {

                            resultado.AddRange((from p in resultado
                                                where
                                                p.ID == localidade.ID
                                                select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(localidade.Descricao))
                        {

                            resultado.AddRange((from p in resultado
                                                where
                                                p.Descricao.Contains(localidade.Descricao)
                                                select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }



                        
                        break;
                    }
                #endregion
            }

            return resultado;
        }

        public List<Localidades> Consultar()
        {
            return db.Localidades.ToList();
        }

        public void Confirmar()
        {
            db.SaveChanges();
        }

        #endregion

        #region Construtor
        public LocalidadesRepositorio(FredDaCaixaEntities db)
        {
            this.db = db;
        }

        public LocalidadesRepositorio()
        {
            this.db =new FredDaCaixaEntities();
        }
        #endregion
    }
}