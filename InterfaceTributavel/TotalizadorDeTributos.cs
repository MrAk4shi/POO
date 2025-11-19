namespace InterfaceTributavel
{
    public class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        public void Adiciona(Itributavel t)
        {
            Total += t.CalculaTributos();
        }
    }
}
