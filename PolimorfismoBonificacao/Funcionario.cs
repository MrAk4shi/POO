namespace PolimorfismoBonificacao
{
    public class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }

        public virtual double CalcularBonificacao()
        {
            return Salario * 0.10; // 10%
        }
    }
}
