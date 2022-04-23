using System;

namespace POO._02_PilaresPOO
{
    public class Pessoa
    {
        //Estados
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        //Comportamentos
        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;

            if (dataAtual < DataNascimento.AddYears(idade)) idade--;

            return idade;
        }
    }
}
