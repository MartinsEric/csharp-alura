using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                ContaCorrente conta = new ContaCorrente(123, 123456);
                ContaCorrente conta2 = new ContaCorrente(456, 456123);

                conta.Transferir(10000, conta2);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Informações da INNER EXCEPTION (exceção interna)");

                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);

                Console.ReadLine();
            }
        }
        public static void Metodo()
        {
            TestaDivisao(2);

        }

        public static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }

        public static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;
            //Console.WriteLine(conta.Saldo);

            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com numero = " + numero + " e divisor = " + divisor);

                throw;
            }
        }

    }
}