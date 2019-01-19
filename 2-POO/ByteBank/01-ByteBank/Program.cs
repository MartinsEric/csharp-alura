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
            Cliente gabriela = new Cliente();
            ContaCorrente conta = new ContaCorrente();

            conta.Titular = gabriela;

            gabriela.Nome = "Gabriela";
            gabriela.Cpf = "123.456.789.11";
            gabriela.Profissao = "Desenvolvedora C#";

            conta.Saldo = -10;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Titular.Cpf);
            Console.WriteLine(conta.Titular.Profissao);
            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }
    }
}
