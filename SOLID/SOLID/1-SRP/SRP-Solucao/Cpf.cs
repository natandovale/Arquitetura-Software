namespace SOLID._1_SRP.SRP_Solucao
{
    public class Cpf
    {
        public string Numero { get; set; }

        public bool Validar()
        {
            return Numero.Length == 1;
        }
    }
}
