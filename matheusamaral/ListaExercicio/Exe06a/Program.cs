using System;

class Program
{
    static void Main()
    {
        // Criar um vetor de 10 posições
        int[] vetor = new int[10];  // Mantenha 10 ou ajuste para 1000 conforme necessário.

        // Gerar um valor randômico
        Random r = new Random();

        // Preencher o vetor com valores aleatórios
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = r.Next(1000); // Números aleatórios de 0 a 999
        }

        // Imprimir o vetor com valores aleatórios
        Console.WriteLine("Vetor original:");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }
        Console.WriteLine(); // Nova linha para separar

        // Ordenar o vetor com o Bubble Sort
        bool troca;

        do
        {
            troca = false; // Redefinir troca a cada iteração
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                // Trocar valores se necessário
                if (vetor[i] > vetor[i + 1])
                {
                    int aux = vetor[i];
                    vetor[i] = vetor[i + 1];
                    vetor[i + 1] = aux;
                    troca = true; // Indica que houve uma troca
                }
            }
        } while (troca); // Continuar enquanto houver trocas

        // Imprimir o vetor ordenado
        Console.WriteLine("Vetor depois de ordenar:");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }
    }
}
