
/*
Usando bucles con "for":
- muestra los números 1 al 20
- muestra los pares del 2 al 16
- muestra los impares del 15 al 5, descendiendo.
*/


using System;

class Ejercicio_2_08
{
    public static void Main()
    {
        for(int i=1; i<=20; i++)
        {
            Console.Write("{0} ", i);
        }
        
        Console.WriteLine();

        for(int i=2; i<=16; i++)
        {
            if ( (i%2) == 0)
            {
                Console.Write("{0} ", i);
            }
        }

        // Otra opción
        /*
          for(int i=2; i<=16; i = i + 2)
        {
                Console.Write("{0} ", i);
        }
        */
        
        Console.WriteLine();
        
        for(int i=15; i>=5; i--)
        {
            if ( (i%2) != 0)
            {
                Console.Write("{0} ", i);
            }
        }

        // Otra opción
        /*
        for(int i=15; i>=5; i = i - 2)
        {
                Console.Write("{0} ", i);
        }
        */
    }  
}