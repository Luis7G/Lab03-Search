namespace Lab03_Search;
using System;
using System.Diagnostics;
class ejercicioFinal
{
    static void Main(string[] args)
    {
        Stopwatch Temporizador = new Stopwatch();
        Temporizador.Start();
        Random rnd = new Random();
        int[] values = new int[100];
        int[] values2 = new int[50];
        int posicionEncontrada = 0;
        int contExito = 0;
        int contFallo = 0;
        //Generacion de array con 100 valores random entre 1 y 200  
        for (int i = 0; i < values.Length; i++)
        {
            values[i] = rnd.Next(1, 201);
        }
        //Impresion de array desordenado
        Console.WriteLine("Arreglo de 100 valores aleatorios entre 1 y 200 DESORDENADO: ");
        for (int i = 0; i < values.Length - 1; i++)
        {
            Console.Write($"A[{i}]={values[i]}, \n");
        }
        Console.WriteLine($"A[{99}]={values[99]}");
        //Generacion de los 50 valores a buscar aleatoriamente
        for (int i = 0; i < values2.Length; i++)
        {
            values2[i] = rnd.Next(1, 201);
            posicionEncontrada = BusquedaLinealID(values, values.Length, values2[i]);
            if (posicionEncontrada == -1)
            {
                contFallo++;
            }
            else
            {
                contExito++;
            }
        }
        //Impresion de array desordenado
        Console.WriteLine();
        Console.WriteLine("Arreglo de 50 valores a buscar aleatoriamente en el array DESORDENADO: ");
        for (int i = 0; i < values2.Length - 1; i++)
        {
            Console.Write($"B[{i}]={values2[i]}, \n");
        }
        Console.WriteLine($"B[{49}]={values2[49]}");
        //Impresion de busquedas con Exito y Fallo
        Console.WriteLine();
        Console.WriteLine("El número de búsquedas con Éxitos es de: " + contExito);
        Console.WriteLine("El número de búsquedas Fallidas es de: " + contFallo);
        //Impresion de porcentajes de Exito y Fallo de busquedas
        Console.WriteLine();
        float porcentajeExito = (contExito * 100) / values2.Length;
        Console.WriteLine("El porcentaje de Éxito de búsquedas es de: " + porcentajeExito + "%");
        float porcentajeFallo = (contFallo * 100) / values2.Length;
        Console.WriteLine("El porcentaje de Fallo de búsquedas es de: " + porcentajeFallo + "%");
        Array.Sort(values);
        //Impresion de array con orden creciente
        Console.WriteLine();
        Console.WriteLine("Arreglo ordenado: ");
        for (int i = 0; i < values.Length - 1; i++)
        {
            Console.Write($"A[{i}]={values[i]}, \n");
        }
        Console.WriteLine($"A[{99}]={values[99]}");
        //Fin tiempo de ejecución
        Temporizador.Stop();
        TimeSpan timeSpan = Temporizador.Elapsed;
        Console.WriteLine("->El programa se ejecutó en {0}h {1}m {2}s {3}ms", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);
    }
    //Metodo de busqueda lineal
    public static int BusquedaLinealID(int[] A, int n, int clave)
    {
        int i;
        for (i = 0; i < n; i++)
            if (A[i] == clave)
                return i;
        return -1;
    }
}
