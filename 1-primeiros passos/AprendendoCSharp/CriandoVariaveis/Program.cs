using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoVariaveis{
    class Program{
        static void Main(string[] args){

            int idade = 23;
            Console.WriteLine("Hoje você tem " + idade + " anos.");

            idade += 5;
            Console.WriteLine("Daqui a 5 anos você terá " + idade + " anos.");

            Console.ReadLine();
        }
    }
}
