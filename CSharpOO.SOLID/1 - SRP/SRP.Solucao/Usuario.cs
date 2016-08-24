using System;

//SRP = Princípio da Responsabilidade Única
namespace CSharpOO.SOLID.SRP.Solucao
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }

        public bool IsValid()
        {
            return EmailServices.IsValid(Email) && CPFServices.IsValid(CPF);
        }
    }
}