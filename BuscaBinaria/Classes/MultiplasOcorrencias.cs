using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuscaBinaria.Classes;
using BuscaBinaria.Interfaces;

namespace BuscaBinaria
{
    public class MultiplasOcorrencias : IBuscaBinaria
    {
        public int Buscar(int[] array, int alvo)
        {
            var primeira = new PrimeiraOcorrencia().Buscar(array, alvo);
            var ultima = new UltimaOcorrencia().Buscar(array, alvo);

            if (primeira == -1)
                return -1;

            Console.WriteLine($"O número {alvo} ocorre nas posições:");
            for (int i = primeira; i <= ultima; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            return ultima - primeira + 1;
        }
    }
}
