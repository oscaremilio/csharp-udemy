
/*
Programa que pide al usuario una contraseña numérica. Debe repetirse hasta que introduzca "1234", momento en el que responde "Bienvenido".
*/


using System;

class Ejercicio_2_06
{
    public static void Main()
    {
        int datoIngresado, contraseña = 1234;

        Console.Write("Introduce tu contraseña: ");
        datoIngresado = Convert.ToInt32( Console.ReadLine() );

        while( datoIngresado != contraseña)
        {
            Console.Write("Introduce tu contraseña: ");
            datoIngresado = Convert.ToInt32( Console.ReadLine() );
        }

        Console.WriteLine("Bienvenido");
    }  
}