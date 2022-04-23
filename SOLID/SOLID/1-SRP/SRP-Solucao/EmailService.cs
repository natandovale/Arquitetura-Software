using System.Net.Mail;

namespace SOLID._1_SRP.SRP_Solucao
{
    public class EmailService
    {
        public static void Enviar(string de, string para, string assunto, string mensagem)
        {
            var email = new MailMessage(de, para);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com",
            };

            email.Subject = assunto;
            email.Body = mensagem;
            client.Send(email);
        }
    }
}
