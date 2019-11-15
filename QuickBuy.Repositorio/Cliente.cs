using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Repostorios
{
    public class Cliente
    {
        public Cliente()
        {
            var UsuarioRepositorio = new UsuarioRepositorio();
            var produto = new Produto();
            var usuario = new Usuario();

            UsuarioRepositorio.Adicionar(usuario);
        }
    }
}
