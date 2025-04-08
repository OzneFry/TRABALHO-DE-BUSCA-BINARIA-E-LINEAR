using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuscaLinear.Interfaces;

namespace BuscaLinear.Classes
{
    public class ContagemOcorrencias : IBuscaSequencial
    {
        public int Buscar(int[] array, int alvo)
        {
            int contador = 0;
            foreach (var num in array)
            {
                if (num == alvo)
                    contador++;
            }
            return contador;
        }
    }
}
