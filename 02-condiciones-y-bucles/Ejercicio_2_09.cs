
/*
Programa que muestra los números del 1 al 20, excepto el 10, usando "continue", y los números del 1 al 20, deteniendolo en 10 usando "break".
*/


using System;

class Ejercicio_2_09
{
    public static void Main()
    {
        for(int i=1; i<=20; i++)
        {
            if (i == 10)
            {
                continue;
            }

            Console.Write("{0} ", i);
        }

        Console.WriteLine();

        for(int i=1; i<=20; i++)
        {
            if (i == 10)
            {
                break;
            }

            Console.Write("{0} ", i);
        }

    }  
}