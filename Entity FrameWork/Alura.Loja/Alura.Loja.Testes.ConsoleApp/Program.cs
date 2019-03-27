﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //GravarUsandoAdoNet();
            //GravarUsandoEntity();
            //RecuperarProdutos();
            //ExcluirProdutos();
            //AtualizarProduto();

            Console.ReadLine();
        }

        private static void AtualizarProduto()
        {
            GravarUsandoEntity();
            RecuperarProdutos();

            using(var contexto = new ProdutoDAOEntity())
            {
                Produto primeiroProduto = contexto.Produtos().First();
                primeiroProduto.Nome = "HP5";
                contexto.Atualizar(primeiroProduto);
            }
            RecuperarProdutos();
        }

        private static void ExcluirProdutos()
        {
            using(var contexto = new ProdutoDAOEntity())
            {
                var produtos = contexto.Produtos();

                foreach (var item in produtos)
                {
                    contexto.Remover(item);
                }                
            }
        }

        private static void RecuperarProdutos()
        {
            using(var contexto = new ProdutoDAOEntity())
            {
                var produtos = contexto.Produtos();

                if(produtos.Count == 0)
                {
                    Console.WriteLine("não há produtos!");
                    return;
                }
                else
                {
                    Console.WriteLine($"Foram encontrados {produtos.Count} produto(s).");
                }

                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }
            }
        }

        private static void GravarUsandoEntity()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.PrecoUnitario = 19.89;

            using (var contexto = new ProdutoDAOEntity())
            {
                contexto.Adicionar(p);
            }
        }
    }
}
