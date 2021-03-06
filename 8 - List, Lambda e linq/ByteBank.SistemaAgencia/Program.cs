﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensões;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>
            {
                new ContaCorrente(165, 123456),
                new ContaCorrente(143, 655432),
                new ContaCorrente(154, 765323),
                null,
                new ContaCorrente(112, 346554),
                null,
                new ContaCorrente(143, 475633)

            };

            //contas.Sort();
            //contas.Sort(new ComparadorContaCorrentePorAgencia());

            var contasOrdenadas = contas
                .Where(conta => conta != null)
                .OrderBy(conta => conta.Agencia);

            foreach (var conta in contasOrdenadas)
            {
                if(conta != null)
                {
                    Console.WriteLine($"Conta número {conta.Numero} ag. {conta.Agencia}");
                }
            }

            Console.ReadLine();
        }

        public static void TestaSort()
        {
            var idades = new List<int>();
            var nomes = new List<string>();

            idades.Add(1);
            idades.Add(3);
            idades.Add(6);
            idades.Add(5);
            idades.Add(9);
            idades.Add(2);

            //ListExtensoes.AdicionarVarios(idades, 234, 454, 456, 867);
            idades.AdicionarVarios(234, 456, 5467, 67845);
            nomes.AdicionarVarios("Luiza", "Eric", "Breno", "Fafa");

            idades.Sort();
            nomes.Sort();

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }

        public static void TestaListaDeContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente(6);

            ContaCorrente contaEric = new ContaCorrente(132, 1324567);

            lista.AdicionarVarios(contaEric,
                new ContaCorrente(123, 123475),
                new ContaCorrente(123, 1234876),
                new ContaCorrente(123, 1234567));

            ContaCorrente item = lista.GetContaPeloIndice(2);
            Console.WriteLine($"{item.Agencia}/{item.Numero}");

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente conta = lista[i];
                Console.WriteLine($"Conta {conta.Agencia} / {conta.Numero}");
            }


            //lista.Imprimir();
            lista.Remover(contaEric);

            Console.WriteLine();

            //lista.Imprimir();
        }

        public static void ArrayDeContas()
        {
            ContaCorrente[] contas = new ContaCorrente[]
          {
                new ContaCorrente(123,123456),
                new ContaCorrente(123,123345),
                new ContaCorrente(123,123654)
          };

            for (int i = 0; i < contas.Length; i++)
            {
                Console.WriteLine($"Conta {i} --- Número: {contas[i].Numero}");
            }
        }

        public static void ArrayDeInt()
        {
            int[] idades = new int[5];

            idades[0] = 18;
            idades[1] = 46;
            idades[2] = 32;
            idades[3] = 54;
            idades[4] = 25;

            int acumulador = 0;
            for (int i = 0; i < idades.Length; i++)
            {
                acumulador += idades[i];
                Console.WriteLine($"idade[{i}] = {idades[i]}");
            }

            double media = acumulador / idades.Length;

            Console.WriteLine($"Média das idades = {media} anos.");

            Console.ReadLine();
        }
    }
}
