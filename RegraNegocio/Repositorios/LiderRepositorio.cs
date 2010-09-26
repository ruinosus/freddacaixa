using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorios.Interfaces;
using ModuloBasico;
using RegraNegocio.ModuloBasico;

namespace Repositorios
{
    public class LiderRepositorio : ILiderRepositorio
    {
        #region Atributos

        FredDaCaixaEntities db;

        #endregion

        #region Métodos da Interface

        public void Incluir(Lider lider)
        {

            db.AddToLider(lider);
        }

        public void Excluir(Lider lider)
        {
            Lider liderAux = new Lider();
            liderAux.ID = lider.ID;
            List<Lider> resultado = this.Consultar(liderAux, TipoPesquisa.E);
            liderAux = resultado[0];
            db.DeleteObject(liderAux);

        }

        public void Alterar(Lider lider)
        {
            Lider liderAux = new Lider();
            liderAux.ID = lider.ID;
            List<Lider> resultado = this.Consultar(liderAux, TipoPesquisa.E);
            liderAux = resultado[0];

            liderAux.Bairro = lider.Bairro;
            liderAux.Cep = lider.Cep;
            liderAux.Cidade = lider.Cidade;
            liderAux.Complemento = lider.Complemento;
            liderAux.Cpf = lider.Cpf;
            liderAux.Email = lider.Email;
            liderAux.Estado = lider.Estado;
            liderAux.Local = lider.Local;
            liderAux.Logradouro = lider.Logradouro;
            liderAux.Nome = lider.Nome;
            liderAux.Numero = lider.Numero;
            liderAux.Obs = lider.Obs;
            liderAux.Rg = lider.Rg;
            liderAux.Telefone1 = lider.Telefone1;
            liderAux.Telefone2 = lider.Telefone2;
            liderAux.Titulo = lider.Titulo;
            liderAux.Serie = lider.Serie;
            liderAux.Zona = lider.Zona;

        }

        public List<Lider> Consultar(Lider lider, TipoPesquisa tipoPesquisa)
        {
            List<Lider> resultado = Consultar();

            
            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (lider.ID != 0)
                        {
                            
                            resultado = ((from p in resultado
                                          where
                                          p.ID == lider.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(lider.Nome))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Nome.Contains(lider.Nome)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(lider.Local))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Local.Contains(lider.Local)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }

                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (lider.ID != 0)
                        {

                            resultado.AddRange((from p in resultado
                                                where
                                                p.ID == lider.ID
                                                select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(lider.Nome))
                        {

                            resultado.AddRange((from p in resultado
                                                where
                                                p.Nome.Contains(lider.Nome)
                                                select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }


                        if (!string.IsNullOrEmpty(lider.Local))
                        {

                            resultado.AddRange((from p in resultado
                                                where
                                                p.Local.Contains(lider.Local)
                                                select p).ToList());


                            resultado = resultado.Distinct().ToList();
                        }


                        break;
                    }
                #endregion
            }

            return resultado;
        }

        public List<Lider> Consultar()
        {
            return db.Lider.ToList();
        }

        public void Confirmar()
        {
            db.SaveChanges();
        }

        #endregion

        #region Construtor
        public LiderRepositorio(FredDaCaixaEntities db)
        {
            this.db = db;
        }

        public LiderRepositorio()
        {
            this.db = new FredDaCaixaEntities();
        }
        #endregion
    }
}