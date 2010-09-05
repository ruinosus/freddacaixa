using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repositorios.Interfaces;
using ModuloBasico;
using RegraNegocio.ModuloBasico;

namespace Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        #region Atributos

        FredDaCaixaEntities db ;

        #endregion

        #region Métodos da Interface

        public void Incluir(Usuario usuario)
        {
            db.AddTousuarios(usuario);
        }

        public void Excluir(Usuario usuario)
        {
            Usuario usuarioAux = new Usuario();
            usuarioAux.ID = usuario.ID;
            List<Usuario> resultado = this.Consultar(usuarioAux, TipoPesquisa.E);
            usuarioAux = resultado[0];
            db.DeleteObject(usuarioAux);
        }

        public void Alterar(Usuario usuario)
        {
            Usuario usuarioAux = new Usuario();
            usuarioAux.ID = usuario.ID;
            List<Usuario> resultado = this.Consultar(usuarioAux, TipoPesquisa.E);
            usuarioAux = resultado[0];


            usuarioAux.Login = usuario.Login;
            usuarioAux.Senha = usuario.Senha;

        }

        public List<Usuario> Consultar(Usuario usuario, TipoPesquisa tipoPesquisa)
        {
            List<Usuario> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (usuario.ID != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.ID == usuario.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        // if (!string.IsNullOrEmpty(usuario.Nome))
                        // {

                        //     resultado = ((from p in resultado
                        //                   where
                        //                   p.Nome.Contains(usuario.Nome)
                        //                   select p).ToList());


                        //     resultado = resultado.Distinct().ToList();
                        //}   

                        if (!string.IsNullOrEmpty(usuario.Login) && !string.IsNullOrEmpty(usuario.Senha))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Login.Equals(usuario.Login) && p.Senha.Equals(usuario.Senha)
                                          select p).ToList());
                            resultado = resultado.Distinct().ToList();
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(usuario.Login))
                            {

                                resultado = ((from p in resultado
                                              where
                                              p.Login.Equals(usuario.Login)
                                              select p).ToList());
                                resultado = resultado.Distinct().ToList();
                            }
                        }
                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (usuario.ID != 0)
                        {

                            resultado.AddRange((from p in resultado
                                                where
                                                p.ID == usuario.ID
                                                select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        // if (!string.IsNullOrEmpty(usuario.Nome))
                        // {

                        //     resultado.AddRange((from p in resultado
                        //                   where
                        //                   p.Nome.Contains(usuario.Nome)
                        //                   select p).ToList());


                        //     resultado = resultado.Distinct().ToList();
                        //}   

                        if (!string.IsNullOrEmpty(usuario.Login) && !string.IsNullOrEmpty(usuario.Senha))
                        {

                            resultado.AddRange((from p in resultado
                                                where
                                                p.Login.Equals(usuario.Login) && p.Senha.Equals(usuario.Senha)
                                                select p).ToList());
                            resultado = resultado.Distinct().ToList();
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(usuario.Login))
                            {

                                resultado.AddRange((from p in resultado
                                                    where
                                                    p.Login.Equals(usuario.Login)
                                                    select p).ToList());
                                resultado = resultado.Distinct().ToList();
                            }
                        }
                        break;
                    }
                #endregion
            }

            return resultado;
        }

        public List<Usuario> Consultar()
        {
            return db.usuarios.ToList();
        }

        public void Confirmar()
        {
            db.SaveChanges(true);
        }

        #endregion

        #region Construtor
        public UsuarioRepositorio(FredDaCaixaEntities db)
        {
            this.db = db;
        }

        public UsuarioRepositorio()
        {
            this.db =new FredDaCaixaEntities();
        }
        #endregion
    }
}