
namespace _01_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public static int TotalDeContas { get; private set; }
    
        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public ContaCorrente(Cliente titular, int agencia, int numero)
        {
            this.Titular = titular;
            this.Agencia = agencia;
            this.Numero = numero;

            TotalDeContas++;
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                return;
            }

            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente outraConta)
        {
            if (valor <= 0 || _saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            outraConta.Depositar(valor);
            return true;
        }
    }
}