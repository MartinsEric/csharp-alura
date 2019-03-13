using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente(6);

            lista.Adicionar(new ContaCorrente(123, 123456));
            lista.Adicionar(new ContaCorrente(123, 123475));
            lista.Adicionar(new ContaCorrente(123, 1234567));
            lista.Adicionar(new ContaCorrente(123, 1234876));
            lista.Adicionar(new ContaCorrente(123, 123456));
            lista.Adicionar(new ContaCorrente(123, 123475));
            lista.Adicionar(new ContaCorrente(123, 1234567));
            lista.Adicionar(new ContaCorrente(123, 1234876));
            lista.Adicionar(new ContaCorrente(123, 123456));
            lista.Adicionar(new ContaCorrente(123, 123475));
            lista.Adicionar(new ContaCorrente(123, 1234567));
            lista.Adicionar(new ContaCorrente(123, 1234876));
            lista.Adicionar(new ContaCorrente(123, 123456));
            lista.Adicionar(new ContaCorrente(123, 123475));
            lista.Adicionar(new ContaCorrente(123, 1234567));
            lista.Adicionar(new ContaCorrente(123, 1234876));


            Console.ReadLine();
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
