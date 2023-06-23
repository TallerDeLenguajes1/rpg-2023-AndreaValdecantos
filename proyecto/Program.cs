// using EspecificacionesPersonaje;

// FabricaDePersonaje fabrica = new FabricaDePersonaje();
// //crear función para generar automáticamente personajes y agregarlso al array
// // Personaje primerPersonaje = fabrica.generarPersonaje();
// // Personaje segundoPersonaje = fabrica.generarPersonaje();
// // Personaje[] listaDePersonajes = { primerPersonaje, segundoPersonaje };
// Personaje[] listaDePersonajes;
// var numeroPersonaje = 0;

// //////intento de función para crear varios personajes

// Personaje[] crearPersonajes()
// {
//     Personaje pPersonaje = fabrica.generarPersonaje();
//     listaDePersonajes.Append(pPersonaje);
//     return listaDePersonajes;
// }

// for (int i = 0; i < 3; i++)
// {
//     listaDePersonajes = crearPersonajes();
// }

// /////

// //serealizar es pasar a un formato que se puede grabar
// //serializar es convertir a texto, hay que serializar la lista de personajes
// //deserealizar lo convierte de nuevo a objeto

// foreach (var personaje in listaDePersonajes)
// {
//     numeroPersonaje++;
//     Console.WriteLine("Tipo P" + numeroPersonaje + ": " + personaje.tipo);
//     Console.WriteLine("Apodo P" + numeroPersonaje + ": " + personaje.apodo);
//     Console.WriteLine("Fecha de nacimiento P" + numeroPersonaje + ": " + personaje.fechaNacimiento);
//     Console.WriteLine("Edad P" + numeroPersonaje + ": " + personaje.edad);
//     Console.WriteLine("Velocidad P" + numeroPersonaje + ": " + personaje.velocidad);
//     Console.WriteLine("Destreza P" + numeroPersonaje + ": " + personaje.destreza);
//     Console.WriteLine("Fuerza P" + numeroPersonaje + ": " + personaje.fuerza);
//     Console.WriteLine("Nivel P" + numeroPersonaje + ": " + personaje.nivel);
//     Console.WriteLine("Armadura P" + numeroPersonaje + ": " + personaje.armadura);
//     Console.WriteLine("Salud P" + numeroPersonaje + ": " + personaje.salud);

//     Console.WriteLine("--------------------------");
// }