using List_Practice_02;
using System.Drawing;
using System.Collections.Generic;


internal class Program
{
    private static void Main(string[] args)
    {

        Estacionamiento unEstacionamiento = new Estacionamiento(10);


        Auto a1 = new Auto("zzz445", "Blanco", 493439);
        Auto a2 = new Auto("zzz445", "Negro", 1234);
        Auto a3 = new Auto("zzz445", "Rojo", 4445454);
        Auto a4 = new Auto("zzz445", "Verde", 89898);

        unEstacionamiento.IngresarAuto(a1);
        unEstacionamiento.IngresarAuto(a2);
        unEstacionamiento.IngresarAuto(a3);
        unEstacionamiento.IngresarAuto(a4);

        string informacion = unEstacionamiento.GetParkinInfo();
        Console.WriteLine(informacion);
    }
}