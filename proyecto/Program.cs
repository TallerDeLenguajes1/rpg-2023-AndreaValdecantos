﻿using RPG;

FabricaDePersonaje fabrica = new FabricaDePersonaje();
List<Personaje> listaDePersonajes = new List<Personaje>();
PersonajesJson archivoJsonPersonajes = new PersonajesJson();
string rutaArchivo = "archivoJsonPersonajes.txt";

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Blue;

if (archivoJsonPersonajes.Existe(rutaArchivo))
{
    listaDePersonajes = archivoJsonPersonajes.LeerPersonajes(rutaArchivo);
}
else
{
    for (int i = 0; i < 10; i++)
    {
        listaDePersonajes.Add(fabrica.generarPersonaje(i));
    }
    archivoJsonPersonajes.GuardarPersonajes(listaDePersonajes, rutaArchivo);
}

Console.WriteLine("============================================");
Console.WriteLine("-----------LISTA DE PARTICIPANTES-----------");
Console.WriteLine("============================================");
MostrarPersonajes(listaDePersonajes);

Console.WriteLine("\n\nPresione una tecla para comenzar la competencia...\n");
Console.ReadKey();
Console.Clear();

Console.ResetColor();
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n\n=======================================================================");
Console.WriteLine("-------------¡¡¡¡¡¡¡¡¡¡QUE COMIENCEN LAS BATALLAS!!!!!!!!!-------------");
Console.WriteLine("=======================================================================\n");

Competencia(listaDePersonajes);

void Competencia(List<Personaje> listaDePersonajes)
{
    Personaje ganadorDeLaCompetencia;
    int numeroDeCombate = 1;

    while (listaDePersonajes.Count() > 1)
    {
        CombateEntreDos(listaDePersonajes, numeroDeCombate);
        numeroDeCombate++;
    }
    ganadorDeLaCompetencia = listaDePersonajes[0];

    Console.ResetColor();
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\n\n===============================================");
    Console.WriteLine("---------¡GANADOR DE LA COMPETENCIA!-----------");
    Console.WriteLine("===============================================\n");
    ganadorDeLaCompetencia.MostrarPersonaje();
    Console.ResetColor();
}

List<Personaje> CombateEntreDos(List<Personaje> listaDePersonajes, int numeroDeCombate)
{
    Random numeroAleatorio = new Random();
    Personaje personajeUno;
    Personaje personajeDos;
    Personaje ganadorDelCombate;
    int turno = 1;

    do
    {
        personajeUno = listaDePersonajes[numeroAleatorio.Next(listaDePersonajes.Count())];
        personajeDos = listaDePersonajes[numeroAleatorio.Next(listaDePersonajes.Count())];
    } while (personajeUno.apodo == personajeDos.apodo);

    Console.WriteLine("-----------COMBATE " + numeroDeCombate + "-------------");
    Console.WriteLine("\n---------CONTRINCANTES-----------");
    Console.WriteLine(personajeUno.apodo + " ···VS··· " + personajeDos.apodo);

    do
    {
        if (turno % 2 != 0) //en los turnos impares ataque el personajeUno y pierde salud el PersonajeDos
        {
            personajeDos.salud = personajeDos.salud - CalcularDañoProvocado(personajeUno, personajeDos, numeroAleatorio);
        }
        else
        { //en los turnos pares al revés
            personajeUno.salud = personajeUno.salud - CalcularDañoProvocado(personajeDos, personajeUno, numeroAleatorio);
        }
        turno++;
    } while (personajeUno.salud > 0 && personajeDos.salud > 0);

    if (personajeUno.salud <= 0 || personajeDos.salud <= 0) //si uno de los personajes perdió
    {
        if (personajeUno.salud <= 0)
        {
            ganadorDelCombate = personajeDos;
            listaDePersonajes.Remove(personajeUno);
            personajeDos.salud += 10;
            personajeDos.armadura += 5;
        }
        else
        {
            ganadorDelCombate = personajeUno;
            listaDePersonajes.Remove(personajeDos);
            personajeUno.salud += 10;
            personajeUno.armadura += 5;
        }
        Console.WriteLine("\n---------GANADOR DEL COMBATE-----------");
        Console.WriteLine("Apodo: " + ganadorDelCombate.apodo);
        Console.WriteLine("Salud: " + ganadorDelCombate.salud);
        Console.WriteLine("\n\nPresione una tecla para continuar con la competencia...\n");
        Console.ReadKey();
        Console.Clear();
    }

    return listaDePersonajes;
}

int CalcularDañoProvocado(Personaje personajeQueAtaca, Personaje personajeQueSeDefiende, Random numeroAleatorio)
{
    int dañoProvocado = 0;
    dañoProvocado = (((personajeQueAtaca.destreza * personajeQueAtaca.fuerza * personajeQueAtaca.nivel) * numeroAleatorio.Next(1, 100)) - (personajeQueSeDefiende.armadura * personajeQueSeDefiende.velocidad)) / 500;

    return dañoProvocado;
}
void MostrarPersonajes(List<Personaje> listaDePersonajes)
{
    for (int i = 0; i < listaDePersonajes.Count(); i++)
    {
        listaDePersonajes[i].MostrarPersonaje();
    }
}