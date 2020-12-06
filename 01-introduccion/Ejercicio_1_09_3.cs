/*
Programa que pide al usuario una temperaratura
en grados Celsius, la almacena en una variable entera,
y muestra en pantalla a cuanto grados Kelvin y a 
cuantos grados Fahrenheit equivale dicha temperatura.

Un Kelvin = Celsius + 273
Un Fahrenheit = Celsius * 18/10 + 32

Realizado por oscaremilio
*/

using System;

class Program {
    static void Main(string[] args) {
        
        int gradosCelsius, gradosKelvin, gradosFahrenheit;
        
        Console.Write("Temperatura en Grados Celsius...: ");
        gradosCelsius = Convert.ToInt32(Console.ReadLine());
        
        gradosKelvin = gradosCelsius + 273;
        gradosFahrenheit = ((gradosCelsius * 18) / 10) + 32;
        
        Console.WriteLine("Temperatura en Grados Kelvin....: {0}", gradosKelvin);
        Console.WriteLine("Temperatura en Grados Fahrenheit: {0}", gradosFahrenheit);
    }
}