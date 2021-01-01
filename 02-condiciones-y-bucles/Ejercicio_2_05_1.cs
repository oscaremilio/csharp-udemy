
/*
Programa que pide al usuario 2 numeros enteros. Si el segundo número no es 0, mostrar en pantalla el resultado de la división (primero entre segundo).
Si el segundo número es 0, mostrar el mensaje: "Error: No se puede dividir por cero"
*/

using System;

class Ejercicio_2_05_1
{
    public static void Main()
    {
        int primerNumero, segundoNumero;

        Console.Write("Dame un número entero: ");
        primerNumero = Convert.ToInt32(Console.ReadLine());
        Console.Write("Dame otro número entero: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        if (segundoNumero != 0) 
        {
            Console.WriteLine("{0} / {1} = {2}", primerNumero, segundoNumero, primerNumero / segundoNumero);
        }

        else 
        {
            Console.WriteLine("Error: No se puede dividir por cero");
        }

    }
}