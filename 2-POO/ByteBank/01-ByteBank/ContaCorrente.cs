
namespace _01_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo;

        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                this.saldo += valor;
            }
        }

        public bool Transferir(double valor, ContaCorrente outraConta)
        {
            if (valor <= 0 || this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            outraConta.Depositar(valor);
            return true;
        }
    }
}