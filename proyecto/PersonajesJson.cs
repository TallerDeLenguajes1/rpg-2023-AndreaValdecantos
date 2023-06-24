using System.Text.Json;
namespace RPG;
public class PersonajesJson
{
    public void GuardarPersonajes(List<Personaje> listaDePersonajes, string rutaArchivo)
    {
        string personajesJsonizados = JsonSerializer.Serialize(listaDePersonajes); //convierte la lista de objetos en un archivo Json
        // Console.WriteLine("Archivo Serializado : " + personajesJsonizados);

        //ahora hay que guardarlo en un archivo de texto
        using (var archivo = new FileStream(rutaArchivo, FileMode.Create))
        {
            using (var archivoDePersonajes = new StreamWriter(archivo))
            {
                archivoDePersonajes.WriteLine(personajesJsonizados);
                archivoDePersonajes.Close();
            }
        }
    }
    public List<Personaje> LeerPersonajes(string rutaDeArchivo)
    {
        string documento;
        using (var archivoOpen = new FileStream(rutaDeArchivo, FileMode.Open))
        {
            using (var strReader = new StreamReader(archivoOpen))
            {
                documento = strReader.ReadToEnd();
                archivoOpen.Close();
            }
        }

        List<Personaje> personajesDesJsonizados = JsonSerializer.Deserialize<List<Personaje>>(documento); //convierte el archivo Json en una lista de objetos

        return personajesDesJsonizados;
    }

    public bool Existe(string rutaDeArchivo)
    {
        if (File.Exists(rutaDeArchivo))
        {
            List<Personaje> listaPersonajes = LeerPersonajes(rutaDeArchivo);
            if (listaPersonajes.Count() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}