using RPG;

FabricaDePersonaje fabrica = new FabricaDePersonaje();
//crear función para generar automáticamente personajes y agregarlso a la
List<Personaje> listaDePersonajes = new List<Personaje>();
List<Personaje> listaDePersonajes2 = new List<Personaje>();

//////intento de función para crear varios personajes

for (int i = 0; i < 5; i++)
{
    listaDePersonajes.Add(fabrica.generarPersonaje(i));
}

// for (int i = 0; i < listaDePersonajes.Count(); i++)
// {
//     listaDePersonajes[i].MostrarPersonaje();
// }

PersonajesJson archivoJsonPersonajes = new PersonajesJson();
archivoJsonPersonajes.GuardarPersonajes(listaDePersonajes);
listaDePersonajes2 = archivoJsonPersonajes.LeerPersonajes("JsonPersonajes.txt");

for (int i = 0; i < listaDePersonajes2.Count(); i++)
{
    listaDePersonajes2[i].MostrarPersonaje();
}