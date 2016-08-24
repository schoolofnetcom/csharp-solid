//OCP = Princípio Aberto/Fechado
namespace CSharpOO.SOLID.OCP.Problema
{
    public class Conta
    {
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public decimal Saldo { get; set; }
        public TipoConta TipoConta { get; set; }
    }
}