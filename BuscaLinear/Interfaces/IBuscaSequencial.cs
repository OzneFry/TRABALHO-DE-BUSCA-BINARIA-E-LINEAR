using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuscaLinear.Interfaces
{
    public interface IBuscaSequencial
    {
        int Buscar(int[] array, int alvo);
    }

    public interface IBuscaSequencial<T>
    {
        int Buscar(T[] array, T alvo);
    }
}
