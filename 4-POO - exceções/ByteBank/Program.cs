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
                Metodo();
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
            }
            
            Console.ReadLine();
        }

        public static void Metodo()
        {
            try
            {
                TestaDivisao(0);
            }catch(NullReferenceException e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
            }
            
        }

        public static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }

        public static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;
            Console.WriteLine(conta.Saldo);

            return numero / divisor;
        }
    }
}