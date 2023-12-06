using List_Practice_04;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
// Las Colecciones en C# son objetos, por lo tanto ademas, son tipos de referencia

// Forma 1: Declaracion y asignacion en una Linea sin valores iniciales
List<string> nombres = new List<string>();

// Forma 2: Declaración y asignación en una línea sin valores iniciales con capacidad inicial especificada
List<bool> banderas = new List<bool>(10);

// Forma 3: Declaración e inicialización en una sola línea con elementos
List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

// Forma 4: Declaracion y asignacion en varias Lineas
List<char> letras;
letras = new List<char>();

//-----------------------------------------------------------------------------------------------

// Forma 1: Declarar Objetos // Declaracion y asignacion en una Linea sin valores iniciales
List<Auto> garageDePepe = new List<Auto>();

// Forma 2: Declarar Objetos // Declaración y asignación en una línea sin valores iniciales con capacidad inicial especificada
List<Auto> garageDeAlejandra = new List<Auto>(10);

// Forma 3 Declarar Objetos // Declaración e inicialización en una sola línea con elementos
List<Auto> garageDeRoman = new List<Auto>
{
    new Auto(2012, 123459, Color.Aqua, 1000M),
    new Auto(2015, 987654, Color.Red, 1500M),
    new Auto(2018, 456789, Color.Blue, 2000M)
    // Puedes seguir agregando más objetos Auto aquí si es necesario
};

// Forma 4: Declarar Objetos // Declaracion y asignacion en varias Lineas
List<Auto> garageDeLucia;
garageDeLucia = new List<Auto>();


//-----------------------------------------------------------------------------------------------
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("BIENVENIDO - GARAGE DE ROMAN");

Console.Write("La cantidad de autos que hay en el garage de ROMAN es: " + garageDeRoman.Count);
Console.WriteLine();

Console.WriteLine();
Console.WriteLine();
foreach (var item in garageDeRoman)
{
    Console.WriteLine(item.GetCarInfo());
}

if (garageDeRoman.Contains(garageDeRoman[0]))
{
    Console.WriteLine("El auto de la cochera 0, se encuentra estacionado");
}

if (garageDeRoman.ElementAt(0) != null)
{
    Console.WriteLine("El elemento en la posicion 0 no es null, ");

}
else
{
    Console.WriteLine("El elemento es null");
}

int capacidaActual = garageDeRoman.Capacity;
Console.WriteLine("La capacidad ocupada del garage actualmente es: " + capacidaActual);


//-----------------------------------------------------------------------------------------------
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("BIENVENIDO - GARAGE DE PEPE");

Auto a0 = new Auto(2012, 123459, Color.Aqua, 1000M);
Auto a1 = new Auto(2012, 123459, Color.Aqua, 1000M);
Auto a2 = new Auto(2012, 123459, Color.Aqua, 1000M);
Auto a3 = new Auto(2012, 123459, Color.Aqua, 1000M);
Auto a4 = new Auto(2012, 123459, Color.Aqua, 1000M);

void IngresarAuto()
{
    garageDePepe.Add(a0);
    garageDePepe.Add(a1);
    garageDePepe.Add(a2);
    garageDePepe.Add(a3);
    garageDePepe.Add(a4);
}

void RemoverTodosLosAutos()
{
    garageDePepe.RemoveRange(0, garageDePepe.Count);
}

void OtraFormaDeRemoverTodosLosAutos()
{
    garageDePepe.Clear();
}