using System;

//ISP = Princípio da Segregação de Interface
namespace CSharpOO.SOLID.ISP.Problema
{
    public class CadastroProduto : ICadastro
    {
        public void ValidarDados()
        {
            // Validar valor
        }

        public void Salvar()
        {
            // Insert tabela Produto
        }

        public void EnviarEmail()
        {
            // Produto não tem e-mail
            // Qual deverá ser a implementação?
        }
    }
}