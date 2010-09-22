using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorios.Interfaces;
using ModuloBasico;
using RegraNegocio.ModuloBasico;

namespace Repositorios
{
    public class VideoRepositorio : IVideoRepositorio
    {
        #region Atributos

        FredDaCaixaEntities db;

        #endregion

        #region Métodos da Interface

        public void Incluir(Video video)
        {
            db.AddToVideo(video);
        }

        public void Excluir(Video video)
        {
            Video videoAux = new Video();
            videoAux.ID = video.ID;
            List<Video> resultado = this.Consultar(videoAux, TipoPesquisa.E);
            videoAux = resultado[0];
            db.DeleteObject(videoAux);

        }

        public void Alterar(Video video)
        {
            Video videoAux = new Video();
            videoAux.ID = video.ID;
            List<Video> resultado = this.Consultar(videoAux, TipoPesquisa.E);
            videoAux = resultado[0];

            videoAux.Corpo = video.Corpo;
            videoAux.SubTitulo = video.SubTitulo;
            videoAux.Titulo = video.Titulo;

        }

        public List<Video> Consultar(Video video, TipoPesquisa tipoPesquisa)
        {
            List<Video> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (video.ID != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.ID == video.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(video.Titulo))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Titulo.Contains(video.Titulo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(video.SubTitulo))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.SubTitulo.Contains(video.SubTitulo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }   
                        
                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (video.ID != 0)
                        {

                            resultado.AddRange((from p in resultado
                                                where
                                                p.ID == video.ID
                                                select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(video.Titulo))
                        {

                            resultado.AddRange((from p in resultado
                                                where
                                                p.Titulo.Contains(video.Titulo)
                                                select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }


                        if (!string.IsNullOrEmpty(video.SubTitulo))
                        {

                            resultado.AddRange((from p in resultado
                                                where
                                                p.SubTitulo.Contains(video.SubTitulo)
                                                select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }   

                        
                        break;
                    }
                #endregion
            }

            return resultado;
        }

        public List<Video> Consultar()
        {
            return db.Video.ToList();
        }

        public void Confirmar()
        {
            db.SaveChanges();
        }

        #endregion

        #region Construtor
        public VideoRepositorio(FredDaCaixaEntities db)
        {
            this.db = db;
        }

        public VideoRepositorio()
        {
            this.db =new FredDaCaixaEntities();
        }
        #endregion
    }
}