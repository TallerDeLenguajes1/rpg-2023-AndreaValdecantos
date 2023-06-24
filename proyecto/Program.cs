using PersonajesAPI;

FabricaDePersonaje fabrica = new FabricaDePersonaje();
//crear función para generar automáticamente personajes y agregarlso a la
List<Personaje> listaDePersonajes = new List<Personaje>();
var numeroPersonaje = 0;

//////intento de función para crear varios personajes

for (int i = 0; i < 5; i++)
{
    listaDePersonajes.Add(fabrica.generarPersonaje());
}

foreach (var personaje in listaDePersonajes)
{
    numeroPersonaje++;
    Console.WriteLine("Tipo P" + numeroPersonaje + ": " + personaje.tipo);
    Console.WriteLine("Apodo P" + numeroPersonaje + ": " + personaje.apodo);
    Console.WriteLine("Fecha de nacimiento P" + numeroPersonaje + ": " + personaje.fechaNacimiento);
    Console.WriteLine("Edad P" + numeroPersonaje + ": " + personaje.edad);
    Console.WriteLine("Velocidad P" + numeroPersonaje + ": " + personaje.velocidad);
    Console.WriteLine("Destreza P" + numeroPersonaje + ": " + personaje.destreza);
    Console.WriteLine("Fuerza P" + numeroPersonaje + ": " + personaje.fuerza);
    Console.WriteLine("Nivel P" + numeroPersonaje + ": " + personaje.nivel);
    Console.WriteLine("Armadura P" + numeroPersonaje + ": " + personaje.armadura);
    Console.WriteLine("Salud P" + numeroPersonaje + ": " + personaje.salud);

    Console.WriteLine("--------------------------");
}