//ISP = Princípio da Segregação de Interface
namespace CSharpOO.SOLID.ISP.Problema
{
    public interface ICadastro
    {
        void ValidarDados();
        void Salvar();
        void EnviarEmail();
    }
}