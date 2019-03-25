using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        {
            var arquivo = "contas.txt";
            var fluxoDeArquivo = new FileStream(arquivo, FileMode.Open);
            var buffer = new byte[1024];
            var quantidadeBytesLidos = -1;

            while(quantidadeBytesLidos != 0)
            {
                quantidadeBytesLidos = fluxoDeArquivo.Read(buffer, 0, buffer.Length);
                EscreverBuffer(buffer);
            }


            Console.ReadLine();
        }

        public static void EscreverBuffer(byte[] buffer)
        {
            var utf8 = new UTF8Encoding();
            var texto = utf8.GetString(buffer);

            Console.Write(texto);
        }
    }
} 
 