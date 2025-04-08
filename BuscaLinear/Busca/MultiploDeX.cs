using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuscaLinear.Interfaces;

namespace BuscaLinear.Classes
{
    public class MultiploDeX : IBuscaSequencial
    {
        public int Buscar(int[] array, int x)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % x == 0)
                    return array[i];
            }
            return -1;
        }
    }
}
