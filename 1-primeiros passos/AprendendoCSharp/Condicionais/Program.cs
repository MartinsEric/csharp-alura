using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade = 18, qtdPessoas = 1;

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade, entrada permitida.");
            }
            else
            {
                if (qtdPessoas >= 2)
                {
                    Console.WriteLine("Você é menor de idade, mas está acompanhado. Entrada permitida.");
                }
                else
                {
                    Console.WriteLine("Você é menor de idade, entrada não permitida.");
                }
            }


            Console.ReadLine();
        }
    }
}
