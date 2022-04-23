namespace POO._02_PilaresPOO
{
    public class CafeteiraEspressa : Eletrodomestico
    {
        public CafeteiraEspressa(string nome, int voltagem) 
            : base(nome, voltagem) { }

        public CafeteiraEspressa()
            : base("padrao", 220) { }

        private static void AquecerAgua() { }

        private static void MoerGraos() { }

        public void PrepararCafe()
        {
            Testar();
            AquecerAgua();
            MoerGraos();
        }

        public override void Testar()
        {
            //
        }

        public override void Ligar()
        {
            throw new System.NotImplementedException();
        }

        public override void Desligar()
        {
            throw new System.NotImplementedException();
        }
    }
}
