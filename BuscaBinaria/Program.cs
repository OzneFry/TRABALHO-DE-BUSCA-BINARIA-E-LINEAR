using BuscaBinaria;
using BuscaBinaria.Classes;
using BuscaBinaria.Interfaces;

class Programa
{
    static void Main(string[] args)
    {
        static void TestarBusca(IBuscaBinaria buscador, int[] array, int alvo, string nomeTeste)
        {
            Console.WriteLine($"\n--- {nomeTeste} ---");
            Console.WriteLine($"Array: [{string.Join(", ", array)}]");
            Console.WriteLine($"Alvo: {alvo}");

            int resultado = buscador.Buscar(array, alvo);

            if (resultado != -1)
                Console.WriteLine($"Resultado: {resultado}");
            else
                Console.WriteLine("Não encontrado");
        }
        int[] arrayOrdenado = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] arrayComDuplicatas = { 1, 2, 2, 2, 3, 4, 4, 5, 5, 5, 6 };

        Console.WriteLine("=== Testando Busca Binária ===");

        TestarBusca(new BuscaBinariaBasica(), arrayOrdenado, 6, "Busca básica");
        TestarBusca(new VerificacaoExistencia(), arrayOrdenado, 11, "Verificação de existência");
        TestarBusca(new MultiplasOcorrencias(), arrayComDuplicatas, 2, "Múltiplas ocorrências");
        TestarBusca(new MaiorNumeroMenorQueX(), arrayOrdenado, 7, "Maior número menor que X");
        TestarBusca(new MenorNumeroMaiorQueX(), arrayOrdenado, 7, "Menor número maior que X");
        TestarBusca(new PosicaoInsercao(), arrayOrdenado, 5, "Posição de inserção");
        TestarBusca(new PrimeiraOcorrencia(), arrayComDuplicatas, 5, "Primeira ocorrência");
        TestarBusca(new UltimaOcorrencia(), arrayComDuplicatas, 5, "Última ocorrência");
        TestarBusca(new NumeroMaisProximo(), arrayOrdenado, 6, "Número mais próximo");
    }
}
