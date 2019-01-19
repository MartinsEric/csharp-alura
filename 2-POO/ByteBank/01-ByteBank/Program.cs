using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente luiza = new Cliente("Luiza", "123.456.789-10", "Engenheira de Bioprocessos");
            ContaCorrente contaLuiza = new ContaCorrente(luiza, 123, 1234567);

            contaLuiza.Depositar(100);
            contaLuiza.Sacar(150);

            Cliente eric = new Cliente("Eric", "987.654.321-11", "Desenvolvedor");
            ContaCorrente contaEric = new ContaCorrente(eric, 123, 1237654);

            contaEric.Depositar(100);
            contaEric.Transferir(100, contaLuiza);

            Console.WriteLine("----Conta da " + contaLuiza.Titular.Nome + "----");
            Console.WriteLine("Agência: " + contaLuiza.Agencia);
            Console.WriteLine("Número: " + contaLuiza.Numero);
            Console.WriteLine("Profissão: " + contaLuiza.Titular.Profissao);
            Console.WriteLine("Saldo: R$" + contaLuiza.Saldo);

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();

            Console.WriteLine("----Conta do " + contaEric.Titular.Nome + "----");
            Console.WriteLine("Agência: " + contaEric.Agencia);
            Console.WriteLine("Número: " + contaEric.Numero);
            Console.WriteLine("Profissão: " + contaEric.Titular.Profissao);
            Console.WriteLine("Saldo: R$" + contaEric.Saldo);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Total de contas: " + ContaCorrente.TotalDeContas);

            Console.ReadLine();
        }
    }
}
