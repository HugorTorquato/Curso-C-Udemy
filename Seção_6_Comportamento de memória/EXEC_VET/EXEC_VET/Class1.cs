using System;
using System.Collections.Generic;
using System.Text;

namespace EXEC_VET
{
    class Quarto
    {
        public int NumQuarto { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }



        public Quarto(int numQuarto)
        {
            Nome = "TBD";
            Email = "TBD";
            NumQuarto = numQuarto;
        }
        public Quarto(string nome, string email, int numQuarto)
        {
            Nome = nome;
            Email = email;
            NumQuarto = numQuarto;
        }

        public override string ToString()
        {
            return "Aluguel # " + NumQuarto
                + " \n Nome : " + Nome
                + " \n Email : " + Email;
        }

    }

}
