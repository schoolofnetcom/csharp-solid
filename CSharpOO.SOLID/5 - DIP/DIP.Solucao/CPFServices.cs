using CSharpOO.SOLID.DIP.Solucao.Interfaces;

//DIP = Princípio da Inversão de Dependência
namespace CSharpOO.SOLID.DIP.Solucao
{
    public class CPFServices : ICPFServices
    {
        public bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}