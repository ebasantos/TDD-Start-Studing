namespace Model
{
    public class ContaCredito : IConta
    {
        public decimal Saldo { get; set; }

        public decimal AbrirConta(decimal saldo = 0)
        {
            return CreditarSaldo(saldo);
        }

        public decimal CreditarSaldo(decimal valor)
        {
            return Saldo += valor;
        }

        public decimal DebitarSaldo(decimal valor)
        {
            return Saldo -= valor;
        }

        public decimal ObterSaldo()
        {
            return Saldo;
        }
    }
}
