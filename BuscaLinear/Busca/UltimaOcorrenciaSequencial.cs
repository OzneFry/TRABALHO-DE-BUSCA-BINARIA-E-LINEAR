using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuscaLinear.Interfaces;

namespace BuscaLinear.Busca
{
    public class UltimaOcorrenciaSequencial : IBuscaSequencial
    {
        public int Buscar(int[] array, int alvo)
        {
            int ultimaPos = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == alvo)
                    ultimaPos = i;
            }
            return ultimaPos;
        }
    }
}
