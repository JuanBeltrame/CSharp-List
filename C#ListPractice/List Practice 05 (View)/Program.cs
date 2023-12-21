using List_Practice_05__Library_;

static void AgregarJugador(Equipo equipo, Jugador jugador)
{
    if (equipo + jugador)
    {
        Console.WriteLine($"Jugador Agregado: {jugador.MostrarDatos()}");
    }
    else
    {
        Console.WriteLine($"No se pudo agregar el jugador: {jugador.MostrarDatos()}");
    }
}


//-------Programa Principal------------

Equipo equipo = new Equipo("Equipo", 2);

Jugador jugador01 = new Jugador(1234, "Lauti", 3, 2);
Jugador jugador02 = new Jugador(1234, "Lucas", 6, 1);
Jugador jugador03 = new Jugador(12342314, "Fede", 3, 3);
Jugador jugador04 = new Jugador(123334, "Esteban", 0, 3);

Console.WriteLine(jugador01.MostrarDatos());

AgregarJugador(equipo, jugador01); // Se tiene que agregar;
AgregarJugador(equipo, jugador02); // NO tiene que agregar (mismo dni);
AgregarJugador(equipo, jugador03); // Se tiene que agregar;
AgregarJugador(equipo, jugador04); // NO se tiene que agregar (por falta de capacidad);





