//OCP = Princípio Aberto/Fechado
namespace CSharpOO.SOLID.OCP.Solucao
{
    public abstract class Conta
    {
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public decimal Saldo { get; set; }

        public abstract void Depositar(decimal valor, string conta);
        public abstract void Sacar(decimal valor, string conta);
    }
}
