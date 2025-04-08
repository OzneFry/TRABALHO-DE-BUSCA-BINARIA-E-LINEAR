using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuscaBinaria.Interfaces;

namespace BuscaBinaria
{
    public class PosicaoInsercao : IBuscaBinaria
    {
        public int Buscar(int[] array, int alvo)
        {
            int esquerda = 0;
            int direita = array.Length - 1;

            while (esquerda <= direita)
            {
                int meio = esquerda + (direita - esquerda) / 2;

                if (array[meio] == alvo)
                    return meio;
                else if (array[meio] < alvo)
                    esquerda = meio + 1;
                else
                    direita = meio - 1;
            }

            return esquerda;
        }
    }
}
