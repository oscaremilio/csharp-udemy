
/*
Programa que pide al usuario una contraseña numérica. Debe repetirse hasta que introduzca "1234", momento en el que responde "Bienvenido".
Debes usar "Do-While".
*/


using System;

class Ejercicio_2_07
{
    public static void Main()
    {
        int datoIngresado, contraseña = 1234;

        do
        {
            Console.Write("Introduce tu contraseña: ");
            datoIngresado = Convert.ToInt32( Console.ReadLine() );
        }
        while( datoIngresado != contraseña);

        Console.WriteLine("Bienvenido");
    }  
}