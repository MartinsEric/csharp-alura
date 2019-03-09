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
            string url = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";

            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(url);

            Console.WriteLine("moeda origem: " + extrator.GetValor("moedaorigem"));
            Console.WriteLine("moeda destino: " + extrator.GetValor("moedaDeStino"));
            Console.WriteLine("valor: " + extrator.GetValor("VALOR"));





            Console.ReadLine();
        }
    }
}
