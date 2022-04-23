using System;
using System.Linq;

namespace SOLID._2_OCP.OCP_Solucao
{
    public abstract class DebitoConta
    {
        public string NumeroTransacao { get; set; }
        public abstract string Debitar();

        public string FormatarTransacao()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVXWYZ1234567890";
            var random = new Random();
            NumeroTransacao = new string(Enumerable.Repeat(chars, 15)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            //Numero de transacao formatacao
            return NumeroTransacao;
        }
    }
}
