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
            //compra de 6 pães franceses

            var produto = new Produto();
            produto.Nome = "Pão Francês";
            produto.PrecoUnitario = 0.40;
            produto.Unidade = "Unidade";
            produto.Categoria = "Padaria";

            var compra = new Compra();
            compra.Quantidade = 6;
            compra.Produto = produto;
            compra.Preco = compra.Quantidade * produto.PrecoUnitario;

            using(var contexto = new LojaContext())
            {
                contexto.Compras.Add(compra);
                contexto.SaveChanges();

                foreach (var item in contexto.Compras.ToList())
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadLine();
        }
    }
}
