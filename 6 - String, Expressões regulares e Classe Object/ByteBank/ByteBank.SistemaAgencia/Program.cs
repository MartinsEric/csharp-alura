using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;


namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sobrepondo ToString e Equals
            ContaCorrente conta = new ContaCorrente(123, 123456);

            Console.WriteLine(conta);

            Cliente eric = new Cliente();
            eric.Nome = "Eric Martins";
            eric.CPF = "123456789-98";
            eric.Profissao = "Desenvolvedor";

            Cliente eric_2 = new Cliente();
            eric_2.Nome = "Eric Martins";
            eric_2.CPF = "123456789-98";
            eric_2.Profissao = "Desenvolvedor";

            if (eric.Equals(eric_2))
            {
                Console.WriteLine("São iguais!");
            }
            else
            {
                Console.WriteLine("São diferentes!");
            }

            Console.ReadLine();
            
        }

        public static void ExpressaoRegular()
        {
            //Teste de expressao regular.
            string expReg = "[0-9]{4,5}[- ]?[0-9]{4}";
            string textoTeste = "anote o telefone 8543-2134";

            Match resultado = Regex.Match(textoTeste, expReg);

            Console.WriteLine(resultado);

            Console.ReadLine();
        }

        public static void ManupulacaoString()
        {
            string url = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";

            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(url);

            Console.WriteLine("moeda origem: " + extrator.GetValor("moedaorigem"));
            Console.WriteLine("moeda destino: " + extrator.GetValor("moedaDeStino"));
            Console.WriteLine("valor: " + extrator.GetValor("VALOR"));


            Console.ReadLine();
        }
    }
}
