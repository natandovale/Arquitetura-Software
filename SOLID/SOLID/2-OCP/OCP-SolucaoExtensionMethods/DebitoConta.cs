using System;
using System.Linq;

namespace SOLID._2_OCP.OCP_SolucaoExtensionMethods
{
    public class DebitoConta
    {
        public string NumeroConta { get; set; }
        public string Valor { get; set; }
        public string NumeroTransacao { get; set; }

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
