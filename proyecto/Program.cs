using EspecificacionesPersonaje;

FabricaDePersonaje fabrica = new FabricaDePersonaje();
Personaje primerPersonaje = fabrica.generarPersonaje();
Personaje segundoPersonaje = fabrica.generarPersonaje();
Personaje[] listaDePersonajes = {primerPersonaje, segundoPersonaje};
var numeroPersonaje = 0;

foreach (var personaje in listaDePersonajes)
{
    numeroPersonaje++;
    Console.WriteLine("Tipo P"+ numeroPersonaje +": " + personaje.tipo);
    Console.WriteLine("Apodo P"+ numeroPersonaje +": " + personaje.apodo);
    Console.WriteLine("Fecha de nacimiento P"+ numeroPersonaje +": " + personaje.fechaNacimiento);
    Console.WriteLine("Edad P"+ numeroPersonaje +": " + personaje.edad);
    Console.WriteLine("Velocidad P"+ numeroPersonaje +": " + personaje.velocidad);
    Console.WriteLine("Destreza P"+ numeroPersonaje +": " + personaje.destreza);
    Console.WriteLine("Fuerza P"+ numeroPersonaje +": " + personaje.fuerza);
    Console.WriteLine("Nivel P"+ numeroPersonaje +": " + personaje.nivel);
    Console.WriteLine("Armadura P"+ numeroPersonaje +": " + personaje.armadura);
    Console.WriteLine("Salud P"+ numeroPersonaje +": " + personaje.salud);

    Console.WriteLine("--------------------------");
}