namespace SOLID._5_DIP.DIP_Violacao
{
    public class ClienteRepository
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar()) return "Dados invalidos";

            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);

            EmailService.Enviar("empresa@empresa.com", cliente.Email.Endereco, "Bem vindo", "Parabens!!!!!");

            return "Cadastrado com sucesso!!!";
        }
    }
}
