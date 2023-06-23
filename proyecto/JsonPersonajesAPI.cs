using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PersonajesAPI{
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
}