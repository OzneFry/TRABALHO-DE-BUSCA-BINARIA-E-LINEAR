using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuscaBinaria.Interfaces;

namespace BuscaBinaria.Classes
{
    public class UltimaOcorrencia : IBuscaBinaria
    {
        public int Buscar(int[] array, int alvo)
        {
            int esquerda = 0;
            int direita = array.Length - 1;
            int resultado = -1;

            while (esquerda <= direita)
            {
                int meio = esquerda + (direita - esquerda) / 2;

                if (array[meio] == alvo)
                {
                    resultado = meio;
                    esquerda = meio + 1;
                }
                else if (array[meio] < alvo)
                    esquerda = meio + 1;
                else
                    direita = meio - 1;
            }

            return resultado;
        }
    }
}
