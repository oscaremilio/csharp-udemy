/*
Programa que define dos variables enteras
con los valores que quieras,
y muestre el resultado de su división 
y de su resto por pantalla.

Usa los índices entre llaves que servirán 
para colocar las variables en su lugar.

Realizado por oscaremilio
*/

using System;

class Ejercicio_1_09_2
{
    public static void Main()
    {
        int a = 20, b = 3;
        
        Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        Console.WriteLine("{0} % {1} = {2}", a, b, a % b);
    }
}