using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoEOutrosTiposNumericos{
    class Program{
        static void Main(string[] args){

            double salario = 1250.50;
            int salarioInteiro = (int) salario;
            Console.WriteLine(salarioInteiro);

            //outros tipos de inteiro.
            long idadeDaTerra = 13000000000;

            short quantidadeProduto = 1500;

            //outro tipo de ponto flutuante.
            float altura = 1.80f;


            Console.ReadLine();
        }
    }
}
