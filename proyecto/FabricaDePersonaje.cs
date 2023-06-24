namespace PersonajesAPI
{

    public class FabricaDePersonaje
    {
        public Personaje generarPersonaje()
        {
            PersonajesJson listaPersonajesJson = new PersonajesJson();
            List<Doc> lista = listaPersonajesJson.ObtenerPersonajes();
            Personaje nuevoPersonaje = new Personaje();
            Random numeroRandom = new Random();
            int numeroPersonaje = numeroRandom.Next(932);
            DateTime fechaInicial = new DateTime(1723, 1, 1);
            DateTime fechaFinal = new DateTime(2023, 6, 23);

            TimeSpan intervalo = fechaFinal - fechaInicial;
            int totalDias = intervalo.Days;

            DateTime fechaAleatoria = fechaInicial.AddDays(numeroRandom.Next(totalDias));


            nuevoPersonaje.tipo = lista[numeroPersonaje].race;
            nuevoPersonaje.apodo = lista[numeroPersonaje].name;
            nuevoPersonaje.fechaNacimiento = fechaAleatoria;
            nuevoPersonaje.edad = numeroRandom.Next(0, 300);
            nuevoPersonaje.velocidad = numeroRandom.Next(1, 10);
            nuevoPersonaje.destreza = numeroRandom.Next(1, 5);
            nuevoPersonaje.fuerza = numeroRandom.Next(1, 10);
            nuevoPersonaje.nivel = numeroRandom.Next(1, 10);
            nuevoPersonaje.armadura = numeroRandom.Next(1, 10);
            nuevoPersonaje.salud = 100;

            return nuevoPersonaje;
        }
    }
}