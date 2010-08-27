using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorios.Interfaces;
using ModuloBasico;

namespace Repositorios
{
    public class FotoRepositorio : IFotoRepositorio
    {
        #region Atributos

        FredDaCaixaEntities db ;

        #endregion

        #region Métodos da Interface

        public void Incluir(Foto foto)
        {
            db.AddToFotoSet(foto);
        }

        public void Excluir(Foto foto)
        {
            Foto fotoAux = new Foto();
            fotoAux.ID = foto.ID;
            List<Foto> resultado = this.Consultar(fotoAux, TipoPesquisa.E);
            fotoAux = resultado[0];
            db.DeleteObject(fotoAux);
        }

        public void Alterar(Foto foto)
        {
            Foto fotoAux = new Foto();
            fotoAux.ID = foto.ID;
            List<Foto> resultado = this.Consultar(fotoAux, TipoPesquisa.E);

            fotoAux = resultado[0];
            fotoAux.Titulo = foto.Titulo;
            fotoAux.Legenda = foto.Legenda;
            fotoAux.ImagemUrl = foto.ImagemUrl;
            
        }

        public List<Foto> Consultar(Foto foto, TipoPesquisa tipoPesquisa)
        {
            List<Foto> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (foto.ID != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.ID == foto.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(foto.Titulo))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Titulo.Contains(foto.Titulo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }

                       
                        
                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (foto.ID != 0)
                        {

                            resultado.AddRange((from p in resultado
                                                where
                                                p.ID == foto.ID
                                                select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(foto.Titulo))
                        {

                            resultado.AddRange((from p in resultado
                                                where
                                                p.Titulo.Contains(foto.Titulo)
                                                select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }


                      

                        
                        break;
                    }
                #endregion
            }

            return resultado;
        }

        public List<Foto> Consultar()
        {
            return db.FotoSet.ToList();
        }

        public void Confirmar()
        {
            db.SaveChanges(true);
        }

        #endregion

        #region Construtor
        public FotoRepositorio(FredDaCaixaEntities db)
        {
            this.db = db;
        }

        public FotoRepositorio()
        {
            this.db =new FredDaCaixaEntities();
        }
        #endregion
    }
}