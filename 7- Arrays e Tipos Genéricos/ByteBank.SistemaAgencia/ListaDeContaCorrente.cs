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
