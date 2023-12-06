using System.Collections.Generic;

//-------------Lista usando NUMEROS -------------------------------------------------
List<int> edades = new List<int>();

// Esta es una forma de agregar elementos, usando .add
edades.Add(1);
edades.Add(2);
edades.Add(3);
edades.Add(4);

// Otra forma es, la siguiente, y se pueden realizar por que las listas estan indexadas.
edades[0] = 100;

// Metodo Insert
edades.Insert(1, -5);

// Propiedad Count
Console.WriteLine("Cantidad de Elementos");
Console.WriteLine(edades.Count);

// Metodo IndexOf
Console.WriteLine("La posicion del -5 es: " + edades.IndexOf(-5));

Console.WriteLine(  );
Console.WriteLine("Listar todos los elementos");
foreach (var item in edades)
{
    Console.WriteLine(item);
}

for (int i = 0; i < edades.Count; i++)
{
    if (edades[i] > 3)
    {
        edades.RemoveAt(i);
    }
}

Console.WriteLine(  );
Console.WriteLine("Listar todos los elementos Actualizados");
foreach (var item in edades)
{
    Console.WriteLine(item);
}






