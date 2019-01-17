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
            ContaCorrente contaDoBruno = new ContaCorrente();
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDoBruno.Depositar(50);
            contaDaGabriela.Depositar(100);

            Console.WriteLine("Saldo do Bruno: R$" + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: R$" + contaDaGabriela.saldo);

            contaDoBruno.Sacar(51);
            contaDaGabriela.Sacar(50);

            Console.WriteLine("Saldo do Bruno: R$" + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: R$" + contaDaGabriela.saldo);

            contaDaGabriela.Transferir(20, contaDoBruno);

            Console.WriteLine("Saldo do Bruno: R$" + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: R$" + contaDaGabriela.saldo);

            contaDoBruno.Transferir(90, contaDaGabriela);

            Console.WriteLine("Saldo do Bruno: R$" + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: R$" + contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
