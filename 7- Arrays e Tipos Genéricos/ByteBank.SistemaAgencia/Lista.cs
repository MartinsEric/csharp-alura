using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class Lista<T>
    {
        private T[] _itens;
        private int _proximaPosicao;

        public int Tamanho
        {
            get
            {
                return _proximaPosicao;
            }
        }



        public Lista(int tamanhoTotal = 5)
        {
            _itens = new T[tamanhoTotal];
            _proximaPosicao = 0;
        }

        public T GetContaPeloIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new IndexOutOfRangeException("O indice não pode ser menor que zero e maior que o tamanho da lista.");
            }

            return _itens[indice];

        }

        public T this[int indice]
        {
            get
            {
                return GetContaPeloIndice(indice);
            }
        }

        public void Adicionar(T item)
        {
            VerificarCapacidade(_proximaPosicao + 1);

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        public void AdicionarVarios(params T[] itens)
        {
            foreach (T conta in itens)
            {
                Adicionar(conta);
            }
        }

        public void Remover(T conta)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {
                if (_itens[i].Equals(conta))
                {
                    indiceItem = i;
                    break;
                }
            }

            for (int i = indiceItem; i < _proximaPosicao - 1; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            //_itens[_proximaPosicao] = null;
            _proximaPosicao--;
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            int novoTamanho = tamanhoNecessario * 2;
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            Console.WriteLine("Aumentando o tamanho do array!");

            T[] novoArray = new T[novoTamanho];

            Array.Copy(_itens, novoArray, _itens.Length);

            _itens = novoArray;
        }
    }
}
