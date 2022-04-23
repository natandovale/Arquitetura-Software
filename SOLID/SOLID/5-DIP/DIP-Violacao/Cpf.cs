namespace SOLID._5_DIP.DIP_Violacao
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
