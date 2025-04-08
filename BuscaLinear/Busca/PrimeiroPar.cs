using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuscaLinear.Interfaces;

namespace BuscaLinear.Busca
{
    public class PrimeiroPar : IBuscaSequencial
    {
        public int Buscar(int[] array, int _)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    return array[i];
            }
            return -1;
        }
    }
}
