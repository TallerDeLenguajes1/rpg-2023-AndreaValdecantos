//ALu088Eg7OMUs73OS_1L TOKEN
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace RPG;

public class Doc
    {
        [JsonPropertyName("_id")]
        public string _id { get; set; }

        [JsonPropertyName("height")]
        public string height { get; set; }

        [JsonPropertyName("race")]
        public string race { get; set; }

        [JsonPropertyName("gender")]
        public string gender { get; set; }

        [JsonPropertyName("birth")]
        public string birth { get; set; }

        [JsonPropertyName("spouse")]
        public string spouse { get; set; }

        [JsonPropertyName("death")]
        public string death { get; set; }

        [JsonPropertyName("realm")]
        public string realm { get; set; }

        [JsonPropertyName("hair")]
        public string hair { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("wikiUrl")]
        public string wikiUrl { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("docs")]
        public List<Doc> docs { get; set; }

        [JsonPropertyName("total")]
        public int total { get; set; }

        [JsonPropertyName("limit")]
        public int limit { get; set; }

        [JsonPropertyName("offset")]
        public int offset { get; set; }

        [JsonPropertyName("page")]
        public int page { get; set; }

        [JsonPropertyName("pages")]
        public int pages { get; set; }
    }
// ObtenerPersonajes();
public class PersonajesAPIWeb
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