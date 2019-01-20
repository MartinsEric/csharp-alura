using ByteBank.Funcionarios;
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
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario("Carlos", "123.456.789-98", 2000);
            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor("Roberta", "987.654.321-12", 5000);
            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.GetBonificacao());
            Console.WriteLine(roberta.GetBonificacao());
            Console.WriteLine(gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
