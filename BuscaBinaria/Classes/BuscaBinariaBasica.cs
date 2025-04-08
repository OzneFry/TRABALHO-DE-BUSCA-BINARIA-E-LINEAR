using BuscaBinaria.Interfaces;

public class BuscaBinariaBasica : IBuscaBinaria
{
    public int Buscar(int[] array, int alvo)
    {
        int esquerda = 0;
        int direita = array.Length - 1;

        while (esquerda <= direita)
        {
            int meio = esquerda + (direita - esquerda) / 2;

            if (array[meio] == alvo)
                return meio;
            else if (array[meio] < alvo)
                esquerda = meio + 1;
            else
                direita = meio - 1;
        }

        return -1;
    }
}

public class VerificacaoExistencia : IBuscaBinaria
{
    public int Buscar(int[] array, int alvo)
    {
        var busca = new BuscaBinariaBasica();
        return busca.Buscar(array, alvo) != -1 ? 1 : -1;
    }
}
