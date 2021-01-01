/*
Programa que pide al usuario dos números enteros.
La variable "cantidadDePositivos" valdrá 0, 1, o 2,
según lo que introduzca el usuario
*/

using System;

class Ejercicio_2_04
{
    public static void Main()
    {
        int primerNumero, segundoNumero, cantidadDePositivos = 0;

        Console.Write("Dame un número entero: ");
        primerNumero = Convert.ToInt32(Console.ReadLine());
        Console.Write("Dame otro número entero: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        cantidadDePositivos = primerNumero >= 0 ? cantidadDePositivos+1 : cantidadDePositivos; 

        cantidadDePositivos = segundoNumero >= 0 ? cantidadDePositivos+1 : cantidadDePositivos;

        Console.WriteLine(cantidadDePositivos);
    }
}