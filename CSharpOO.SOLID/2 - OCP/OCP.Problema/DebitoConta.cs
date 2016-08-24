//OCP = Princípio Aberto/Fechado
namespace CSharpOO.SOLID.OCP.Problema
{
    public class DebitoConta
    {
        public void Debitar(decimal valor, Conta conta)
        {
            if (conta.TipoConta == TipoConta.Corrente)
            {
                // Taxas...
                // Debita Conta Corrente
            }

            if (conta.TipoConta == TipoConta.Poupanca)
            {
                // Valida Aniversário da Conta
                // Debita Conta Poupança
            }
        }
    }
}