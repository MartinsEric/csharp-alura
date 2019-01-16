using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharEString{
    class Program{
        static void Main(string[] args){

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char) 65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra += (char) 1;
            Console.WriteLine(primeiraLetra);

            string titulo = "Curso de C#";
            Console.WriteLine(titulo);

            //Só quebra linha na execucao se tiver o "@".
            string cursos = @"
-.NET
-JAVA
-JavaScript";
            Console.WriteLine(cursos);


            Console.ReadLine();
        }
    }
}
