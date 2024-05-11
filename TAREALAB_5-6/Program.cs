//ejercicio.1
using System;
using System.Numerics;

class Program
{
    static void ImprimirPares(int n)
    {
        if (n == 0)
            return;

        if (n % 2 == 0)
            Console.WriteLine(n);

        ImprimirPares(n - 1);
    }

    static void Main(string[] args)
    {
        ImprimirPares(100);
    }

}
//ejercicio.2
using System;

class Program
{
    static int SumaHastaN(int n)
    {
        if (n == 1)
            return 1;

        return n + SumaHastaN(n - 1);
    }

    static void Main(string[] args)
    {
        int resultado = SumaHastaN(5);
        Console.WriteLine(resultado);
    }
//ejercicio 3 :
using System;

class Program
{
    static void ImprimirPiramide(int n)
    {
        if (n == 0)
            return;

        ImprimirPiramide(n - 1);

        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        ImprimirPiramide(5);
    }
}
//ejercicio 4:  
using System;

class Program
{
    static void ImprimirPiramideInvertida(int n)
    {
        if (n == 0)
            return;

        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        ImprimirPiramideInvertida(n - 1);
    }

    static void Main(string[] args)
    {
        ImprimirPiramideInvertida(5);
    }
}

//ejercicio 5:
using System;

class Program
{
    static void TablaDeMultiplicar(int n, int i = 1)
    {
        if (i > 10)
            return;

        Console.WriteLine($"{n} x {i} = {n * i}");
        TablaDeMultiplicar(n, i + 1);
    }

