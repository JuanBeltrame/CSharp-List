using List_Practice_01;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        //-------------Lista usando OBJETOS -------------------------------------------------
        List<Auto> garage = new List<Auto>();

        Auto auto1 = new Auto("12345", "Fiat", 2005);
        Auto auto2 = new Auto("12345", "Fiat", 1998);
        Auto auto3 = new Auto("12345", "Fiat", 2002);

        garage.Add(auto1);
        garage.Add(auto2);
        garage.Add(auto3);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Muestro los autos sin ningun criterio de ordenamiento");
        foreach (var item in garage)
        {
            Console.WriteLine(item);
        }

        static int CompararObjetos(Auto a, Auto b)
        {
            return a.modelo - b.modelo;
        }

        Console.WriteLine("Autos ordenamos por Modelo");
        garage.Sort(CompararObjetos);
        foreach (var item in garage)
        {
            Console.WriteLine(item.ToString());
        }


        //-------------Lista usando STRINGS(nombres)-------------------------------------------------

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("---------Lista usando STRINGS---------");
        // Las listas son objetos, porque se instancian con un NEW y tienen su constructor
        List<string> nombres = new List<string>();

        // El metodo .Add es para agregar elementos a una lista. 
        nombres.Add("Lautaro");
        nombres.Add("Juan");
        nombres.Add("Batman");
        nombres.Add("Superman");

        Console.WriteLine(". Para recorrer listas, se realizan con un foreach: ");
        foreach (string item in nombres)
        {
            Console.Write(item + " ");

        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(". Las listas estan indexadas, al igual que los arrays, por lo tanto tambien se puede hacer lo siguiente: ");
        Console.Write(". En este caso mostrar lo que esta en la posicion 0: ");
        Console.WriteLine(nombres[0]);

        // Para remover un elemento de la lista con .Remove
        nombres.Remove("Batman");
        // Otra forma es la siguiente: Utilizando .RemoveAt 
        nombres.RemoveAt(2);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(". Ahora con dos elementos de la lista eliminado: ");
        foreach (var item in nombres)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(". La propiedad .Count, me devuelve la cantidad de elementos de la coleccion.");
        Console.WriteLine(nombres.Count);




        //-------------Lista usando NUMEROS -------------------------------------------------
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("---------Lista usando NUMEROS---------");
        List<int> numeros = new List<int>();

        numeros.Add(10);
        numeros.Add(4);
        numeros.Add(50);
        numeros.Add(20);
        numeros.Add(2);

        foreach (int item in numeros)
        {
            Console.Write(item + " - ");
        }

        static int CompararNumeros(int a, int b)
        {
            return a - b;
        }


        numeros.Sort(CompararNumeros);

        Console.WriteLine();
        Console.WriteLine();
        foreach (int item in numeros)
        {
            Console.Write(item + " - ");
        }
    }
}