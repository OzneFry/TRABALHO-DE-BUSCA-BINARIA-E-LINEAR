using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuscaLinear.Classes
{
    public class MaiorMenorElemento
    {
        public (int maior, int menor) Encontrar(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Array não pode ser vazio");

            int maior = array[0];
            int menor = array[0];

            foreach (var num in array)
            {
                if (num > maior)
                    maior = num;
                if (num < menor)
                    menor = num;
            }

            return (maior, menor);
        }
    }
}
