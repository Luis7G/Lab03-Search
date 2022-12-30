namespace Lab03_Search;
using System;
using System.Diagnostics;
class linearSearch
{
    static void Main1(string[] args)
    {
        Stopwatch Temporizador = new Stopwatch();
        Temporizador.Start();
        int[] A = { 79, 21, 15, 99, 88, 65, 75, 85, 76, 46, 84, 24, 13, 44, 11, 12, 15, 54, 165, 20 };
        int n = A.Length;
        Console.WriteLine("Arreglo desordenado: ");
        for (int i = 0; i < n - 1; i++)
        {
            Console.Write($"A[{i}]={A[i]}, \n");
        }
        Console.WriteLine($"A[{19}]={A[19]}");
        int posicionEncontrada = BusquedaLinealID(A, n, 65); // 65 es el elemento a buscar
        Console.WriteLine("El número 65 se encuentra en la posición: " + posicionEncontrada);
        Console.WriteLine();
        Console.WriteLine("Escribir el valor que quiere encontrar dentro del arreglo");
        int valorPorTeclado = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        int posicionEncontrada2 = BusquedaLinealID(A, n, valorPorTeclado); // nueva variable que contiene el elemento a buscar
        if (posicionEncontrada2 == -1)
        {
            Console.WriteLine("El número no se encuentra en el arreglo");
        }
        else
        {
            Console.WriteLine("El número se encuentra en la posición: " + posicionEncontrada2);
        }
        Temporizador.Stop();
        TimeSpan timeSpan = Temporizador.Elapsed;
        Console.WriteLine("->El programa se ejecutó en {0}h {1}m {2}s {3}ms", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);
    }

    public static int BusquedaLinealID(int[] A, int n, float clave)
    {
        int i;
        for (i = 0; i < n; i++)
            if (A[i] == clave)
                return i;
        return -1;
    }
}
