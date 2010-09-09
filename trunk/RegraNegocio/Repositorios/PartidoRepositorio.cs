using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorios.Interfaces;
using ModuloBasico;
using RegraNegocio.ModuloBasico;

namespace Repositorios
{
    public class PartidoRepositorio : IPartidoRepositorio
    {
        #region Atributos

        FredDaCaixaEntities db;

        #endregion

        #region Métodos da Interface

        public void Incluir(Partido partido)
        {
            db.AddToPartido(partido);
        }

        public void Excluir(Partido partido)
        {
            Partido partidoAux = new Partido();
            partidoAux.ID = partido.ID;
            List<Partido> resultado = this.Consultar(partidoAux, TipoPesquisa.E);
            partidoAux = resultado[0];
            db.DeleteObject(partidoAux);

        }

        public void Alterar(Partido partido)
        {
            Partido partidoAux = new Partido();
            partidoAux.ID = partido.ID;
            List<Partido> resultado = this.Consultar(partidoAux, TipoPesquisa.E);
            partidoAux = resultado[0];

            partidoAux.Corpo = partido.Corpo;
            partidoAux.SubTitulo = partido.SubTitulo;
            partidoAux.Titulo = partido.Titulo;

        }

        public List<Partido> Consultar(Partido partido, TipoPesquisa tipoPesquisa)
        {
            List<Partido> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (partido.ID != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.ID == partido.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(partido.Titulo))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Titulo.Contains(partido.Titulo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(partido.SubTitulo))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.SubTitulo.Contains(partido.SubTitulo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }   
                        
                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (partido.ID != 0)
                        {

                            resultado.AddRange((from p in resultado
                                                where
                                                p.ID == partido.ID
                                                select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(partido.Titulo))
                        {

                            resultado.AddRange((from p in resultado
                                                where
                                                p.Titulo.Contains(partido.Titulo)
                                                select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }


                        if (!string.IsNullOrEmpty(partido.SubTitulo))
                        {

                            resultado.AddRange((from p in resultado
                                                where
                                                p.SubTitulo.Contains(partido.SubTitulo)
                                                select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }   

                        
                        break;
                    }
                #endregion
            }

            return resultado;
        }

        public List<Partido> Consultar()
        {
            return db.Partido.ToList();
        }

        public void Confirmar()
        {
            db.SaveChanges();
        }

        #endregion

        #region Construtor
        public PartidoRepositorio(FredDaCaixaEntities db)
        {
            this.db = db;
        }

        public PartidoRepositorio()
        {
            this.db =new FredDaCaixaEntities();
        }
        #endregion
    }
}