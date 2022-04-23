namespace POO._02_PilaresPOO
{
    public class AutomacaoCafe
    {
        public void ServiceCafe()
        {
            var espresso = new CafeteiraEspressa();
            espresso.Ligar();
            espresso.PrepararCafe();
            espresso.Desligar();
        }
    }
}
