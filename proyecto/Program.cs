using EspecificacionesPersonaje;

FabricaDePersonaje fabricaUno = new FabricaDePersonaje();
Personaje primerPersonaje = fabricaUno.generarPersonaje();

Console.WriteLine(primerPersonaje.fechaNacimiento);