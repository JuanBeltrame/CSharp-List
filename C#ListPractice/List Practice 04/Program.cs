using List_Practice_04;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;

// Declaración e inicialización en una sola línea:
List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

// Declaración e inicialización sin valores iniciales:
List<string> nombres = new List<string>();

// Declaración e inicialización utilizando el constructor:
List<double> precios = new List<double>(new double[] { 10.5, 20.3, 15.2 });

// Declaración sin inicialización:
List<char> letras;
letras = new List<char>();

// Declaración con capacidad inicial especificada:
List<bool> banderas = new List<bool>(10);


//-----------------------------------------------------------------------------------------------

// Declarar Objetos // En una sola Linea
List<Auto> garageDeRoman = new List<Auto>
{
    new Auto(2012, 123459, Color.Aqua, 1000M),
    new Auto(2015, 987654, Color.Red, 1500M),
    new Auto(2018, 456789, Color.Blue, 2000M)
    // Puedes seguir agregando más objetos Auto aquí si es necesario
};

// Declarar Objetos // Declaración e inicialización sin valores iniciales:
List<Auto> garageDePepe = new List<Auto>();


// Declarar Objetos // Declaración sin inicialización:
List<Auto> garageDeLucia;
garageDeLucia = new List<Auto>();


// Declarar Objetos // Declaración con capacidad inicial especificada:
List<Auto> garageDeAlejandra = new List<Auto>(10);


//-----------------------------------------------------------------------------------------------
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("GARAGE DE ROMAN");

Console.Write("La cantidad de autos que hay en el garage de ROMAN es: "+ garageDeRoman.Count);
Console.WriteLine();

Console.WriteLine();
Console.WriteLine();
foreach (var item in garageDeRoman)
{
    Console.WriteLine(item.DevolverInformacionDelAuto());
}

garageDeRoman.Contains(garageDeRoman[0]);

