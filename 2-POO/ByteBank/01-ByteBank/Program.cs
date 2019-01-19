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

            conta.titular = gabriela;

            gabriela.nome = "Gabriela";
            gabriela.cpf = "123.456.789.11";
            gabriela.profissao = "Desenvolvedora C#";

            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);

            Console.ReadLine();
        }
    }
}
