namespace InterfaceTributavel
{
    public class ContaCorrente : Itributavel
    {
        public double Saldo { get; set; }

        public ContaCorrente(double saldo)
        {
            Saldo = saldo;
        }

        // 5% do saldo é imposto
        public double CalculaTributos()
        {
            return Saldo * 0.05;
        }
    }
}
