using RPG;

FabricaDePersonaje fabrica = new FabricaDePersonaje();
//crear función para generar automáticamente personajes y agregarlso a la
List<Personaje> listaDePersonajes = new List<Personaje>();
PersonajesJson archivoJsonPersonajes = new PersonajesJson();
string rutaArchivo = "archivoJsonPersonajes.txt";

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

Console.WriteLine("___________________________________________");
Console.WriteLine("___________________________________________");
MostrarPersonajes(listaDePersonajes);
Console.WriteLine("\n___________________________________________");
Console.WriteLine("___________________________________________\n\n");

// El combate se realiza por turnos. Por cada turno un personaje ataca y el otro se defiende.
// La forma de calcular el daño provocado en cada turno es la siguiente:
// • Ataque: Destreza * Fuerza * Nivel (del personaje que ataca)
// • Efectividad: Valor aleatorio entre 1 y 100.
// • Defensa: Armadura * Velocidad (del personaje que defiende)
// • Constante de Ajuste: 500
// Daño provocado = (Ataque * Efectividad) - Defensa) / Constante de Ajuste
// Una vez que se realice el turno actualizar la salud del personaje que defiende
// Salud = Salud – Daño provocado

Console.WriteLine("______________¡¡¡¡¡¡¡¡¡¡COMBATE!!!!!!!!!_________________");

Competencia(listaDePersonajes);

void Competencia(List<Personaje> listaDePersonajes)
{
    Personaje ganadorDeLaCompetencia;

    while (listaDePersonajes.Count() > 1)
    {
        CombateEntreDos(listaDePersonajes);
    }
    ganadorDeLaCompetencia = listaDePersonajes[0];

    Console.WriteLine("\n\n===============================================");
    Console.WriteLine("---------¡GANADOR DE LA COMPETENCIA!-----------");
    Console.WriteLine("===============================================\n\n");
    ganadorDeLaCompetencia.MostrarPersonaje();
}

List<Personaje> CombateEntreDos(List<Personaje> listaDePersonajes)
{
    Random numeroAleatorio = new Random();
    Personaje personajeUno = listaDePersonajes[numeroAleatorio.Next(listaDePersonajes.Count())];
    Personaje personajeDos = listaDePersonajes[numeroAleatorio.Next(listaDePersonajes.Count())];
    Personaje ganadorDelCombate;
    int turno = 1;

    Console.WriteLine("---------CONTRINCANTES-----------");

    if (personajeUno.apodo != personajeDos.apodo)
    {
        Console.WriteLine(personajeUno.apodo + " ···VS··· " + personajeDos.apodo);
        while (personajeUno.salud == 0 || personajeDos.salud == 0)
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
        }

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

        Console.WriteLine("---------GANADOR DEL COMBATE-----------");
        ganadorDelCombate.MostrarPersonaje();
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