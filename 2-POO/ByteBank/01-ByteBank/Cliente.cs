using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    public class Cliente
    {
        public string Nome { get; set; }
        private string _cpf;
        public string Cpf
        {
            get
            {
                return _cpf;
            }
            set
            {
                // Minha lógica de validação de cpf.
                _cpf = value;
            }
        }
        public string Profissao { get; set; }
    }
}
