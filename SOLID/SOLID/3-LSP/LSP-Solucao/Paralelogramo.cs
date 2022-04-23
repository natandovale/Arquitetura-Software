namespace SOLID._3_LSP.LSP_Solucao
{
    public abstract class Paralelogramo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }
        public double Area { get { return Altura * Largura; } }

        public Paralelogramo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }
    }
}
