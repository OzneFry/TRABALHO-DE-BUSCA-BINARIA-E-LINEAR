using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuscaBinaria.Interfaces;

namespace BuscaBinaria.Classes
{
    public class NumeroMaisProximo : IBuscaBinaria
    {
        public int Buscar(int[] array, int alvo)
        {
            int esquerda = 0;
            int direita = array.Length - 1;

            while (esquerda < direita)
            {
                int meio = esquerda + (direita - esquerda) / 2;

                if (array[meio] == alvo)
                    return array[meio];

                if (array[meio] < alvo)
                    esquerda = meio + 1;
                else
                    direita = meio;
            }

            if (
                esquerda > 0
                && Math.Abs(array[esquerda - 1] - alvo) < Math.Abs(array[esquerda] - alvo)
            )
                return array[esquerda - 1];
            else
                return array[esquerda];
        }
    }
}
