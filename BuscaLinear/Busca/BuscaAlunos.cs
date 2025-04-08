using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuscaLinear.Classes;
using BuscaLinear.Interfaces;

namespace BuscaLinear.Busca
{
    public class BuscaAlunos : IBuscaSequencial<Aluno>
    {
        public int Buscar(Aluno[] array, Aluno alvo)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Matricula == alvo.Matricula)
                    return i;
            }
            return -1;
        }
    }
}
