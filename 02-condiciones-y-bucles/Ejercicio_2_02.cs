/*
Programa que pide al usuario 3 números enteros y  muestra el mayor de los tres.
Comprobar su comportamiento en varios casos de uso diferentes.
Casos: (3,5,7), (7,5,3), (5,5,3), (5,5,5)

Resuelto por oscaremilio.
*/

using System;

public class Ejercicio_2_02
{
    public static void Main()
    {
        int numero1, numero2, numero3;

        Console.Write("Introduce el primer número: ");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        numero2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce el tercer número: ");
        numero3 = Convert.ToInt32(Console.ReadLine());

        if ( (numero1 > numero2) && (numero1 > numero3) )
        {
             Console.WriteLine("{0} es el mayor", numero1);
        }
        else if ( (numero2 > numero1) && (numero2 > numero3) )
        {
             Console.WriteLine("{0} es el mayor", numero2);
        }
        else if ( (numero3 > numero1) && (numero3 > numero2) )
        {
             Console.WriteLine("{0} es el mayor", numero3);
        }

    }
}