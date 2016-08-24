using System;

//DIP = Princípio da Inversão de Dependência
namespace CSharpOO.SOLID.DIP.Problema
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