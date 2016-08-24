//OCP = Princípio Aberto/Fechado
namespace CSharpOO.SOLID.OCP.Solucao
{
    public class ContaPoupanca : Conta
    {
        public override void Sacar(decimal valor, string conta)
        {
            this.Saldo -= valor;
        }

        public override void Depositar(decimal valor, string conta)
        {
            this.Saldo += valor;
        }
    }
}
