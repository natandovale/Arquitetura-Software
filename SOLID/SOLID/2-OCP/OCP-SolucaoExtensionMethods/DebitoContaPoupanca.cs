namespace SOLID._2_OCP.OCP_SolucaoExtensionMethods
{
    public static class DebitoContaPoupanca
    {
        public static string DebitarContaPoupanca(this DebitoConta debitoConta)
        {
            //Logica
            return debitoConta.FormatarTransacao();
        }
    }
}
