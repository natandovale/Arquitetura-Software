namespace SOLID._5_DIP.DIP_Solucao.Interfaces
{
    public interface IEmailServices
    {
        void Enviar(string de, string para, string assunto, string mensagem);
    }
}
