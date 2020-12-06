/*
Programa que pide al usuario dos números y muestra el mayor de ellos.
Si introduce dos números iguales, como 1000 y 1000,
la respuesta seguirá siendo "El mayor es 1000"

Realizado por oscaremilio.
*/

using System;

public class Ejercicio_1_09_1
{
    public static void Main()
    {   
        int numero1, numero2;

        Console.Write("Número 1: ");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Número 2: ");
        numero2 = Convert.ToInt32(Console.ReadLine());

        if (numero1 >= numero2)
        {
            Console.WriteLine("EL mayor es {0}", numero1);
        }

        else 
        {
            Console.WriteLine("El mayor es {0}", numero2);
        }
    }
}