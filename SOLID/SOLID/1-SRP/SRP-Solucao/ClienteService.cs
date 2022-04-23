namespace SOLID._1_SRP.SRP_Solucao
{
    public class ClienteService
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
