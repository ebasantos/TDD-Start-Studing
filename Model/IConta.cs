namespace Model
{
    public interface IConta
    {
        decimal Saldo { get; set; }
        decimal ObterSaldo();
        decimal AbrirConta(decimal saldo = 0);
        decimal CreditarSaldo(decimal valor);
        decimal DebitarSaldo(decimal valor); 
    }
}
