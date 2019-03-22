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
            //Tipo int
            Lista<int> listaIdades = new Lista<int>();

            listaIdades.Adicionar(1);
            listaIdades.AdicionarVarios(1, 2, 5, 6, 7);
            listaIdades.Remover(5);

            //Tipo String
            Lista<string> listaNomes = new Lista<string>();
            listaNomes.Adicionar("Eric");
            listaNomes.AdicionarVarios("Luiza", "Breno", "Fabrício","Pamela");
            listaNomes.Remover("Pamela");

            //Tipo ContaCorrente
            ContaCorrente conta = new ContaCorrente(123, 1234567);
            Lista<ContaCorrente> listaContas = new Lista<ContaCorrente>();
            listaContas.Adicionar(conta);
            listaContas.AdicionarVarios(new ContaCorrente(123, 1234567), 
                new ContaCorrente(321, 321456), 
                new ContaCorrente(432, 432654));
            listaContas.Remover(conta);


            Console.ReadLine();
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
