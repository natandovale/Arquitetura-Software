using System;

namespace POO._02_PilaresPOO
{
    public class Heranca
    {
        public class Funcionario : Pessoa
        {
            public DateTime DataAdmissao { get; set; }
            public string Registro { get; set; }
        }

        public class Processo
        {
            public void Execucao()
            {
                var funcionario = new Funcionario()
                {
                    Nome = "Joao",
                    DataNascimento = Convert.ToDateTime("1990/01/01"),
                    DataAdmissao = DateTime.Now,
                    Registro = "0123456",
                };
                funcionario.CalcularIdade();
            }
        }
    }
}
