using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SOLID._1_SRP.SRP_Violacao
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }

        public string AdicionarCliente()
        {
            if (!Email.Contains("@")) return "Cliente com e-mail invalido";

            if (CPF.Length != 11) return "Cliente com CPF invalido";

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "ConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL, CPF, DATACADASTRO VALUES (@nome, @email, @cpf, @dataCadastro)";

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            var email = new MailMessage("empresa@emapresa.com", Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com",
            };

            email.Subject = "Bem vindo";
            email.Body = "Parabens! Voce esta cadastrado";
            client.Send(email);

            return "Cadastro com sucesso";
        }
    }
}
