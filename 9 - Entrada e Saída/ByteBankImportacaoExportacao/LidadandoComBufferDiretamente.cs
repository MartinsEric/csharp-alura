using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        public static void UsandoBufferDiretamente()
        {
            var arquivo = "contas.txt";
            using (var fluxoDeArquivo = new FileStream(arquivo, FileMode.Open))
            {
                var buffer = new byte[1024];
                var quantidadeBytesLidos = -1;

                while (quantidadeBytesLidos != 0)
                {
                    quantidadeBytesLidos = fluxoDeArquivo.Read(buffer, 0, 1024);
                    EscreverBuffer(buffer, quantidadeBytesLidos);
                }
            }

            Console.ReadLine();
        }

        public static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            var utf8 = Encoding.Default;
            var texto = utf8.GetString(buffer, 0, bytesLidos);

            Console.Write(texto);
        }
    }
}