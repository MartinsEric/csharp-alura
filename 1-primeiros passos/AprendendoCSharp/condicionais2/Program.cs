using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade = 18, qtdPessoas = 1;
            bool acompanhado = qtdPessoas >= 2;

            if (idade >= 18 && acompanhado)
            {
                Console.WriteLine("Pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar!");
            }


            Console.ReadLine();
        }
    }
}
