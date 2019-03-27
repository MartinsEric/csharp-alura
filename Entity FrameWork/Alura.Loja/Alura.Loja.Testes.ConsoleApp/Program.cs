using System;
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
            AtualizarProduto();

            Console.ReadLine();
        }

        private static void AtualizarProduto()
        {
            GravarUsandoEntity();
            RecuperarProdutos();

            using(var contexto = new LojaContext())
            {
                Produto primeiroProduto = contexto.Produtos.First();
                primeiroProduto.Nome = "HP5";
                contexto.Produtos.Update(primeiroProduto);
                contexto.SaveChanges();
            }
            RecuperarProdutos();
        }

        private static void ExcluirProdutos()
        {
            using(var contexto = new LojaContext())
            {
                var produtos = contexto.Produtos.ToList();

                foreach (var item in produtos)
                {
                    contexto.Produtos.Remove(item);
                }
                contexto.SaveChanges();
            }
        }

        private static void RecuperarProdutos()
        {
            using(var contexto = new LojaContext())
            {
                var produtos = contexto.Produtos.ToList();

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
            p.Preco = 19.89;

            using (var contexto = new LojaContext())
            {
                contexto.Produtos.Add(p);
                contexto.SaveChanges();
            }
        }

        private static void GravarUsandoAdoNet()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var repo = new ProdutoDAO())
            {
                repo.Adicionar(p);
            }
        }
    }
}
