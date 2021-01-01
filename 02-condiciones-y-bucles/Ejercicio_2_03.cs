/*
Pide al usuario el número de un día de la semana
y muestra el nombre de ese día (o un mensaje de aviso,
si se trata de un número incorrecto)
*/

using System;

class Ejercicio_2_03
{
    public static void Main()
    {
        int numero;

        Console.Write("Dime el número de un día de la semana: ");
        numero = Convert.ToInt32(Console.ReadLine());

        switch (numero)
        {
            case 1: 
                    Console.WriteLine("Lunes");
                    break;
            case 2: 
                    Console.WriteLine("Martes");
                    break;
            case 3: 
                    Console.WriteLine("Miércoles");
                    break;
            case 4: 
                    Console.WriteLine("Jueves");
                    break;
            case 5: 
                    Console.WriteLine("Viernes");
                    break;
            case 6: 
                    Console.WriteLine("Sábado");
                    break;
            case 7: 
                    Console.WriteLine("Domingo");
                    break;
            default:
                    Console.WriteLine("Es un número incorrecto");
                    break;
        }

    }
}