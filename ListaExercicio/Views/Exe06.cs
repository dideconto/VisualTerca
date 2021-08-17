using System;

namespace ListaExercicio.Views
{
    public class Exe06
    {
        public static void Renderizar()
        {
            const int TAMANHO_VETOR = 10000;
            const int LIMITE_NUMEROS = 10001;

            Random random = new Random();
            int[] numeros = new int[TAMANHO_VETOR];

            //Popular o vetor com números aleatórios
            for (int i = 0; i < TAMANHO_VETOR; i++)
            {
                numeros[i] = random.Next(LIMITE_NUMEROS);
            }

            //Imprimir os valores do vetor
            foreach (int numero in numeros)
            {
                Console.Write($"{ numero } ");
            }

            // Ordenar o vetor utilizando o bubble sort
            bool troca = false;
            do
            {
                troca = false;
                for (int i = 0; i < TAMANHO_VETOR - 1; i++)
                {
                    if (numeros[i] > numeros[i + 1])
                    {
                        int aux = numeros[i];
                        numeros[i] = numeros[i + 1];
                        numeros[i + 1] = aux;
                        troca = true;
                    }
                }
            } while (troca);

            // Ordenação automática do C#
            // Array.Sort(numeros);
            Console.WriteLine("\n\n");
            //Imprimir os valores do vetor ordenado
            foreach (int numero in numeros)
            {
                Console.Write($"{ numero } ");
            }
        }
    }
}