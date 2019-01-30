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
                ContaCorrente conta = new ContaCorrente(123,123456);
                ContaCorrente conta2 = new ContaCorrente(456, 456123);

                conta.Sacar(50);
                conta2.Transferir(0, conta);
                
            }
            catch(SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ParamName);
            }

            try
            {
                Metodo();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Um número não pode ser dividido por zero.");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
            }
                        
            Console.ReadLine();
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