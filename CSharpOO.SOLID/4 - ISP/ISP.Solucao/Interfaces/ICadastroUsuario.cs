//ISP = Princípio da Segregação de Interface
namespace CSharpOO.SOLID.ISP.Solucao.Interfaces
{
    public interface ICadastroUsuario
    {
        void ValidarDados();
        void Salvar();
        void EnviarEmail();
    }
}