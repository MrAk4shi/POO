namespace PolimorfismoBonificacao
{
    public class Secretario : Funcionario
    {
        public Secretario(int codigo, string nome, double salario)
            : base(codigo, nome, salario)
        {}

        public override double CalcularBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
