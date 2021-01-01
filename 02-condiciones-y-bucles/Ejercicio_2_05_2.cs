
/*
Programa que pide al usuario los valores enteros de 3 notas de exámenes. En función de estos valores sacará por pantalla uno de estos mensajes:
"Has aprobado todo"
"Has suspendido todo"
"Has aprobado unas cosas y suspendido otras"
*/

using System;

class Ejercicio_2_05_2
{
    public static void Main()
    {
        int nota1, nota2, nota3;

        Console.Write("Nota 1: ");
        nota1 = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Nota 2: ");
        nota2 = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Nota 3: ");
        nota3 = Convert.ToInt32( Console.ReadLine() );

        if (nota1 >= 5 && nota2 >= 5 && nota3 >= 5)
        {
            Console.WriteLine("Has aprobado todo");
        }

        else if (nota1 < 5 && nota2 < 5 && nota3 < 5)
        {
            Console.WriteLine("Has suspendido todo");
        }

        else
        {
            Console.WriteLine("Has aprobado unas cosas y suspendido otras");
        }

    }
}