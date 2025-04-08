using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuscaBinaria.Interfaces;

namespace BuscaBinaria
{
    public class VerificacaoExistencia : IBuscaBinaria
    {
        public int Buscar(int[] array, int alvo)
        {
            var busca = new BuscaBinariaBasica();
            return busca.Buscar(array, alvo) != -1 ? 1 : -1;
        }
    }
}
