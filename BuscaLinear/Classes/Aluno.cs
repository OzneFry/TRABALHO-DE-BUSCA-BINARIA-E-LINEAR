using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuscaLinear.Classes
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }

        public Aluno(string nome, int matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }
    }
}
