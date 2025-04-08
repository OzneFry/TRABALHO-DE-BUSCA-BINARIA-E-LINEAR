using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuscaLinear.Interfaces;

namespace BuscaLinear.Classes
{
    public class BuscaStrings : IBuscaSequencial<string>
    {
        public int Buscar(string[] array, string alvo)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(alvo, StringComparison.OrdinalIgnoreCase))
                    return i;
            }
            return -1;
        }
    }
}
