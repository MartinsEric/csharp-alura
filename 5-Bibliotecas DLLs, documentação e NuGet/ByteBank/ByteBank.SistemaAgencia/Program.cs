using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataDoisAnos = new DateTime(2019, 3, 22);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan tempoQueFalta = dataDoisAnos - dataCorrente;

            string mensagem = "faltam " + TimeSpanHumanizeExtensions.Humanize(tempoQueFalta) + " Para completar 2 anos de namoro com o amor da sua vida.";

            Console.WriteLine(mensagem);

            Console.ReadLine();
        }
    }
}
