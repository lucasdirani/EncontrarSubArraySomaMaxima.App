namespace EncontrarSubArraySomaMaxima.App.Algoritmos
{
    public static class AlgoritmoSubArray
    {
        public static void EncontrarSubArrayDeSomaMaximaEmComplexidadeQuadratica(int[] arr, int n)
        {
            int indiceFinal = 0;
            int maiorSomaResultado = arr[0];
            for (int i = 0; i < n; i++) 
            {
                int maiorSomaAtual = 0;
                for (int j = i; j < n; j++)
                {
                    maiorSomaAtual += arr[j];
                    if (maiorSomaAtual > maiorSomaResultado)
                    {
                        maiorSomaResultado = maiorSomaAtual;
                        indiceFinal = j;
                    }
                }
            }
            int indiceInicial = indiceFinal;
            while (indiceInicial >= 0)
            {
                maiorSomaResultado -= arr[indiceInicial];
                if (maiorSomaResultado == 0) break;
                indiceInicial--;
            }
            for (int i = indiceInicial; i <= indiceFinal; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        public static void EncontrarSubArrayDeSomaMaximaEmComplexidadeLinear(int[] arr, int n)
        {
            int indiceFinal = 0;
            int maiorSomaAtual = arr[0];
            int maiorSomaResultado = arr[0];
            for (int i = 1; i < n; i++) 
            {
                maiorSomaAtual = arr[i] > (arr[i] + maiorSomaAtual) ? arr[i] : (arr[i] + maiorSomaAtual);
                if (maiorSomaAtual > maiorSomaResultado)
                {
                    maiorSomaResultado = maiorSomaAtual;
                    indiceFinal = i;
                }
            }
            int indiceInicial = indiceFinal;
            while (indiceInicial >= 0)
            {
                maiorSomaResultado -= arr[indiceInicial];
                if (maiorSomaResultado == 0) break;
                indiceInicial--;
            }
            for (int i = indiceInicial; i <= indiceFinal; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}