using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
     public class ListaDeContaCorrente
    {
        private ContaCorrente[] _itens;
        private int _proximaPosicao;

        public ListaDeContaCorrente(int tamanhoTotal = 5)
        {
            _itens = new ContaCorrente[tamanhoTotal];
            _proximaPosicao = 0;
        }

        public void Adicionar(ContaCorrente item)
        {
            Console.WriteLine($"Adicionando novo item na posição {_proximaPosicao} --- Ag: {item.Agencia} / Número: {item.Numero}!");

            VerificarCapacidade(_proximaPosicao + 1);

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        public void Remover(ContaCorrente conta)
        {
            int indiceItem = -1;

            for(int i = 0; i < _proximaPosicao; i++)
            {
                if (_itens[i].Equals(conta))
                {
                    indiceItem = i;
                    break;
                }
            }

            for(int i = indiceItem; i < _proximaPosicao -1; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            _itens[_proximaPosicao] = null;
            _proximaPosicao--;
        }

        public void Imprimir()
        {
            for(int i = 0; i < _proximaPosicao; i++)
            {
                Console.WriteLine($"Agência: {_itens[i].Agencia} --- Número: {_itens[i].Numero}");
            }
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if(_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            int novoTamanho = tamanhoNecessario * 2;
            if(novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            Console.WriteLine("Aumentando o tamanho do array!");

            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];

            Array.Copy(_itens, novoArray, _itens.Length);

            _itens = novoArray;
        }
    }
}
