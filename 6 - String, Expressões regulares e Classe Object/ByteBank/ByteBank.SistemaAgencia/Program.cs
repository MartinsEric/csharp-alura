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
            //Teste de expressao regular.
            string expReg = "[0-9]{4,5}[- ]?[0-9]{4}";
            string textoTeste = "anote o telefone 8543-2134";

            Match resultado = Regex.Match(textoTeste, expReg);

            Console.WriteLine(resultado);

            Console.ReadLine();


            //string url = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";

            //ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(url);

            //Console.WriteLine("moeda origem: " + extrator.GetValor("moedaorigem"));
            //Console.WriteLine("moeda destino: " + extrator.GetValor("moedaDeStino"));
            //Console.WriteLine("valor: " + extrator.GetValor("VALOR"));


            //Console.ReadLine();
        }
    }
}
