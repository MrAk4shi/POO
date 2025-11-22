namespace VenderItem
{   
    public abstract class Pagamento
    {
        public double Valor { get; protected set; }
        public abstract bool ProcessaPagamento();
    }
}