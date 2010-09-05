using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorios.Interfaces;
using ModuloBasico;
using RegraNegocio.ModuloBasico;

namespace Repositorios
{
    public class GaleriaRepositorio : IGaleriaRepositorio
    {
        #region Atributos

        FredDaCaixaEntities db;

        #endregion

        #region Métodos da Interface

        public void Incluir(Galeria galeria)
        {
            db.AddToGaleria(galeria);
        }

        public void Excluir(Galeria galeria)
        {
            Galeria galeriaAux = new Galeria();
            galeriaAux.ID = galeria.ID;
            List<Galeria> resultado = this.Consultar(galeriaAux, TipoPesquisa.E);
            galeriaAux = resultado[0];
            db.DeleteObject(galeriaAux);
        }

        public void Alterar(Galeria galeria)
        {
            Galeria galeriaAux = new Galeria();
            galeriaAux.ID = galeria.ID;
            List<Galeria> resultado = this.Consultar(galeriaAux, TipoPesquisa.E);

            galeriaAux = resultado[0];
            galeriaAux.Titulo = galeria.Titulo;
            galeriaAux.Legenda = galeria.Legenda;
            galeriaAux.ImagemUrl = galeria.ImagemUrl;
            
        }

        public List<Galeria> Consultar(Galeria galeria, TipoPesquisa tipoPesquisa)
        {
            List<Galeria> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (galeria.ID != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.ID == galeria.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(galeria.Titulo))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Titulo.Contains(galeria.Titulo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }

                       
                        
                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (galeria.ID != 0)
                        {

                            resultado.AddRange((from p in resultado
                                                where
                                                p.ID == galeria.ID
                                                select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(galeria.Titulo))
                        {

                            resultado.AddRange((from p in resultado
                                                where
                                                p.Titulo.Contains(galeria.Titulo)
                                                select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }


                      

                        
                        break;
                    }
                #endregion
            }

            return resultado;
        }

        public List<Galeria> Consultar()
        {
            return db.Galeria.ToList();
        }

        public void Confirmar()
        {
            db.SaveChanges();
        }

        #endregion

        #region Construtor
        public GaleriaRepositorio(FredDaCaixaEntities db)
        {
            this.db = db;
        }

        public GaleriaRepositorio()
        {
            this.db =new FredDaCaixaEntities();
        }
        #endregion
    }
}