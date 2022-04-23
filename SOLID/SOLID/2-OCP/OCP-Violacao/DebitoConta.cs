namespace SOLID._2_OCP.OCP_Violacao
{
    public class DebitoConta
    {
        public void Debitar(decimal valor, string conta, TipoConta tipoConta)
        {
            if(tipoConta == TipoConta.Corrente)
            {
                //Debita Conta Corrente
            }

            if(tipoConta == TipoConta.Poupanca)
            {
                //Valida Aniversario da Conta
                //Debita Conta Poupanca
            }
        }
    }
}
