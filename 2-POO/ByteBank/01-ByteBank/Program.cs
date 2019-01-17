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
            ContaCorrente contaCorrente = new ContaCorrente();

            contaCorrente.saldo = 200;
            Console.WriteLine(contaCorrente.saldo);

            contaCorrente.saldo += 100;
            Console.WriteLine(contaCorrente.saldo);

            ContaCorrente outraConta = new ContaCorrente();

            outraConta.saldo = 50;

            Console.WriteLine("Saldo da primeira conta: R$" + contaCorrente.saldo);
            Console.WriteLine("Saldo da segunda conta: R$" + outraConta.saldo);


            Console.ReadLine();
        }
    }
}
