//SRP = Princípio da Responsabilidade Única
namespace CSharpOO.SOLID.SRP.Solucao
{
    public class UsuarioService
    {
        public string AdicionarUsuario(Usuario usuario)
        {
            if (!usuario.IsValid())
                return "Dados inválidos";

            var repo = new UsuarioRepository();
            repo.AdicionarUsuario(usuario);

            EmailServices.Enviar("csharp@solid.com", usuario.Email, "Bem Vindo", "Parabéns está Cadastrado");

            return "Usuário cadastrado com sucesso";
        }
    }
}