namespace SOLID._2_OCP.OCP_SolucaoExtensionMethods
{
    public static class DebitoContaCorrente
    {
        public static string DebitarContaCorrente(this DebitoConta debitoConta)
        {
            //Logica
            return debitoConta.FormatarTransacao();
        }
    }
}
