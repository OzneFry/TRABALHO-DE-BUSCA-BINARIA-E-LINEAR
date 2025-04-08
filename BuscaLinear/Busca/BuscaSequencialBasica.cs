using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuscaLinear.Interfaces;

namespace BuscaLinear.Classes
{
    public class BuscaSequencialBasica : IBuscaSequencial
    {
        public int Buscar(int[] array, int alvo)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == alvo)
                    return i;
            }
            return -1;
        }
    }
}