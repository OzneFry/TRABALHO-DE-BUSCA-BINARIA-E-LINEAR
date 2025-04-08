using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuscaLinear.Interfaces;

namespace BuscaLinear.Busca
{
    public class BuscaComSentinela : IBuscaSequencial
    {
        public int Buscar(int[] array, int alvo)
        {
            if (array == null || array.Length == 0)
                return -1;

            int ultimo = array[array.Length - 1];

            array[array.Length - 1] = alvo;

            int i = 0;
            while (array[i] != alvo)
            {
                i++;
            }

            array[array.Length - 1] = ultimo;

            if (i < array.Length - 1 || array[array.Length - 1] == alvo)
                return i;

            return -1;
        }
    }
}
