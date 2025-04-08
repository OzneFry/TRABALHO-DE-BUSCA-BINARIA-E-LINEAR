using BuscaLinear.Busca;
using BuscaLinear.Classes;
using BuscaLinear.Interfaces;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Testando Busca Sequencial ===");

        int[] numeros = { 5, 2, 8, 1, 9, 3, 7, 4, 6, 2, 8 };
        string[] nomes = { "Ana", "João", "Maria", "Carlos", "Beatriz" };
        Aluno[] alunos =
        {
            new Aluno("Ana", 1001),
            new Aluno("João", 1002),
            new Aluno("Maria", 1003),
        };

        TestarBusca(new BuscaSequencialBasica(), numeros, 8, "Busca básica");
        TestarBusca(new ContagemOcorrencias(), numeros, 2, "Contagem de ocorrências");
        TestarBusca(new BuscaStrings(), nomes, "maria", "Busca em strings");

        var maiorMenor = new MaiorMenorElemento().Encontrar(numeros);
        Console.WriteLine(
            $"\nMaior e menor elemento: Maior = {maiorMenor.maior}, Menor = {maiorMenor.menor}"
        );

        TestarBusca(new MultiploDeX(), numeros, 3, "Múltiplo de X");

        int posAluno = new BuscaAlunos().Buscar(alunos, new Aluno("", 1002));
        Console.WriteLine(
            $"\nBusca de aluno: Posição = {posAluno}, Nome = {alunos[posAluno].Nome}"
        );

        TestarBusca(new UltimaOcorrenciaSequencial(), numeros, 8, "Última ocorrência");
        TestarBusca(new PrimeiroPar(), numeros, 0, "Primeiro número par");
        TestarBusca(new BuscaComSentinela(), numeros, 4, "Busca com sentinela");

        string texto = "Esta é uma string de exemplo para busca";
        int posPalavra = new BuscaPalavraTexto().Buscar(texto, "exemplo");
        Console.WriteLine($"\nBusca de palavra: Posição = {posPalavra}");
    }

    static void TestarBusca(IBuscaSequencial buscador, int[] array, int alvo, string nomeTeste)
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

    static void TestarBusca<T>(IBuscaSequencial<T> buscador, T[] array, T alvo, string nomeTeste)
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
}
