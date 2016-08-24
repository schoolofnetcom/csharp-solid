//OCP = Princípio Aberto/Fechado
namespace CSharpOO.SOLID.OCP.Solucao
{
    public class ContaCorrente : Conta
    {
        private decimal TaxaMovimentacao { get; set; }

        public ContaCorrente()
        {
            this.TaxaMovimentacao = 0.01m;
        }

        public override void Sacar(decimal valor, string conta)
        {
            // Taxas...
            this.Saldo -= (valor + (valor * TaxaMovimentacao));
        }

        public override void Depositar(decimal valor, string conta)
        {
            this.Saldo += valor;
        }
    }
}