    static void Main(string[] args)
    {
        TablaDeMultiplicar(5);
    }
}
//ejercicio 6:
using System;

class Program
{
    static void Main()
    {
        double[,] matrizNumerosReales = {
            {1.5, 2.3, 3.7},
            {4.2, 5.1, 6.9},
            {7.4, 8.6, 9.0}
        };

        Console.WriteLine("Matriz de números reales:");

        for (int i = 0; i < matrizNumerosReales.GetLength(0); i++)
        {
            for (int j = 0; j < matrizNumerosReales.GetLength(1); j++)
            {
                Console.Write(matrizNumerosReales[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

//ejercicio 7:
using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Complex[,] matrizNumerosComplejos = {
            {new Complex(1.5, 2.0), new Complex(2.3, -1.0), new Complex(3.7, 0)},
            {new Complex(4.2, 1.0), new Complex(5.1, 2.5), new Complex(6.9, -3.2)},
            {new Complex(7.4, -2.1), new Complex(8.6, 0.7), new Complex(9.0, 1.8)}
        };

        Console.WriteLine("Matriz de números complejos:");
        for (int i = 0; i < matrizNumerosComplejos.GetLength(0); i++)
        {
            for (int j = 0; j < matrizNumerosComplejos.GetLength(1); j++)
            {
                Console.Write(matrizNumerosComplejos[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

//ejercicio 8:
using System;

class Program
{
    static void Main()
    {
        int[][][] matrizDeMatrices = new int[2][][];
        matrizDeMatrices[0] = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 } };
        matrizDeMatrices[1] = new int[][] { new int[] { 7, 8 }, new int[] { 9, 10 }, new int[] { 11, 12 } };

        Console.WriteLine("\nMatriz de matrices:");
        for (int i = 0; i < matrizDeMatrices.Length; i++)
        {
            for (int j = 0; j < matrizDeMatrices[i].Length; j++)
            {
                for (int k = 0; k < matrizDeMatrices[i][j].Length; k++)
                {
                    Console.Write(matrizDeMatrices[i][j][k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
//ejercicio 9 :
uusing System;

class Program
{
    static void Main()
    {
        double[,] matriz = {
            {1.5, 2.3, 3.7},
            {4.2, 5.1, 6.9},
            {7.4, 8.6, 9.0}
        };
        int filaCentral = matriz.GetLength(0) / 2;
        int columnaCentral = matriz.GetLength(1) / 2;
        double elementoCentral = matriz[filaCentral, columnaCentral];
        Console.WriteLine($"\nElemento central de la matriz: {elementoCentral}");
    }
}

//ejercicio 10 :
using System;

class Program
{
    static void Main()
    {
        double[,] matriz1 = {
            {1.0, 2.0},
            {3.0, 4.0}
        };

        double[,] matriz2 = {
            {0.5, 0.5},
            {0.5, 0.5},
            {0.5, 0.5}
        };

        double[,] matrizResultado = SumarMatrices(matriz1, matriz2);

        Console.WriteLine("\nMatriz resultado de la suma:");
        MostrarMatriz(matrizResultado);
    }
    static double[,] SumarMatrices(double[,] matriz1, double[,] matriz2)
    {
        int filasResultado = Math.Max(matriz1.GetLength(0), matriz2.GetLength(0));
        int columnasResultado = Math.Max(matriz1.GetLength(1), matriz2.GetLength(1));

        double[,] matrizResultado = new double[filasResultado, columnasResultado];

        for (int i = 0; i < filasResultado; i++)
        {
            for (int j = 0; j < columnasResultado; j++)
            {
                double valorMatriz1 = (i < matriz1.GetLength(0) && j < matriz1.GetLength(1)) ? matriz1[i, j] : 0;
                double valorMatriz2 = (i < matriz2.GetLength(0) && j < matriz2.GetLength(1)) ? matriz2[i, j] : 0;
                matrizResultado[i, j] = valorMatriz1 + valorMatriz2;
            }
        }

        return matrizResultado;
    }
    static void MostrarMatriz(double[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
//ejercicio 11:
using System;

class Program
{
    static void Main()
    {
        double[,] matriz = {
            {1.0, 2.0, 3.0},
            {4.0, 5.0, 6.0},
            {7.0, 8.0, 9.0}
        };
        double escalar = 2.5;

        Console.WriteLine("Matriz original:");
        MostrarMatriz(matriz);

        double[,] matrizMultiplicada = MultiplicarMatrizPorEscalar(matriz, escalar);

        Console.WriteLine("\nMatriz multiplicada por " + escalar + ":");
        MostrarMatriz(matrizMultiplicada);
    }

    static double[,] MultiplicarMatrizPorEscalar(double[,] matriz, double escalar)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        double[,] matrizResultado = new double[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matrizResultado[i, j] = matriz[i, j] * escalar;
            }
        }

        return matrizResultado;
    }
    static void MostrarMatriz(double[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

//ejercicio 12:
using System;

class Program
{
    static void Main()
    {
        double[,] matriz = {
            {1.0, 2.0, 3.0},
            {4.0, 5.0, 6.0},
            {7.0, 8.0, 9.0}
        };

        double media = CalcularMediaMatriz(matriz);

        Console.WriteLine("La media de los elementos de la matriz es: " + media);
    }
    static double CalcularMediaMatriz(double[,] matriz)
    {
        int totalElementos = matriz.GetLength(0) * matriz.GetLength(1);
        double sumaTotal = 0;

        foreach (double elemento in matriz)
        {
            sumaTotal += elemento;
        }

        return sumaTotal / totalElementos;
    }
}

//ejercicio 13  MATRICESSS:
uusing System;

class Program
{
    static void Main()
    {
        double[,] matriz = GenerarMatrizAleatoria(100, 100);

        MostrarMatriz(matriz);
    }


    static double[,] GenerarMatrizAleatoria(int filas, int columnas)
    {
        double[,] matriz = new double[filas, columnas];
        Random random = new Random();

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] = random.NextDouble();
            }
        }

        return matriz;
    }

    static void MostrarMatriz(double[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

//ejercicio 14:
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double[,] matriz = {
            {1.0, 2.0, 3.0},
            {4.0, 5.0, 6.0},
            {7.0, 8.0, 9.0}
        };


        double media = CalcularMedia(matriz);


        double mediana = CalcularMediana(matriz);

        double desviacionEstandar = CalcularDesviacionEstandar(matriz, media);

        Console.WriteLine("Media: " + media);
        Console.WriteLine("Mediana: " + mediana);
        Console.WriteLine("Desviación estándar: " + desviacionEstandar);
    }

    static double CalcularMedia(double[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        double suma = 0;

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                suma += matriz[i, j];
            }
        }

        return suma / (filas * columnas);
    }

    static double CalcularMediana(double[,] matriz)
    {
        int totalElementos = matriz.GetLength(0) * matriz.GetLength(1);
        double[] elementos = new double[totalElementos];
        int index = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                elementos[index++] = matriz[i, j];
            }
        }

        Array.Sort(elementos);
        return totalElementos % 2 != 0 ? elementos[totalElementos / 2] : (elementos[totalElementos / 2] + elementos[totalElementos / 2 - 1]) / 2;
    }
    static double CalcularDesviacionEstandar(double[,] matriz, double media)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        double sumaCuadrados = 0;

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                sumaCuadrados += Math.Pow(matriz[i, j] - media, 2);
            }
        }

        return Math.Sqrt(sumaCuadrados / (filas * columnas));
    }
}
//ejercicio 15:
using System;

class Program
{
    static void Main()
    {
        double[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        double maximo = EncontrarMaximo(matriz);

        Console.WriteLine("El elemento máximo de la matriz es: " + maximo);
    }

    static double EncontrarMaximo(double[,] matriz)
    {
        double maximo = matriz[0, 0];

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] > maximo)
                {
                    maximo = matriz[i, j];
                }
            }
        }

        return maximo;
    }
}
//ejercicio 16:
using System;

class Program
{
    static void Main()
    {

        int[,] matriz = {
            {1, 2, -1, 4},
            {-4, -5, 6, 7},
            {8, 9, -2, -3},
            {2, -1, 3, 2}
        };

        int[,] submatrizMaxima = EncontrarSubmatrizMaxima(matriz);

        Console.WriteLine("La submatriz de mayor suma es:");
        MostrarMatriz(submatrizMaxima);
    }

    static int[,] EncontrarSubmatrizMaxima(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        int maxSuma = int.MinValue;
        int filaInicio = 0;
        int filaFin = 0;
        int columnaInicio = 0;
        int columnaFin = 0;

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                for (int k = i; k < filas; k++)
                {
                    for (int l = j; l < columnas; l++)
                    {
                        int sumaActual = CalcularSumaSubmatriz(matriz, i, j, k, l);
                        if (sumaActual > maxSuma)
                        {
                            maxSuma = sumaActual;
                            filaInicio = i;
                            filaFin = k;
                            columnaInicio = j;
                            columnaFin = l;
                        }
                    }
                }
            }
        }


        int[,] submatrizMaxima = new int[filaFin - filaInicio + 1, columnaFin - columnaInicio + 1];
        for (int i = filaInicio; i <= filaFin; i++)
        {
            for (int j = columnaInicio; j <= columnaFin; j++)
            {
                submatrizMaxima[i - filaInicio, j - columnaInicio] = matriz[i, j];
            }
        }

        return submatrizMaxima;
    }

    static int CalcularSumaSubmatriz(int[,] matriz, int filaInicio, int columnaInicio, int filaFin, int columnaFin)
    {
        int suma = 0;
        for (int i = filaInicio; i <= filaFin; i++)
        {
            for (int j = columnaInicio; j <= columnaFin; j++)
            {
                suma += matriz[i, j];
            }
        }
        return suma;
    }


    static void MostrarMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
//ejercicio 17:
using System;

class Program
{
    static void Main()
    {

        double[,] matriz1 = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        double[,] matriz2 = {
            {9, 8, 7},
            {6, 5, 4},
            {3, 2, 1}
        };

        double[,] matrizCovarianza = CalcularMatrizCovarianza(matriz1, matriz2);

        Console.WriteLine("La matriz de covarianza es:");
        MostrarMatriz(matrizCovarianza);
    }

    static double[,] CalcularMatrizCovarianza(double[,] matriz1, double[,] matriz2)
    {
        int filas = matriz1.GetLength(0);
        int columnas = matriz1.GetLength(1);
        double[,] matrizCovarianza = new double[columnas, columnas];

        double[] mediaMatriz1 = CalcularMediaColumnas(matriz1);
        double[] mediaMatriz2 = CalcularMediaColumnas(matriz2);

        for (int i = 0; i < columnas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                double covarianza = 0;
                for (int k = 0; k < filas; k++)
                {
                    covarianza += (matriz1[k, i] - mediaMatriz1[i]) * (matriz2[k, j] - mediaMatriz2[j]);
                }
                matrizCovarianza[i, j] = covarianza / filas;
            }
        }

        return matrizCovarianza;
    }


    static double[] CalcularMediaColumnas(double[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        double[] media = new double[columnas];

        for (int j = 0; j < columnas; j++)
        {
            double sumaColumna = 0;
            for (int i = 0; i < filas; i++)
            {
                sumaColumna += matriz[i, j];
            }
            media[j] = sumaColumna / filas;
        }

        return media;
    }

    static void MostrarMatriz(double[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}