namespace SOLID._2_OCP.OCP_SolucaoExtensionMethods
{
    public static class DebitoContaInvestimento
    {
        public static string DebitarContaInvestimento(this DebitoConta debitoConta)
        {
            //Logica
            return debitoConta.FormatarTransacao();
        }
    }
}
