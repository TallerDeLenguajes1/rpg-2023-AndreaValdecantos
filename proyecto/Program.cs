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

MostrarPersonajes(listaDePersonajes);

void MostrarPersonajes(List<Personaje> listaDePersonajes)
{
    for (int i = 0; i < listaDePersonajes.Count(); i++)
    {
        listaDePersonajes[i].MostrarPersonaje();
    }
}