using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get; }

        public ExtratorValorDeArgumentosURL(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio.", nameof(url));
            }

            URL = url;

            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);
        }

        public string GetValor(string nomeParametro)
        {
            string palavra = "moedaDeOrigem=real&moedaDeDestino=dolar";
            string nomeArgumento = "moedaDeDestino";

            int indice = palavra.IndexOf(nomeArgumento);

            string valor = palavra.Substring(indice + nomeArgumento.Length + 1);

            return valor;
        }
    }
}
