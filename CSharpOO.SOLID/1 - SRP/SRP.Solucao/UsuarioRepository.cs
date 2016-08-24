using System.Data;
using System.Data.SqlClient;

//SRP = Princípio da Responsabilidade Única
namespace CSharpOO.SOLID.SRP.Solucao
{
    public class UsuarioRepository
    {
        public void AdicionarUsuario(Usuario usuario)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "StringConexao";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO USUARIO (NOME, EMAIL CPF, DATANASCIMENTO) VALUES (@nome, @email, @cpf, @dataNas))";

                cmd.Parameters.AddWithValue("nome", usuario.Nome);
                cmd.Parameters.AddWithValue("email", usuario.Email);
                cmd.Parameters.AddWithValue("cpf", usuario.CPF);
                cmd.Parameters.AddWithValue("dataNas", usuario.DataNascimento);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }   
}