using SOLID._5_DIP.DIP_Solucao.Interfaces;
using SOLID._5_DIP.DIP_Violacao;

namespace SOLID._5_DIP.DIP_Solucao
{
    public class ClienteServices : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailServices _emailServices;

        public ClienteServices(IClienteRepository clienteRepository, IEmailServices emailServices)
        {
            _clienteRepository = clienteRepository;
            _emailServices = emailServices;
        }

        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar()) return "Dados invalidos";

            _clienteRepository.AdicionarCliente(cliente);

            _emailServices.Enviar("empresa@empresa.com", cliente.Email.Endereco, "Bem vindo", "Parabens!!!!!");

            return "Cadastrado com sucesso!!!";
        }
    }

    public class TestDip
    {
        public TestDip()
        {
            var cliService = new ClienteServices(new ClienteRepository(), new EmailService());
        }
    }
}
