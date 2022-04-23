namespace SOLID._2_OCP.OCP_Solucao
{
    public class DebitoContaPoupanca : DebitoConta
    {
        public override string Debitar()
        {
            //Logica
            return FormatarTransacao();
        }
    }
}
