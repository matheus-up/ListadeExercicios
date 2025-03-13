using System;

class Program
{
    static void Main()
    {
        // Criar um vetor de 1000 posições
        int[] vetor = new int[1000];

        // Gerar valores aleatórios para o vetor
        Random r = new Random();
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = r.Next(10000); // Números aleatórios de 0 a 9999
        }

        // Imprimir o vetor original
        Console.WriteLine("Vetor original (primeiros 20 números):");
        for (int i = 0; i < 20; i++) // Exibindo apenas os primeiros 20 números para facilitar a visualização
        {
            Console.Write(vetor[i] + " ");
        }
        Console.WriteLine(); // Nova linha para separar

        // Ordenar o vetor utilizando o método Array.Sort()
        Array.Sort(vetor);

        // Imprimir o vetor ordenado
        Console.WriteLine("Vetor depois de ordenar (primeiros 100 números):");
        for (int i = 0; i < 100; i++) // Agora estamos exibindo os primeiros 100 números após a ordenação
        {
            Console.Write(vetor[i] + " ");
        }
        Console.WriteLine(); // Nova linha para separar
    }
}
