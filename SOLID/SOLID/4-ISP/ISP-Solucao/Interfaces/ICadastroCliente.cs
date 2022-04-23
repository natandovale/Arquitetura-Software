namespace SOLID._4_ISP.ISP_Solucao.Interfaces
{
    public interface ICadastroCliente : ICadastro
    {
        public void EnviarEmail();
        public void ValidarDados();
    }
}
