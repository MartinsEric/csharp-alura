using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.Modelos.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        private AuntenticacaoHelper _auntenticacaoHelper = new AuntenticacaoHelper();
        public string Senha { get; set; }

        public FuncionarioAutenticavel(double salario, string cpf)
            : base(salario, cpf)
        {
        }

        public bool Autenticar(string senha)
        {
            return _auntenticacaoHelper.CompararSenha(Senha, senha);
        }
    }
}
