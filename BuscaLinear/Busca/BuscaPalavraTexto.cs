using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuscaLinear.Busca
{
    public class BuscaPalavraTexto
    {
        public int Buscar(string texto, string palavra)
        {
            if (string.IsNullOrEmpty(texto))
                return -1;
            if (string.IsNullOrEmpty(palavra))
                return -1;

            return texto.IndexOf(palavra, StringComparison.OrdinalIgnoreCase);
        }
    }
}
