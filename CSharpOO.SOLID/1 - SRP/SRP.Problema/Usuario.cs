using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

//SRP = Princípio da Responsabilidade Única
namespace CSharpOO.SOLID.SRP.Usuario 
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }

        public string AdicionarUsuario()
        {
            if (!Email.Contains("@"))
                return "Usuário com e-mail inválido";

            if (CPF.Length != 11)
                return "Usuário com CPF inválido";


            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "StringConexao";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO USUARIO (NOME, EMAIL CPF, DATANASCIMENTO) VALUES (@nome, @email, @cpf, @dataNas))";

                cmd.Parameters.AddWithValue("nome", Nome);
                cmd.Parameters.AddWithValue("email", Email);
                cmd.Parameters.AddWithValue("cpf", CPF);
                cmd.Parameters.AddWithValue("dataNas", DataNascimento);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            var mail = new MailMessage("csharp@solid.com", Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Bem Vindo.";
            mail.Body = "Parabéns! Você está cadastrado.";
            client.Send(mail);

            return "Usuário cadastrado com sucesso!";
        }
    }
}