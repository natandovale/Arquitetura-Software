namespace SOLID._2_OCP.OCP_Solucao
{
    public class DebitoContaCorrente : DebitoConta
    {
        public override string Debitar()
        {
            //Logica
            return FormatarTransacao();
        }
    }
}
