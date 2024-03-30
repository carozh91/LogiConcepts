using System.ComponentModel.Design;
var number = string.Empty;
do
{
    Console.Write("Ingrese numero o presione 'salir' para salir: ");
    number = Console.ReadLine();
    if (number.ToLower() == "salir")
    {
        continue;
    }
      
   
    var numberN = 0;
    if (int.TryParse(number, out numberN))
    {
        if (numberN % 2 == 0)
        {
            Console.WriteLine($"El número {numberN} es par");
        }
        else
        {
            Console.WriteLine($"El número {numberN} es impar");
        }
    }
    else
    {
        Console.WriteLine($"Lo que ingresaste {number} no es un número");
    }
} while (number.ToLower() != "salir");
Console.WriteLine("Game Over.");

