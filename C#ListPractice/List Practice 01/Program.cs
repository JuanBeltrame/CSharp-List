using List_Practice_01;

// Las listas son objetos, porque se instancian con un NEW y tienen su constructor
List<string> nombres = new List<string>();

// El metodo .Add es para agregar elementos a una lista. 
nombres.Add("Lautaro");
nombres.Add("Juan");
nombres.Add("Batman");
nombres.Add("Superman");


Console.WriteLine("Para recorrer listas, se realizan con un foreach: ");
foreach (var item in nombres)
{
    Console.Write(item+ " ");
    
}


Console.WriteLine("Las listas estas indexadas, al igual que los arrays, por lo tanto tambien se puede hacer lo siguiente: ");
Console.Write("En este caso mostrar lo que esta en la posicion 0: ");
Console.WriteLine(nombres[0]);

// Para remover un elemento de la lista con .Remove
nombres.Remove("Batman");
// Otra forma es la siguiente: Utilizando .RemoveAt 
nombres.RemoveAt(2);


Console.WriteLine("Ahora con un elemento de la lista eliminado: ");
foreach (var item in nombres)
{
    Console.Write(item + " ");
}

// La pri.Count, me devuelve la cantidad de elementos de la coleccion. 
Console.WriteLine(nombres.Count);




List<Auto> garage = new List<Auto>();


Auto auto1 = new Auto("12345", "Fiat");
Auto auto2 = new Auto("12345", "Fiat");
Auto auto3 = new Auto("12345", "Fiat");

garage.Add(auto1);
garage.Add(auto2);
garage.Add(auto3);












