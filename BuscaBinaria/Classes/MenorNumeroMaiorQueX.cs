using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuscaBinaria.Interfaces;

namespace BuscaBinaria
{
    public class MenorNumeroMaiorQueX : IBuscaBinaria
    {
        public int Buscar(int[] array, int alvo)
        {
            int esquerda = 0;
            int direita = array.Length - 1;
            int resultado = -1;

            while (esquerda <= direita)
            {
                int meio = esquerda + (direita - esquerda) / 2;

                if (array[meio] > alvo)
                {
                    resultado = meio;
                    direita = meio - 1;
                }
                else
                {
                    esquerda = meio + 1;
                }
            }

            return resultado != -1 ? array[resultado] : -1;
        }
    }
}
