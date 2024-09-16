using System;

namespace Contar_ceros
{
    public class ContadorDeCeros
    {
        public string Contar_ceros(int[,] matriz)
        {
            int filas = matriz.GetLength(0);
            string resultado = "";

            for(int i = 0; i < filas; i++)
            {
                int contadorCeros=0;

                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    if(matriz[i,j] == 0)
                    {
                        contadorCeros++;
                    }
                }

                resultado += $"La fila {i+1} tiene {contadorCeros} ceros.\n";
            }
            return resultado;
        }
    }
}