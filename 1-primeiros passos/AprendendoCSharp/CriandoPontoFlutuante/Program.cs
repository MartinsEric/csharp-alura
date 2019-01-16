using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoPontoFlutuante{
    class Program{
        static void Main(string[] args){

            double salario = 1250.50;
            Console.WriteLine("Meu salário é " + salario);

            salario = 2501 / 2;
            Console.WriteLine("Este é o meu salário: " + salario);

            salario = 2501.0 / 2;
            Console.WriteLine("Não! meu salário é " + salario + " reais.");            


            Console.ReadLine();
            

        }
    }
}
