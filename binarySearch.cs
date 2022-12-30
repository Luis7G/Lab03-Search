namespace Lab03_Search;
using System;
using System.Diagnostics;

class Program
{
    static void Main2(string[] args)
    {
        Stopwatch Temporizador = new Stopwatch();
        Temporizador.Start();
        int[] A = new int[] { -8, 4, 5, 9, 12, 18, 25, -40, 60, 10, 70, 20, 13, 15, -22, 16, 55, -52, 51, 68 };
        int n = A.Length;
        Array.Sort(A);
        Console.WriteLine("Arreglo ordenado: ");
        for (int i = 0; i < n - 1; i++)
        {
            Console.Write($"A[{i}]={A[i]}, \n");
        }
        Console.WriteLine($"A[{19}]={A[19]}");
        Console.WriteLine();
        int posicionEncontrada = busquedaBinaria(A, n, -40); //-40 es el elemento a buscar.
        Console.WriteLine("El número -40 se encuentra en la posicion: {0}", posicionEncontrada);
        Console.WriteLine();
        Console.WriteLine("Escribir el valor que quiere encontrar dentro del arreglo");
        int valorPorTeclado = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        int posicionEncontrada2 = busquedaBinaria(A, n, valorPorTeclado); // nueva variable que contiene el elemento a buscar
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
    static int busquedaBinaria(int[] lista, int n, int clave)
    {
        int central, bajo = 0, alto = n - 1;
        int valorCentral;
        while (bajo <= alto)
        {
            central = (bajo + alto) / 2;
            /* indice de elemento central */
            valorCentral = lista[central];
            /* valor del indice central */
            if (lista[central] == clave)
                return central; /* encontrado, devuelve posicion */
            else if (clave < lista[central])
                alto = central - 1; /* ir a sublista inferior */
            else
                bajo = central + 1; /* ir a sublista superior */
        }
        return -1;
        /* elemento no encontrado */
    }
}
