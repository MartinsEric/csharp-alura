using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;


namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "pagina?argumentos";

            Console.WriteLine(url);

            int indice = url.IndexOf('?');

            string argumentos = url.Substring(indice + 1);

            Console.WriteLine(argumentos);




            Console.ReadLine();
        }
    }
}
