using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorios.Interfaces;
using ModuloBasico;
using RegraNegocio.ModuloBasico;

namespace Repositorios
{
    public class PerfilRepositorio : IPerfilRepositorio
    {
        #region Atributos

        FredDaCaixaEntities db;

        #endregion

        #region Métodos da Interface

        public void Incluir(Perfil perfil)
        {
            db.AddToPerfil(perfil);
        }

        public void Excluir(Perfil perfil)
        {
            Perfil perfilAux = new Perfil();
            perfilAux.ID = perfil.ID;
            List<Perfil> resultado = this.Consultar(perfilAux, TipoPesquisa.E);
            perfilAux = resultado[0];
            db.DeleteObject(perfilAux);

        }

        public void Alterar(Perfil perfil)
        {
            Perfil perfilAux = new Perfil();
            perfilAux.ID = perfil.ID;
            List<Perfil> resultado = this.Consultar(perfilAux, TipoPesquisa.E);
            perfilAux = resultado[0];

            perfilAux.Corpo = perfil.Corpo;
            perfilAux.SubTitulo = perfil.SubTitulo;
            perfilAux.Titulo = perfil.Titulo;

        }

        public List<Perfil> Consultar(Perfil perfil, TipoPesquisa tipoPesquisa)
        {
            List<Perfil> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (perfil.ID != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.ID == perfil.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(perfil.Titulo))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Titulo.Contains(perfil.Titulo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(perfil.SubTitulo))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.SubTitulo.Contains(perfil.SubTitulo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }   
                        
                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (perfil.ID != 0)
                        {

                            resultado.AddRange((from p in resultado
                                                where
                                                p.ID == perfil.ID
                                                select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(perfil.Titulo))
                        {

                            resultado.AddRange((from p in resultado
                                                where
                                                p.Titulo.Contains(perfil.Titulo)
                                                select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }


                        if (!string.IsNullOrEmpty(perfil.SubTitulo))
                        {

                            resultado.AddRange((from p in resultado
                                                where
                                                p.SubTitulo.Contains(perfil.SubTitulo)
                                                select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }   

                        
                        break;
                    }
                #endregion
            }

            return resultado;
        }

        public List<Perfil> Consultar()
        {
            return db.Perfil.ToList();
        }

        public void Confirmar()
        {
            db.SaveChanges();
        }

        #endregion

        #region Construtor
        public PerfilRepositorio(FredDaCaixaEntities db)
        {
            this.db = db;
        }

        public PerfilRepositorio()
        {
            this.db =new FredDaCaixaEntities();
        }
        #endregion
    }
}