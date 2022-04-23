using System;

namespace SOLID._3_LSP.LSP_Solucao
{
    public class Quadrado : Paralelogramo
    {
        public Quadrado(double altura, double largura) : base(altura, largura)
        {
            if(largura != altura)
            {
                throw new ArgumentException("Os dois lados precisam ser iguais!!!");
            }
        }
    }
}
