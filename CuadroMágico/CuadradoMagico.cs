using System;

namespace CuadradoMagico
{
    public class CuadradoMagico
    {
        public int[,] GenerarCuadradoMagico(int n)
        {
            if (n % 2 == 0)
                throw new ArgumentException("El tamaño debe ser impar.");

            int[,] cuadrado = new int[n, n];
            int num = 1;
            int i = 0, j = n / 2;

            while (num <= n * n)
            {
                cuadrado[i, j] = num;
                num++;
                i--;
                j++;

                if (i < 0 && j == n)
                {
                    i += 2;
                    j--;
                }
                else
                {
                    if (i < 0)
                        i = n - 1;
                    if (j == n)
                        j = 0;
                }

                if (cuadrado[i, j] != 0)
                {
                    i += 2;
                    j--;
                }
            }

            return cuadrado;
        }

        public bool EsCuadradoMagico(int[,] cuadrado)
        {
            int n = cuadrado.GetLength(0);
            int sumaMagica = (n * (n * n + 1)) / 2;

            // Verificar filas y columnas
            for (int i = 0; i < n; i++)
            {
                int sumaFila = 0, sumaColumna = 0;
                for (int j = 0; j < n; j++)
                {
                    sumaFila += cuadrado[i, j];
                    sumaColumna += cuadrado[j, i];
                }

                if (sumaFila != sumaMagica || sumaColumna != sumaMagica)
                    return false;
            }

            // Verificar diagonales
            int sumaDiagonal1 = 0, sumaDiagonal2 = 0;
            for (int i = 0; i < n; i++)
            {
                sumaDiagonal1 += cuadrado[i, i];
                sumaDiagonal2 += cuadrado[i, n - i - 1];
            }

            if (sumaDiagonal1 != sumaMagica || sumaDiagonal2 != sumaMagica)
                return false;

            return true;
        }
    }
}
