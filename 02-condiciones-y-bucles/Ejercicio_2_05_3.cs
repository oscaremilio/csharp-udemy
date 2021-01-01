
/*
Programa que pide al usuario que introduzca un carácter suelto. Después identificará si dicho carácter es un signo de puntuación, un dígito del 0 al 9, o cualquier otra cosa.
*/

using System;

class Ejercicio_2_05_3
{
    public static void Main()
    {
        char simbolo;

        Console.Write("Escribe un carácter: ");
        simbolo = Convert.ToChar( Console.ReadLine() );

        switch(simbolo)
        {
            case '.':
            case ',':
            case ':':
            case ';':
                     Console.WriteLine("Signo de puntuación");
                     break;
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
                     Console.WriteLine("Es un dígito");
                     break;
            default:
                    Console.WriteLine("No es un signo de puntuación ni un dígito");
                    break;
        }
    }  
}