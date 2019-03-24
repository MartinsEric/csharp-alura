using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios(this List<int> lista, params int[] itens)
        {
            foreach(int item in itens)
            {
                lista.Add(item);
            }
        }
    }
}
