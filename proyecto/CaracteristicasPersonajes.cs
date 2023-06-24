//ALu088Eg7OMUs73OS_1L TOKEN
using System.Net;
using System.Text.Json;
namespace PersonajesAPI;

// ObtenerPersonajes();
public class PersonajesJson
{
    public List<Doc> ObtenerPersonajes()
    {
        var url = $"https://the-one-api.dev/v2/character";
        string token = "ALu088Eg7OMUs73OS_1L";
        var request = (HttpWebRequest)WebRequest.Create(url);
        request.Method = "GET";
        request.ContentType = "application/json";
        request.Accept = "application/json";
        request.Headers.Add("Authorization", "Bearer " + token);

        try
        {
            using (WebResponse response = request.GetResponse())
            {
                using (Stream strReader = response.GetResponseStream())
                {
                    if (strReader == null) return null;
                    using (StreamReader objReader = new StreamReader(strReader))
                    {
                        string responseBody = objReader.ReadToEnd();
                        Root personajes = JsonSerializer.Deserialize<Root>(responseBody);
                        List<Doc> PersonajesAPI = personajes.docs;
                        return PersonajesAPI;
                        // Console.WriteLine(listaPersonajes.Count());; // 933 personajes
                        // Random numeroAleatorio = new Random();
                        // for (int i = 0; i < 4; i++)
                        // {
                        //     Console.WriteLine(listaPersonajes[numeroAleatorio.Next(932)].name);
                        // }
                        // foreach (var personaje in listaPersonajes)
                        // {
                        //     Console.WriteLine(personaje.name);
                        // }
                    }
                }
            }
        }
        catch (WebException ex)
        {
            return null;
        }
    }
}